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
  public class HomeController : Controller
  {
    private FoodForumContext dbContext;
    public HomeController(FoodForumContext context)
    {
      dbContext = context;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        ViewBag.User = User;
      }
      List<Recipe> RecipesByRating = dbContext.Recipes.Include(recipe => recipe.Likes).Include(recipe => recipe.User).OrderByDescending(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRating = RecipesByRating;
      return View();
    }
    [HttpGet("/IndexRating")]
    public IActionResult IndexRating(){
      List<Recipe> RecipesByRating = dbContext.Recipes.Include(recipe => recipe.Likes).Include(recipe => recipe.User).OrderByDescending(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRating = RecipesByRating;
      return View("IndexRatingPartial");
    }
    [HttpGet("/IndexRatingReverse")]
    public IActionResult IndexRatingReverse(){
      List<Recipe> RecipesByRatingReverse = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderBy(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse;
      return View("IndexRatingReversePartial");
    }
    [HttpGet("/IndexLikes")]
    public IActionResult IndexLikes(){
      List<Recipe> RecipesByLikes = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderByDescending(recipe => recipe.Likes.Count).ToList();
      ViewBag.RecipesByLikes = RecipesByLikes;
      return View("IndexLikesPartial");
    }
    [HttpGet("/IndexLikesReverse")]
    public IActionResult IndexLikesReverse(){
      List<Recipe> RecipesByLikesReverse = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderBy(recipe => recipe.Likes.Count).ToList();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse;
      return View("IndexLikesReversePartial");
    }
    [HttpGet("/UserRecipes")]
    public IActionResult UserRecipes()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        ViewBag.User = User;
      }
      List<Recipe> RecipesByRating = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderByDescending(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRating = RecipesByRating;
      return View();
    }
    [HttpGet("/UserRating")]
    public IActionResult UserRating(){
      List<Recipe> RecipesByRating = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderByDescending(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRating = RecipesByRating;
      return View("UserRatingPartial");
    }
    [HttpGet("/UserRatingReverse")]
    public IActionResult UserRatingReverse(){
      List<Recipe> RecipesByRatingReverse = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderBy(recipe => recipe.GetRating()).ToList();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse;
      return View("UserRatingReversePartial");
    }
    [HttpGet("/UserLikes")]
    public IActionResult UserLikes(){
      List<Recipe> RecipesByLikes = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderByDescending(recipe => recipe.Likes.Count).ToList();
      ViewBag.RecipesByLikes = RecipesByLikes;
      return View("UserLikesPartial");
    }
    [HttpGet("/UserLikesReverse")]
    public IActionResult UserLikesReverse(){
      List<Recipe> RecipesByLikesReverse = dbContext.Recipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).OrderBy(recipe => recipe.Likes.Count).ToList();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse;
      return View("UserLikesReverse");
    }
  }
}
