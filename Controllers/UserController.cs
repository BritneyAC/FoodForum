using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FoodForum.Controllers
{
  public class UserController : Controller
  {
    private FoodForumContext dbContext;
    public UserController(FoodForumContext context)
    {
      dbContext = context;
    }
    [HttpGet("/Login")]
    public IActionResult Login()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      if (UserId != null)
      {
        return RedirectToAction("Index", "Home");
      }
      return View();
    }
    [HttpGet("/Username")]
    public async Task<IActionResult> UsernameAsync(string Username)
    {
      bool found = false;
      User User = await dbContext.Users.FirstOrDefaultAsync(user => user.Username == Username);
      if (User != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      ViewBag.Partial = true;
      return View("UsernamePartial");
    }
    [HttpGet("/LoginUsername")]
    public async Task<IActionResult> LoginUsernameAsync(string Username)
    {
      bool found = false;
      User User = await dbContext.Users.FirstOrDefaultAsync(user => user.Username == Username);
      if (User != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      ViewBag.Partial = true;
      return View("LoginUsernamePartial");
    }
    [HttpPost("/UserMaker")]
    public IActionResult UserMaker(User User)
    {
      if (ModelState.IsValid)
      {
        if (!dbContext.Users.Any(user => user.Username == User.Username)){
          PasswordHasher<User> Hasher = new PasswordHasher<User>();
          User.Password = Hasher.HashPassword(User, User.Password);
          dbContext.Add(User);
          dbContext.SaveChanges();
          if (User.UserId == 1)
          {
            User.AdminState = 1;
          }
          dbContext.SaveChanges();
          HttpContext.Session.Clear();
          HttpContext.Session.SetInt32("UserId", User.UserId);
          return RedirectToAction("Index", "Home");
        }
        ModelState.AddModelError("Username", "A user already has that Username");
      }
      return View("Login");
    }
    [HttpPost("/LogUserIn")]
    public IActionResult LogUserIn(LoginUser userSubmission)
    {
      if (ModelState.IsValid)
      {
        var userInDb = dbContext.Users.FirstOrDefault(User => User.Username == userSubmission.Username);
        if (userInDb == null)
        {
          ModelState.AddModelError("UserName", "Invalid UserName/Password");
          return View("Login");
        }
        var Hasher = new PasswordHasher<LoginUser>();
        var result = Hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
        if (result == 0)
        {
          ModelState.AddModelError("UserName", "Invalid UserName/Password");
          return View("Login");
        }
        HttpContext.Session.Clear();
        HttpContext.Session.SetInt32("UserId", userInDb.UserId);
        return RedirectToAction("Index", "Home");
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/Logout")]
    public IActionResult Logout()
    {
      HttpContext.Session.Clear();
      return RedirectToAction("Index", "Home");
    }
    
    [HttpGet("/ProfilePage/{Username}")]
    public IActionResult ProfilePage(string Username)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User CurrentUser = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      ViewBag.CurrentUser = CurrentUser;
      User User = dbContext.Users.FirstOrDefault(user => user.Username == Username);
      List<Like> LikedRecipes = dbContext.Likes.Where(like => like.UserId == User.UserId).Include(like => like.User).Include(like => like.Recipe).ThenInclude(recipe => recipe.Ratings).ToList();
      ViewBag.User = User;
      LikedRecipes.OrderByDescending(recipe => recipe.User.Ratings.OrderByDescending(rating => rating.Rate));
      ViewBag.LikedRecipes = LikedRecipes;
      return View();
    }
  }
}