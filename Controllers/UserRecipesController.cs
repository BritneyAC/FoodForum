using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodForum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Text.RegularExpressions;

namespace FoodForum.Controllers
{
  public class UserRecipesController : Controller
  {
    private IConfiguration configuration;
    private FoodForumContext dbContext;
    public UserRecipesController(FoodForumContext context, IConfiguration iConfig)
    {
      dbContext = context;
      configuration = iConfig;
    }
    string RegEx = @"^[a-zA-Z0-9.,:;!\""_\-&+' ]+$";
    public string RegexCheck(UserRecipe Recipe, string pattern){
      if (!Regex.IsMatch(Recipe.Title, pattern)){
        return "Title";
      }if (!Regex.IsMatch(Recipe.IngredientOne, pattern)){
        return "IngredientOne";
      }if (!Regex.IsMatch(Recipe.IngredientTwo, pattern)){
        return "IngredientTwo";
      }if (!Regex.IsMatch(Recipe.IngredientThree, pattern)){
        return "IngredientThree";
      }if (Recipe.IngredientFour != null && !Regex.IsMatch(Recipe.IngredientFour, pattern)){
        return "IngredientFour";
      }if (Recipe.IngredientFive != null && !Regex.IsMatch(Recipe.IngredientFive, pattern)){
        return "IngredientFive";
      }if (Recipe.IngredientSix != null && !Regex.IsMatch(Recipe.IngredientSix, pattern)){
        return "IngredientSix";
      }if (Recipe.IngredientSeven != null && !Regex.IsMatch(Recipe.IngredientSeven, pattern)){
        return "IngredientSeven";
      }if (Recipe.IngredientEight != null && !Regex.IsMatch(Recipe.IngredientEight, pattern)){
        return "IngredientEight";
      }if (Recipe.IngredientNine != null && !Regex.IsMatch(Recipe.IngredientNine, pattern)){
        return "IngredientNine";
      }if (Recipe.IngredientTen != null && !Regex.IsMatch(Recipe.IngredientTen, pattern)){
        return "IngredientTen";
      }if (Recipe.IngredientEleven != null && !Regex.IsMatch(Recipe.IngredientEleven, pattern)){
        return "IngredientEleven";
      }if (Recipe.IngredientTwelve != null && !Regex.IsMatch(Recipe.IngredientTwelve, pattern)){
        return "IngredientTwelve";
      }if (Recipe.IngredientThirteen != null && !Regex.IsMatch(Recipe.IngredientThirteen, pattern)){
        return "IngredientThirteen";
      }if (Recipe.IngredientFourteen != null && !Regex.IsMatch(Recipe.IngredientFourteen, pattern)){
        return "IngredientFourteen";
      }if (Recipe.IngredientFifteen != null && !Regex.IsMatch(Recipe.IngredientFifteen, pattern)){
        return "IngredientFifteen";
      }if (!Regex.IsMatch(Recipe.Content, pattern)){
        return "Content";
      }if (Recipe.PictureURL != null && !Regex.IsMatch(Recipe.PictureURL, pattern)){
        return "PictureUrl";
      }
      return null;
    }
    public string RegexCheck(Comment Comment, string pattern){
      if (!Regex.IsMatch(Comment.Content, pattern)){
        return "Content";
      }
      return null;
    }
    [HttpGet("/UserRecipe/{Title}")]
    public IActionResult UserRecipe(string Title)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.User).Include(recipe => recipe.Ratings).Include(recipe => recipe.Likes).Include(recipe => recipe.Comments).FirstOrDefault(recipe => recipe.Title == Title);
      bool Liked = false;
      if(Recipe != null)
      {
        if(User != null)
        {
          Rating Rating = User.Ratings.FirstOrDefault(rating => rating.RecipeId == Recipe.RecipeId);
          ViewBag.Rating = Rating;
          if (Recipe.Likes.FirstOrDefault(like => like.UserId == UserId) != null)
          {
            Liked = true;
            ViewBag.Like = Recipe.Likes.FirstOrDefault(like => like.UserId == UserId);
          }
        }
        List<Comment> Comments = dbContext.Comments.Include(comment => comment.Recipe).Include(comment => comment.User).Where(comment => comment.RecipeId == Recipe.RecipeId).ToList();
        Comments.Reverse();
        ViewBag.Comments = Comments;
        ViewBag.User = User;
        ViewBag.Liked = Liked;
        ViewBag.Recipe = Recipe;
        ViewBag.Title = Recipe.Title;
        return View();
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpGet("/UserRecipe/new")]
    public IActionResult NewUserRecipe()
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState == 1)
        {
          return RedirectToAction("NewAdminRecipe", "Admin");
        }
        ViewBag.User = User;
        ViewBag.Title = "Make A New Recipe";
        return View();
      }
      return RedirectToAction("Index", "Home");
    }
    [HttpGet("/UserRecipeTitle")]
    public async Task<IActionResult> UserRecipeTitleAsync(string Title)
    {
      bool found = false;
      Recipe Recipe = await dbContext.Recipes.FirstOrDefaultAsync(recipe => recipe.Title == Title);
      if (Recipe != null)
      {
        found = true;
      }
      ViewBag.Found = found;
      ViewBag.Partial = true;
      return View("UserRecipeTitlePartial");
    }
    [HttpPost("/UserRecipe")]
    public async Task<IActionResult> PostUserRecipeAsync(UserRecipe Recipe)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        if (User.AdminState != 1)
        {
          Recipe.UserId = User.UserId;
          if (dbContext.Recipes.Any(recipe => recipe.Title == Recipe.Title))
          {
            ModelState.AddModelError("Title", "A recipe already has that title");
            return View("NewUserRecipe");
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
          string check = RegexCheck(Recipe,RegEx);
          if (check != null){
            ModelState.AddModelError(check, "Please use only letters, numbers, periods, commas, hyphens, or exclamation points");
          }
          if (ModelState.IsValid)
          {
            if(!dbContext.Recipes.Any(recipe => recipe.PictureURL == Recipe.PictureURL) || Recipe.PictureURL == null)
            {
              dbContext.Add(Recipe);
              dbContext.SaveChanges();
              return RedirectToAction("UserRecipes", "Home");
            }
            ModelState.AddModelError("UploadPicture", "A recipe already has a picture with that file name, please rename it and try again");
          }
          return View("NewUserRecipe");
        }
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpGet("/UserRecipe/{Title}/edit")]
    public IActionResult UpdateUserRecipe(string Title)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.User).FirstOrDefault(recipe => recipe.Title == Title);
        if (Recipe != null && Recipe.UserId == UserId || User.AdminState == 1)
        {
          ViewBag.Recipe = Recipe;
          ViewBag.Title = "Update User Recipe";
          return View();
        }
      }
      return RedirectToAction("UserRecipes");
    }
    [HttpPost("/UserRecipe/{RecipeId}")]
    public async Task<IActionResult> UpdatingUserRecipeAsync(int RecipeId, UpdateUserRecipe UpdateRecipe, string Content)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.User).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        if (User.AdminState == 1 || User.UserId == Recipe.UserId)
        {
          if (Request.Form["deletePicture"] == "on"){
            UpdateRecipe.UploadPicture = null;
            Recipe.PictureURL = null;
          }
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
          string check = RegexCheck(Recipe,RegEx);
          if (check != null){
            ModelState.AddModelError(check, "Please use only letters, numbers, periods, commas, hyphens, or exclamation points");
          }
          if (ModelState.IsValid)
          {
            dbContext.SaveChanges();
            return RedirectToAction("UserRecipes", "Home");
          }
          ViewBag.Recipe = Recipe;
          return View("UpdateRecipe");
        }
        return RedirectToAction("UserRecipe", "UserRecipes", new { Title = Recipe.Title});
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpPost("/UserRecipe/{RecipeId}/delete")]
    public IActionResult DeleteUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        if (Recipe.UserId == UserId || User.AdminState == 1)
        {
          dbContext.Remove(Recipe);
          dbContext.SaveChanges();
          return RedirectToAction("UserRecipes", "Home");
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Like/{RecipeId}")]
    public IActionResult LikeUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.Likes).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
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
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Unlike/{RecipeId}")]
    public IActionResult UnLikeUserRecipe(int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Likes).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (User != null)
      {
        Like Like = User.Likes.FirstOrDefault(like => like.RecipeId == RecipeId);
        dbContext.Remove(Like);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/{RecipeId}/Comment")]
    public IActionResult CommentOnUserRecipe(int RecipeId, Comment Comment)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      if (UserId != null)
      {
        Comment.UserId = UserId.Value;
        Comment.User = User;
        Comment.Recipe = Recipe;
        string check = RegexCheck(Comment,RegEx);
        if (check != null){
          ModelState.AddModelError(check, "Please use only letters, numbers, periods, commas, hyphens, or exclamation points");
        }
        if (ModelState.IsValid){
          dbContext.Add(Comment);
          dbContext.SaveChanges();
        }
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/{RecipeId}/DeleteComment/{CommentId}")]
    public IActionResult DeleteCommentOnUserRecipe(int RecipeId, int CommentId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
      Comment Comment = dbContext.Comments.FirstOrDefault(comment => comment.CommentId == CommentId);
      if (UserId != Comment.UserId || User.AdminState != 1)
      {
        dbContext.Remove(Comment);
        dbContext.SaveChanges();
      }
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/Rate/{RecipeId}")]
    public IActionResult RateUserRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == Rating.RecipeId);
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
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
    [HttpPost("/UserRecipe/UpdateRating/{RecipeId}")]
    public IActionResult UpdateRateUserRecipe(Rating Rating, int RecipeId)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.Include(user => user.Ratings).FirstOrDefault(user => user.UserId == UserId);
      UserRecipe Recipe = dbContext.UserRecipes.FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
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
      return RedirectToAction("UserRecipe", new { Title = Recipe.Title });
    }
  }
}