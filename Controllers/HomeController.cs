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
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      List<AdminRecipe> RecipesByRating = dbContext.AdminRecipes.Include(recipe => recipe.Likes).Include(recipe => recipe.Ratings).Include(recipe => recipe.User).ToList();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      ViewBag.User = User;
      return View();
    }
    [HttpGet("/IndexRating")]
    public async Task<IActionResult> IndexRatingAsync(){
      List<AdminRecipe> RecipesByRating = await dbContext.AdminRecipes.Include(recipe => recipe.Likes).Include(recipe => recipe.Ratings).Include(recipe => recipe.User).ToListAsync();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      return View("IndexRatingPartial");
    }
    [HttpGet("/IndexRatingReverse")]
    public async Task<IActionResult> IndexRatingReverseAsync(){
      List<AdminRecipe> RecipesByRatingReverse =  await dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse.OrderBy(recipe => recipe.GetRating());
      return View("IndexRatingReversePartial");
    }
    [HttpGet("/IndexLikes")]
    public async Task<IActionResult> IndexLikesAsync(){
      List<AdminRecipe> RecipesByLikes = await dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByLikes = RecipesByLikes.OrderByDescending(recipe => recipe.Likes.Count);
      return View("IndexLikesPartial");
    }
    [HttpGet("/IndexLikesReverse")]
    public async Task<IActionResult> IndexLikesReverseAsync(){
      List<AdminRecipe> RecipesByLikesReverse = await dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse.OrderBy(recipe => recipe.Likes.Count);
      return View("IndexLikesReversePartial");
    }
    [HttpGet("/IndexTime")]
    public async Task<IActionResult> IndexTimeAsync(){
      List<AdminRecipe> RecipesByNewest = await dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      RecipesByNewest.Reverse();
      ViewBag.RecipesByNewest = RecipesByNewest;
      return View("IndexNewestPartial");
    }
    [HttpGet("/IndexTimeReverse")]
    public async Task<IActionResult> IndexTimeReverseAsync(){
      List<AdminRecipe> RecipesByOldest = await dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByOldest = RecipesByOldest;
      return View("IndexOldestPartial");
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
      List<UserRecipe> RecipesByRating = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      return View();
    }
    [HttpGet("/UserRating")]
    public async Task<IActionResult> UserRatingAsync(){
      List<UserRecipe> RecipesByRating = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      return View("UserRatingPartial");
    }
    [HttpGet("/UserRatingReverse")]
    public async Task<IActionResult> UserRatingReverseAsync(){
      List<UserRecipe> RecipesByRatingReverse = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse.OrderBy(recipe => recipe.GetRating());
      return View("UserRatingReversePartial");
    }
    [HttpGet("/UserLikes")]
    public async Task<IActionResult> UserLikesAsync(){
      List<UserRecipe> RecipesByLikes = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByLikes = RecipesByLikes.OrderByDescending(recipe => recipe.Likes.Count);
      return View("UserLikesPartial");
    }
    [HttpGet("/UserLikesReverse")]
    public async Task<IActionResult> UserLikesReverseAsync(){
      List<UserRecipe> RecipesByLikesReverse = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse.OrderBy(recipe => recipe.Likes.Count);
      return View("UserLikesReversePartial");
    }
    [HttpGet("/UserTime")]
    public async Task<IActionResult> UserTimeAsync(){
      List<UserRecipe> RecipesByNewest = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      RecipesByNewest.Reverse();
      ViewBag.RecipesByNewest = RecipesByNewest;
      return View("UserTimePartial");
    }
    [HttpGet("/UserTimeReverse")]
    public async Task<IActionResult> UserTimeReverseAsync(){
      List<UserRecipe> RecipesByOldest = await dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToListAsync();
      ViewBag.RecipesByOldest = RecipesByOldest;
      return View("UserTimeReversePartial");
    }
  }
}
