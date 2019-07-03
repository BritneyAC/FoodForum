using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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
    [HttpPost("/Username")]
    public IActionResult UserName(string Username)
    {
      bool found = false;
      User User = dbContext.Users.FirstOrDefault(user => user.Username == Username);
      if (User != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      return View("UsernamePartial");
    }
    [HttpPost("/LoginUsername")]
    public IActionResult LoginUserName(string Username)
    {
      bool found = false;
      User User = dbContext.Users.FirstOrDefault(user => user.Username == Username);
      if (User != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      return View("LoginUsernamePartial");
    }
    [HttpPost("/UserMaker")]
    public IActionResult UserMaker(User User)
    {
      if (ModelState.IsValid)
      {
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
    public IActionResult LikedRecipes(string Username)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.Username == Username);
      List<Like> LikedRecipes = dbContext.Likes.Include(like => like.Recipe).Where(likes => likes.UserId == UserId).Reverse().ToList();
      ViewBag.LikedRecipes = LikedRecipes;
      return View();
    }
  }
}