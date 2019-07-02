using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      Recipe Recipe = dbContext.Recipes.Include(recipe => recipe.Likes).Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.Title == Title);
      int Rating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId).Rate;
      bool Liked = false;
      if (Recipe.Likes.Contains(ViewBag.User))
      {
        Liked = true;
        ViewBag.Like = Recipe.Likes.FirstOrDefault(like => like.UserId == UserId);
      }
      ViewBag.User = User;
      ViewBag.Liked = Liked;
      ViewBag.Recipe = Recipe;
      ViewBag.Rating = Rating;
      return View();
    }
    [HttpGet("/NewUserRecipe")]
    public IActionResult NewUserRecipe()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User.AdminState == 1)
      {
        return RedirectToAction("AdminNewRecipe", "Admin");
      }
      ViewBag.User = User;
      return View();
    }
    [HttpPost("/PostUserRecipe")]
    public IActionResult PostUserRecipe(Recipe Recipe)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        if (User.AdminState != 1)
        {
          Recipe.UserId = User.UserId;
          if (ModelState.IsValid)
          {
            dbContext.Add(Recipe);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
          }
          return View("NewUserRecipe");
        }
        return View("NewAdminRecipe");
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/UserRecipe/Like")]
    public IActionResult UserRecipeLike(Like Like)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.Recipes.FirstOrDefault(recipe => recipe.RecipeId == Like.RecipeId);
        Like.UserId = UserId.Value;
        Like.User = User;
        Like.Recipe = Recipe;
        dbContext.Add(Like);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { RecipeId = Like.RecipeId });
    }
    [HttpGet("/UserRecipe/UnLike")]
    public IActionResult UnLikeUserRecipe(int LikeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      Like Like = dbContext.Likes.FirstOrDefault(like => like.LikeId == LikeId);
      int RecipeId = Like.RecipeId;
      dbContext.Remove(Like);
      dbContext.SaveChanges();
      return RedirectToAction("UserRecipe", new { RecipeId = RecipeId });
    }
    [HttpPost("/UserRecipe/Comment")]
    public IActionResult Comment(Comment Comment)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.Recipes.FirstOrDefault(recipe => recipe.RecipeId == Comment.RecipeId);
        Comment.UserId = UserId.Value;
        Comment.User = User;
        Comment.Recipe = Recipe;
        dbContext.Add(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { RecipeId = Comment.RecipeId });
    }
    [HttpPost("/UserRecipe/Rate")]
    public IActionResult RateUserRecipe(Rating Rating)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.Recipes.FirstOrDefault(recipe => recipe.RecipeId == Rating.RecipeId);
        Rating.UserId = UserId.Value;
        Rating.User = User;
        Rating.Recipe = Recipe;
        dbContext.Add(Rating);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { RecipeId = Rating.RecipeId });
    }
    [HttpPost("/UserRecipe/UpdateRating")]
    public IActionResult UpdateRating(int RatingId, int Rate)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      Rating Rating = dbContext.Ratings.FirstOrDefault(rating => rating.RatingId == RatingId);
      if (UserId == Rating.UserId)
      {
        Rating.Rate = Rate;
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { RecipeId = Rating.RecipeId });
    }
  }
}