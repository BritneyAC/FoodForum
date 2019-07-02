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
  public class AdminController : Controller
  {
    private FoodForumContext dbContext;
    public AdminController(FoodForumContext context)
    {
      dbContext = context;
    }
    [HttpGet("/AdminPage")]
    public IActionResult AdminPage()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        if (User.AdminState == 1)
        {
          List<User> Users = dbContext.Users.ToList();
          ViewBag.Users = Users;
          ViewBag.User = User;
          return View();
        }
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/NewAdminRecipe")]
    public IActionResult NewAdminRecipe()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        if (User.AdminState != 1)
        {
          return RedirectToAction("NewRecipe", "Home");
        }
      }
      return View();
    }
    [HttpPost("/PostAdminRecipe")]
    public IActionResult PostAdminRecipe(AdminRecipe Recipe)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        if (User.AdminState == 1)
        {
          Recipe.UserId = User.UserId;
          if (ModelState.IsValid)
          {
            dbContext.Add(Recipe);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
          }
          return View("NewAdminRecipe");
        }
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/MakeRecipeAdminRecipe/{RecipeId}")]
    public IActionResult MakeRecipeAdminRecipe(int RecipeId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin.AdminState == 1)
      {
        Recipe Recipe = dbContext.Recipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        ViewBag.Recipe = Recipe;
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpPost("/AdminifyRecipe")]
    public IActionResult AdminifyRecipe(AdminRecipe AdminRecipe)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin.AdminState == 1)
      {
        if (ModelState.IsValid)
        {
          Recipe Recipe = dbContext.Recipes.FirstOrDefault(recipe => recipe.RecipeId == AdminRecipe.RecipeId);
          AdminRecipe.CreatedAt = Recipe.CreatedAt;
          dbContext.Remove(Recipe);
          dbContext.Add(AdminRecipe);
          dbContext.SaveChanges();
          return RedirectToAction("Index", "Home");
        }
      }
      return View("MakeRecipeAdminRecipe", new { RecipeId = AdminRecipe.RecipeId });
    }
    [HttpGet("/AdminifyUser/{UserId}")]
    public IActionResult AdminifyUser(int UserId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin.AdminState == 1)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        User.AdminState = 1;
        dbContext.SaveChanges();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/UnAdminifyRecipe/{RecipeId}")]
    public IActionResult UnAdminifyRecipe(int RecipeId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin.AdminState == 1)
      {
        AdminRecipe AdminRecipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        Recipe Recipe = AdminRecipe;
        Recipe.Title = AdminRecipe.Title;
        Recipe.Content = AdminRecipe.Content;
        Recipe.IngredientOne = AdminRecipe.IngredientOne;
        Recipe.IngredientTwo = AdminRecipe.IngredientOne;
        Recipe.IngredientTwo = AdminRecipe.IngredientThree;
        Recipe.IngredientFour = AdminRecipe.IngredientFour;
        Recipe.IngredientFive = AdminRecipe.IngredientFive;
        Recipe.IngredientSix = AdminRecipe.IngredientOne;
        Recipe.IngredientSix = AdminRecipe.IngredientSeven;
        Recipe.IngredientEight = AdminRecipe.IngredientEight;
        Recipe.IngredientNine = AdminRecipe.IngredientNine;
        Recipe.IngredientTen = AdminRecipe.IngredientTen;
        Recipe.IngredientEleven = AdminRecipe.IngredientEleven;
        Recipe.IngredientTwelve = AdminRecipe.IngredientTwelve;
        Recipe.IngredientThirteen = AdminRecipe.IngredientThirteen;
        Recipe.IngredientFourteen = AdminRecipe.IngredientFourteen;
        Recipe.IngredientFifteen = AdminRecipe.IngredientFifteen;
        Recipe.Ingredients = AdminRecipe.Ingredients;
        Recipe.UserId = AdminRecipe.UserId;
        Recipe.User = AdminRecipe.User;
        Recipe.CreatedAt = AdminRecipe.CreatedAt;
        dbContext.Remove(AdminRecipe);
        dbContext.Add(Recipe);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserSubmissions", "Home");
    }
  }
}