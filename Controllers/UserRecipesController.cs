using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodForum.Controllers
{
  public class UserRecipesController : Controller
  {
    private FoodForumContext dbContext;
    public UserRecipesController(FoodForumContext context)
    {
      dbContext = context;
    }
    [HttpGet("/UserRecipe/{Title}")]
    public IActionResult UserRecipe(string Title)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.Title == Title);
      if(User != null)
      {
        Rating Rating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId);
        ViewBag.Rating = Rating;
      }
      bool Liked = false;
      if (Recipe.Likes.FirstOrDefault(like => like.UserId == UserId) != null)
      {
        Liked = true;
        ViewBag.Like = Recipe.Likes.FirstOrDefault(like => like.UserId == UserId);
      }
      List<Comment> Comments = dbContext.Comments.Include(comment => comment.Recipe).Include(comment => comment.User).Where(comment => comment.RecipeId == Recipe.RecipeId).ToList();
      Comments.Reverse();
      ViewBag.Comments = Comments;
      ViewBag.User = User;
      ViewBag.Liked = Liked;
      ViewBag.Recipe = Recipe;
      return View();
    }
    [HttpGet("/NewUserRecipe")]
    public IActionResult NewUserRecipe()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState == 1)
        {
          return RedirectToAction("AdminNewRecipe", "Admin");
        }
        ViewBag.User = User;
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpPost("/UserRecipeTitle")]
    public IActionResult UserRecipeTitle(string Title)
    {
      bool found = false;
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.Title == Title);
      if (Recipe != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      return View("UserRecipeTitlePartial");
    }
    [HttpPost("/PostUserRecipe")]
    public IActionResult PostUserRecipe(UserRecipe Recipe)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState != 1)
        {
          Recipe.UserId = User.UserId;
          if (ModelState.IsValid)
          {
            if (!dbContext.AdminRecipes.Any(recipe => recipe.Title == Recipe.Title) || !dbContext.UserRecipes.Any(recipe => recipe.Title == Recipe.Title))
            {
              dbContext.Add(Recipe);
              dbContext.SaveChanges();
              return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("Title", "A recipe already has that title");
          }
          return View("NewUserRecipe");
        }
        return View("NewAdminRecipe");
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpPost("/UserRecipe/{RecipeId}/Delete")]
    public IActionResult DeleteUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        if (Recipe.UserId == UserId || User.AdminState == 1)
        {
          dbContext.Remove(Recipe);
          dbContext.SaveChanges();
          return RedirectToAction("UserRecipes");
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Like/{RecipeId}")]
    public IActionResult LikeUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.Likes).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        if (Recipe.Likes.FirstOrDefault(like => like.UserId == UserId) == null)
        {
          Like Like = new Like();
          Like.RecipeId = RecipeId;
          Like.Recipe = Recipe;
          Like.UserId = UserId.Value;
          Like.User = User;
          dbContext.Add(Like);
          dbContext.SaveChanges();
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Unlike/{RecipeId}")]
    public IActionResult UnLikeUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Likes).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        Like Like = User.Likes.FirstOrDefault(like => like.RecipeId == RecipeId);
        dbContext.Remove(Like);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/{RecipeId}/Comment")]
    public IActionResult CommentOnUserRecipe(int RecipeId, Comment Comment)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (UserId != null)
      {
        Comment.UserId = UserId.Value;
        Comment.User = User;
        Comment.Recipe = Recipe;
        dbContext.Add(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/{RecipeId}/DeleteComment/{CommentId}")]
    public IActionResult DeleteCommentOnUserRecipe(int RecipeId, int CommentId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      Comment Comment = dbContext.Comments.FirstOrDefault(comment => comment.CommentId == CommentId);
      if (UserId != Comment.UserId || User.AdminState != 1)
      {
        dbContext.Remove(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Rate/{RecipeId}")]
    public IActionResult RateUserRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == Rating.RecipeId);
      if (UserId != null)
      {
        if(User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId) == null)
        {
          if (Rating.Rate > 0 && Rating.Rate < 6)
          {
            Rating.UserId = UserId.Value;
            Rating.User = User;
            Rating.Recipe = Recipe;
            dbContext.Add(Rating);
            dbContext.SaveChanges();
          }
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/UpdateRating/{RecipeId}")]
    public IActionResult UpdateRateUserRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      Rating UserRating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == RecipeId);
      if (UserRating != null)
      {
        if (UserId == UserRating.UserId)
        {
          if (Rating.Rate > 0 && Rating.Rate < 6)
          {
            UserRating.Rate = Rating.Rate;
            dbContext.SaveChanges();
          }
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
  }
}