using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodForum.Controllers
{
  public class RecipesController : Controller
  {
    private FoodForumContext dbContext;
    public RecipesController(FoodForumContext context)
    {
      dbContext = context;
    }
    [HttpGet("/Recipe/{Title}")]
    public IActionResult Recipe(string Title)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).Include(recipe => recipe.Comments).Include(recipe => recipe.Ratings).FirstOrDefault(recipe => recipe.Title == Title);
      if(User != null)
      {
        Rating Rating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId);
        ViewBag.Rating = Rating;
        bool Liked = false;
        if (Recipe.Likes.FirstOrDefault(like => like.UserId == UserId) != null)
        {
          Liked = true;
          ViewBag.Like = Recipe.Likes.FirstOrDefault(like => like.UserId == UserId);
        }
        ViewBag.Liked = Liked;
      }
      List<Comment> Comments = dbContext.Comments.Include(comment => comment.Recipe).Include(comment => comment.User).Where(comment => comment.RecipeId == Recipe.RecipeId).ToList();
      Comments.Reverse();
      ViewBag.Comments = Comments;
      ViewBag.User = User;
      
      ViewBag.Recipe = Recipe;
      
      return View();
    }
    [HttpPost("/PostRecipe")]
    public IActionResult PostRecipe(Recipe Recipe)
    {

      if (ModelState.IsValid)
      {
        if (dbContext.AdminRecipes.Any(recipe => recipe.Title == Recipe.Title) || dbContext.UserRecipes.Any(recipe => recipe.Title == Recipe.Title))
        {
          dbContext.Add(Recipe);
          dbContext.SaveChanges();
          return RedirectToAction("Index");
        }
        ModelState.AddModelError("Title", "A recipe already has that title");
      }
      return View("NewAdminRecipe");
    }
    [HttpPost("/Recipe/Like/{RecipeId}")]
    public IActionResult LikeRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.Likes).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
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
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
    [HttpPost("/Recipe/Unlike/{RecipeId}")]
    public IActionResult UnLikeRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Likes).FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        Like Like = User.Likes.FirstOrDefault(like => like.RecipeId == RecipeId);
        dbContext.Remove(Like);
        dbContext.SaveChanges();
      }
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
    [HttpPost("/Recipe/{RecipeId}/Comment")]
    public IActionResult CommentOnRecipe(int RecipeId, Comment Comment)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Recipes).Include(user => user.Comments).FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (UserId != null)
      {
        Comment.UserId = User.UserId;
        Comment.User = User;
        Comment.Recipe = Recipe;
        Comment.RecipeId = Recipe.RecipeId;
        TryValidateModel(Comment);
        ModelState.Remove("User.ConfirmPassword");
        ModelState.Remove("Recipe.User.ConfirmPassword");
        ModelState.Remove("User");
        ModelState.Remove("Recipe");
        if (ModelState.IsValid){
          dbContext.Add(Comment);
          dbContext.SaveChanges();
        }
      }
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
    [HttpPost("/Recipe/{RecipeId}/DeleteComment/{CommentId}")]
    public IActionResult DeleteCommentOnRecipe(int RecipeId, int CommentId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      Comment Comment = dbContext.Comments.FirstOrDefault(comment => comment.CommentId == CommentId);
      if (UserId != Comment.UserId || User.AdminState == 1)
      {
        dbContext.Remove(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
    [HttpPost("/Recipe/Rate/{RecipeId}")]
    public IActionResult RateRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == Rating.RecipeId);
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
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
    [HttpPost("/Recipe/UpdateRating/{RecipeId}")]
    public IActionResult UpdateRateRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
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
      return RedirectToAction("Recipe", new { Title = Recipe.Title });
    }
  }
}