using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
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
    public IActionResult IndexRating(){
      List<AdminRecipe> RecipesByRating = dbContext.AdminRecipes.Include(recipe => recipe.Likes).Include(recipe => recipe.Ratings).Include(recipe => recipe.User).ToList();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      return View("IndexRatingPartial");
    }
    [HttpGet("/IndexRatingReverse")]
    public IActionResult IndexRatingReverse(){
      List<AdminRecipe> RecipesByRatingReverse =  dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse.OrderBy(recipe => recipe.GetRating());
      return View("IndexRatingReversePartial");
    }
    [HttpGet("/IndexLikes")]
    public IActionResult IndexLikes(){
      List<AdminRecipe> RecipesByLikes = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByLikes = RecipesByLikes.OrderByDescending(recipe => recipe.Likes.Count);
      return View("IndexLikesPartial");
    }
    [HttpGet("/IndexLikesReverse")]
    public IActionResult IndexLikesReverse(){
      List<AdminRecipe> RecipesByLikesReverse = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse.OrderBy(recipe => recipe.Likes.Count);
      return View("IndexLikesReversePartial");
    }
    [HttpGet("/IndexTime")]
    public IActionResult IndexTime(){
      List<AdminRecipe> RecipesByNewest = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      RecipesByNewest.Reverse();
      ViewBag.RecipesByNewest = RecipesByNewest;
      return View("IndexNewestPartial");
    }
    [HttpGet("/IndexTimeReverse")]
    public IActionResult IndexTimeReverse(){
      List<AdminRecipe> RecipesByOldest = dbContext.AdminRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
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
    public IActionResult UserRating(){
      List<UserRecipe> RecipesByRating = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByRating = RecipesByRating.OrderByDescending(recipe => recipe.GetRating());
      return View("UserRatingPartial");
    }
    [HttpGet("/UserRatingReverse")]
    public IActionResult UserRatingReverse(){
      List<UserRecipe> RecipesByRatingReverse = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByRatingReverse = RecipesByRatingReverse.OrderBy(recipe => recipe.GetRating());
      return View("UserRatingReversePartial");
    }
    [HttpGet("/UserLikes")]
    public IActionResult UserLikes(){
      List<UserRecipe> RecipesByLikes = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByLikes = RecipesByLikes.OrderByDescending(recipe => recipe.Likes.Count);
      return View("UserLikesPartial");
    }
    [HttpGet("/UserLikesReverse")]
    public IActionResult UserLikesReverse(){
      List<UserRecipe> RecipesByLikesReverse = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByLikesReverse = RecipesByLikesReverse.OrderBy(recipe => recipe.Likes.Count);
      return View("UserLikesReversePartial");
    }
    [HttpGet("/UserTime")]
    public IActionResult UserTime(){
      List<UserRecipe> RecipesByNewest = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      RecipesByNewest.Reverse();
      ViewBag.RecipesByNewest = RecipesByNewest;
      return View("UserTimePartial");
    }
    [HttpGet("/UserTimeReverse")]
    public IActionResult UserTimeReverse(){
      List<UserRecipe> RecipesByOldest = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).ToList();
      ViewBag.RecipesByOldest = RecipesByOldest;
      return View("UserTimeReversePartial");
    }
  }
}
