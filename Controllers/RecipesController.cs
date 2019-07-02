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
        if(Recipe.Ratings.FirstOrDefault(rating => rating.UserId == User.UserId) != null){
          Rating Rating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId);
          ViewBag.Rating = Rating;
        }
      }
      
      bool Liked = false;
      if (Recipe.Likes.Contains(ViewBag.User))
      {
        Liked = true;
        ViewBag.Like = Recipe.Likes.FirstOrDefault(like => like.UserId == UserId);
      }
      ViewBag.User = User;
      ViewBag.Liked = Liked;
      ViewBag.Recipe = Recipe;
      
      return View();
    }
    [HttpPost("/PostRecipe")]
    public IActionResult PostRecipe(Recipe Recipe)
    {

      if (ModelState.IsValid)
      {
        dbContext.Add(Recipe);
        dbContext.SaveChanges();
        return RedirectToAction("UserRecipes");
      }
      return View("NewRecipe");
    }
    [HttpGet("/Recipe/Like")]
    public IActionResult LikeRecipe(Like Like)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == Like.RecipeId);
        Like.UserId = UserId.Value;
        Like.User = User;
        Like.Recipe = Recipe;
        dbContext.Add(Like);
        dbContext.SaveChanges();
      }
      return RedirectToAction("Recipe", new { RecipeId = Like.RecipeId });
    }
    [HttpPost("/Recipe/Unlike")]
    public IActionResult UnLikeRecipe(int LikeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      Like Like = dbContext.Likes.FirstOrDefault(like => like.LikeId == LikeId);
      int RecipeId = Like.RecipeId;
      dbContext.Remove(Like);
      dbContext.SaveChanges();
      return RedirectToAction("Recipe", new { RecipeId = RecipeId });
    }
    [HttpPost("/Recipe/Comment")]
    public IActionResult Comment(Comment Comment)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == Comment.RecipeId);
        Comment.UserId = UserId.Value;
        Comment.User = User;
        Comment.Recipe = Recipe;
        dbContext.Add(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("Recipe", new { RecipeId = Comment.RecipeId });
    }
    [HttpPost("/Recipe/Rate")]
    public IActionResult RateRecipe(Rating Rating)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (UserId != null)
      {
        Recipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == Rating.RecipeId);
        List<Rating> Ratings = User.Ratings;
        if(Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId) == null){
          Rating.UserId = UserId.Value;
          Rating.User = User;
          Rating.Recipe = Recipe;
          dbContext.Add(Rating);
          dbContext.SaveChanges();
        }
      }
      return RedirectToAction("Recipe", new { RecipeId = Rating.RecipeId });
    }
    [HttpPost("/Recipe/UpdateRating")]
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
      return RedirectToAction("Recipe", new { RecipeId = Rating.RecipeId });
    }
  }
}