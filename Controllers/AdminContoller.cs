using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FoodForum.Controllers
{
  public class AdminController : Controller
  {
    private IConfiguration configuration;
    private FoodForumContext dbContext;
    public AdminController(FoodForumContext context, IConfiguration iConfig)
    {
      dbContext = context;
      configuration = iConfig;
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
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState != 1)
        {
          return RedirectToAction("NewRecipe", "Home");
        }
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/RecipeTitle")]
    public async Task<IActionResult> RecipeTitleAsync(string Title)
    {
      bool found = false;
      AdminRecipe Recipe = await dbContext.AdminRecipes.FirstOrDefaultAsync(recipe => recipe.Title == Title);
      if (Recipe != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      ViewBag.Partial = true;
      return View("RecipeTitlePartial");
    }
    [HttpPost("/PostAdminRecipe")]
    public async Task<IActionResult> PostAdminRecipeAsync(AdminRecipe Recipe)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState == 1)
        {
          Recipe.UserId = User.UserId;
          if (dbContext.Recipes.Any(recipe => recipe.Title == Recipe.Title))
          {
            ModelState.AddModelError("Title", "A recipe already has that title");
            return View("NewAdminRecipe");
          }
          if(Recipe.UploadPicture != null)
          {
            var container = Recipe.GetBlobContainer(configuration.GetSection("PictureBlobInfo:AzureStorageConnectionString").Value, "foodforumpictures");
            var Content = ContentDispositionHeaderValue.Parse(Recipe.UploadPicture.ContentDisposition);
            var FileName = Content.FileName.ToString().Trim('"');
            var blockBlob = container.GetBlockBlobReference(FileName);
            BlobRequestOptions options = new BlobRequestOptions();
            options.SingleBlobUploadThresholdInBytes = 16777216;
            await blockBlob.UploadFromStreamAsync(Recipe.UploadPicture.OpenReadStream());
            Recipe.PictureURL = blockBlob.Uri.AbsoluteUri;
          }
          if (ModelState.IsValid)
          {
            if(!dbContext.Recipes.Any(recipe => recipe.PictureURL == Recipe.PictureURL)||Recipe.UploadPicture == null)
            {
              dbContext.Add(Recipe);
              dbContext.SaveChanges();
              return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("UploadPicture", "A recipe already has a picture with that file name, please rename it and try again");
          }
          return View("NewAdminRecipe");
        }
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpGet("/Recipe/{Title}/Update")]
    public IActionResult UpdateRecipe(string Title)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null && User.AdminState == 1)
      {
        AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.User).FirstOrDefault(recipe => recipe.Title == Title);
        ViewBag.Recipe = Recipe;
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    // Not Implemented do to it requiring model mapping/ not finding it necessary at this time
    [HttpPost("/Recipe/{RecipeId}/Updating")]
    public async Task<IActionResult> UpdatingRecipeAsync(int RecipeId, UpdateRecipe UpdateRecipe, string Content)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        AdminRecipe Recipe = dbContext.AdminRecipes.Include(recipe => recipe.User).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        if (User.AdminState == 1)
        {
          if (UpdateRecipe.UploadPicture != null)
          {
            var container = Recipe.GetBlobContainer(configuration.GetSection("PictureBlobInfo:AzureStorageConnectionString").Value, "foodforumpictures");
            var PictureContent = ContentDispositionHeaderValue.Parse(UpdateRecipe.UploadPicture.ContentDisposition);
            var FileName = PictureContent.FileName.ToString().Trim('"');
            var blockBlob = container.GetBlockBlobReference(FileName);
            BlobRequestOptions options = new BlobRequestOptions();
            options.SingleBlobUploadThresholdInBytes = 16777216;
            await blockBlob.UploadFromStreamAsync(UpdateRecipe.UploadPicture.OpenReadStream());
            UpdateRecipe.PictureURL = blockBlob.Uri.AbsoluteUri;
            if (UpdateRecipe.PictureURL != null && !dbContext.Recipes.Any(recipe => recipe.PictureURL == UpdateRecipe.PictureURL))
            {
              Recipe.PictureURL = UpdateRecipe.PictureURL;
            }
          }
          Recipe.Title = UpdateRecipe.Title;
          Recipe TitleCheck = dbContext.Recipes.FirstOrDefault(recipe => recipe.Title == Recipe.Title);
          if (TitleCheck != null && TitleCheck.RecipeId != Recipe.RecipeId)
          {
            ViewBag.Recipe = Recipe;
            ModelState.AddModelError("Title", "A recipe already has that title");
            return View("UpdateRecipe");
          }
          Recipe.Note = UpdateRecipe.Note;
          Recipe.Content = Content;
          Recipe.IngredientOne = UpdateRecipe.IngredientOne;
          Recipe.IngredientTwo = UpdateRecipe.IngredientTwo;
          Recipe.IngredientThree = UpdateRecipe.IngredientThree;
          Recipe.IngredientFour = UpdateRecipe.IngredientFour;
          Recipe.IngredientFive = UpdateRecipe.IngredientFive;
          Recipe.IngredientSix = UpdateRecipe.IngredientSix;
          Recipe.IngredientSeven = UpdateRecipe.IngredientSeven;
          Recipe.IngredientEight = UpdateRecipe.IngredientEight;
          Recipe.IngredientNine = UpdateRecipe.IngredientNine;
          Recipe.IngredientTen = UpdateRecipe.IngredientTen;
          Recipe.IngredientEleven = UpdateRecipe.IngredientEleven;
          Recipe.IngredientTwelve = UpdateRecipe.IngredientTwelve;
          Recipe.IngredientThirteen = UpdateRecipe.IngredientThirteen;
          Recipe.IngredientFourteen = UpdateRecipe.IngredientFourteen;
          Recipe.IngredientFifteen = UpdateRecipe.IngredientFifteen;
          Recipe.UpdatedAt = UpdateRecipe.CreatedAt;
          Recipe.User.ConfirmPassword = null;
          TryValidateModel(Recipe);
          ModelState.Remove("User.ConfirmPassword");
          if (UpdateRecipe.PictureURL != null && dbContext.Recipes.Any(recipe => recipe.PictureURL == Recipe.PictureURL))
          {
            ModelState.AddModelError("UploadPicture", "A recipe already has a picture with that file name, please rename it and try again");
          }
          if (ModelState.IsValid)
          {
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
          }
          ViewBag.Recipe = Recipe;
          return View("UpdateRecipe");
        }
        return RedirectToAction("Recipe", "Recipes", new { Title = Recipe.Title});
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpPost("/Recipe/{RecipeId}/Delete")]
    public IActionResult DeleteRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      AdminRecipe Recipe = dbContext.AdminRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if(Recipe != null)
      {
        if (User != null && User.AdminState == 1)
        {
          dbContext.Remove(Recipe);
          dbContext.SaveChanges();
          return RedirectToAction("Index", "Home");
        }
        return RedirectToAction("Recipe", "Recipes", new { Title = Recipe.Title });
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/MakeRecipeAdminRecipe/{Title}")]
    public IActionResult MakeRecipeAdminRecipe(string Title)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null && Admin.AdminState == 1)
      {
        UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.Title == Title);
        ViewBag.Recipe = Recipe;
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpPost("/AdminifyRecipe/{RecipeId}")]
    public IActionResult AdminifyRecipe(AdminRecipe Recipe, int RecipeId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null && Admin.AdminState == 1)
      {
        UserRecipe UserRecipe = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Likes).Include(recipe => recipe.Ratings).Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        Recipe.Content = UserRecipe.Content;
        Recipe.PictureURL = UserRecipe.PictureURL;
        Recipe.IngredientOne = UserRecipe.IngredientOne;
        Recipe.IngredientTwo = UserRecipe.IngredientOne;
        Recipe.IngredientThree = UserRecipe.IngredientThree;
        Recipe.IngredientFour = UserRecipe.IngredientFour;
        Recipe.IngredientFive = UserRecipe.IngredientFive;
        Recipe.IngredientSix = UserRecipe.IngredientOne;
        Recipe.IngredientSix = UserRecipe.IngredientSeven;
        Recipe.IngredientEight = UserRecipe.IngredientEight;
        Recipe.IngredientNine = UserRecipe.IngredientNine;
        Recipe.IngredientTen = UserRecipe.IngredientTen;
        Recipe.IngredientEleven = UserRecipe.IngredientEleven;
        Recipe.IngredientTwelve = UserRecipe.IngredientTwelve;
        Recipe.IngredientThirteen = UserRecipe.IngredientThirteen;
        Recipe.IngredientFourteen = UserRecipe.IngredientFourteen;
        Recipe.IngredientFifteen = UserRecipe.IngredientFifteen;
        UserRecipe.RecipeId = 9999999;
        Recipe.RecipeId = RecipeId;
        Recipe.Ingredients = UserRecipe.Ingredients;
        Recipe.UserId = UserRecipe.UserId;
        Recipe.User = UserRecipe.User;
        Recipe.Likes = UserRecipe.Likes;
        Recipe.Comments = UserRecipe.Comments;
        Recipe.Ratings = UserRecipe.Ratings;
        Recipe.CreatedAt = UserRecipe.CreatedAt;
        dbContext.Remove(UserRecipe);
        dbContext.Add(Recipe);
        dbContext.SaveChanges();
        return RedirectToAction("Index", "Home");
        // return View("MakeRecipeAdminRecipe", new { Title = Recipe.Title });
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/AdminifyUser/{UserId}")]
    public IActionResult AdminifyUser(int UserId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null)
      {
        if (Admin.AdminState == 1)
        {
          User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
          User.AdminState = 1;
          dbContext.SaveChanges();
          return RedirectToAction("AdminPage");
        }
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/UnAdminifyUser/{UserId}")]
    public IActionResult UnAdminifyUser(int UserId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null)
      {
        if (Admin.AdminState == 1)
        {
          User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
          User.AdminState = 0;
          dbContext.SaveChanges();   
          return RedirectToAction("AdminPage");
        }
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/UnAdminifyRecipe/{RecipeId}")]
    public IActionResult UnAdminifyRecipe(int RecipeId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null && Admin.AdminState == 1)
      {
        AdminRecipe AdminRecipe = dbContext.AdminRecipes.Include(recipe => recipe.Likes).Include(recipe => recipe.Comments).Include(recipe => recipe.Ratings).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        UserRecipe Recipe = new UserRecipe();
        Recipe.Title = AdminRecipe.Title;
        Recipe.Content = AdminRecipe.Content;
        Recipe.PictureURL = AdminRecipe.PictureURL;
        Recipe.IngredientOne = AdminRecipe.IngredientOne;
        Recipe.IngredientTwo = AdminRecipe.IngredientOne;
        Recipe.IngredientThree = AdminRecipe.IngredientThree;
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
        AdminRecipe.RecipeId = 99999;
        Recipe.RecipeId = RecipeId;
        Recipe.Ingredients = AdminRecipe.Ingredients;
        Recipe.UserId = AdminRecipe.UserId;
        Recipe.User = AdminRecipe.User;
        Recipe.Likes = AdminRecipe.Likes;
        Recipe.Comments = AdminRecipe.Comments;
        Recipe.Ratings = AdminRecipe.Ratings;
        Recipe.CreatedAt = AdminRecipe.CreatedAt;
        dbContext.Remove(AdminRecipe);
        dbContext.Add(Recipe);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserSubmissions", "Home");
    }
    [HttpGet("/DeleteUser/{UserId}")]
    public IActionResult DeleteUser(int UserId)
    {
      int? AdminId = HttpContext.Session.GetInt32("UserId");
      User Admin = dbContext.Users.FirstOrDefault(user => user.UserId == AdminId);
      if (Admin != null)
      {
        User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
        if (User.AdminState != 1)
        {
          dbContext.Remove(User);
          dbContext.SaveChanges();
          return RedirectToAction("AdminPage");
        }
      }
      return RedirectToAction("Index", "Home");
    }
  }
}