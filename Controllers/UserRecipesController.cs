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
        return View();
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpGet("/NewUserRecipe")]
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
    [HttpPost("/PostUserRecipe")]
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
          if (ModelState.IsValid)
          {
            if(!dbContext.Recipes.Any(recipe => recipe.PictureURL == Recipe.PictureURL))
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
    [HttpGet("/UserRecipe/{Title}/Update")]
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
          return View();
        }
      }
      return RedirectToAction("UserRecipes");
    }
    [HttpPost("/UserRecipe/{RecipeId}/Updating")]
    public async Task<IActionResult> UpdatingUserRecipeAsync(int RecipeId, UpdateUserRecipe UpdateUserRecipe, string Content)
    {
      int? UserId = HttpContext.Session.GetInt32("UserId");
      User User = dbContext.Users.FirstOrDefault(user => user.UserId == UserId);
      if (User != null)
      {
        UserRecipe Recipe = dbContext.UserRecipes.Include(recipe => recipe.User).FirstOrDefault(recipe => recipe.RecipeId == RecipeId);
        if (User.AdminState == 1 || User.UserId == Recipe.User.UserId)
        {
          if (UpdateUserRecipe.UploadPicture != null)
          {
            var container = Recipe.GetBlobContainer(configuration.GetSection("PictureBlobInfo:AzureStorageConnectionString").Value, "foodforumpictures");
            var PictureContent = ContentDispositionHeaderValue.Parse(UpdateUserRecipe.UploadPicture.ContentDisposition);
            var FileName = PictureContent.FileName.ToString().Trim('"');
            var blockBlob = container.GetBlockBlobReference(FileName);
            BlobRequestOptions options = new BlobRequestOptions();
            options.SingleBlobUploadThresholdInBytes = 16777216;
            await blockBlob.UploadFromStreamAsync(UpdateUserRecipe.UploadPicture.OpenReadStream());
            UpdateUserRecipe.PictureURL = blockBlob.Uri.AbsoluteUri;
            if (UpdateUserRecipe.PictureURL != null && !dbContext.Recipes.Any(recipe => recipe.PictureURL == UpdateUserRecipe.PictureURL))
            {
              Recipe.PictureURL = UpdateUserRecipe.PictureURL;
            }
          }
          Recipe.Title = UpdateUserRecipe.Title;
          Recipe TitleCheck = dbContext.Recipes.FirstOrDefault(recipe => recipe.Title == Recipe.Title);
          if (TitleCheck != null && TitleCheck.RecipeId != Recipe.RecipeId)
          {
            ViewBag.Recipe = Recipe;
            ModelState.AddModelError("Title", "A recipe already has that title");
            return View("UpdateUserRecipe");
          }
          Recipe.Content = Content;
          Recipe.IngredientOne = UpdateUserRecipe.IngredientOne;
          Recipe.IngredientTwo = UpdateUserRecipe.IngredientTwo;
          Recipe.IngredientThree = UpdateUserRecipe.IngredientThree;
          Recipe.IngredientFour = UpdateUserRecipe.IngredientFour;
          Recipe.IngredientFive = UpdateUserRecipe.IngredientFive;
          Recipe.IngredientSix = UpdateUserRecipe.IngredientSix;
          Recipe.IngredientSeven = UpdateUserRecipe.IngredientSeven;
          Recipe.IngredientEight = UpdateUserRecipe.IngredientEight;
          Recipe.IngredientNine = UpdateUserRecipe.IngredientNine;
          Recipe.IngredientTen = UpdateUserRecipe.IngredientTen;
          Recipe.IngredientEleven = UpdateUserRecipe.IngredientEleven;
          Recipe.IngredientTwelve = UpdateUserRecipe.IngredientTwelve;
          Recipe.IngredientThirteen = UpdateUserRecipe.IngredientThirteen;
          Recipe.IngredientFourteen = UpdateUserRecipe.IngredientFourteen;
          Recipe.IngredientFifteen = UpdateUserRecipe.IngredientFifteen;
          Recipe.UpdatedAt = UpdateUserRecipe.CreatedAt;
          Recipe.User.ConfirmPassword = null;
          TryValidateModel(Recipe);
          ModelState.Remove("User.ConfirmPassword");
          if (UpdateUserRecipe.PictureURL != null && dbContext.Recipes.Any(recipe => recipe.PictureURL == Recipe.PictureURL))
          {
            ModelState.AddModelError("UploadPicture", "A recipe already has a picture with that file name, please rename it and try again");
          }
          if (ModelState.IsValid)
          {
            dbContext.SaveChanges();
            return RedirectToAction("UserRecipe", new {Title = Recipe.Title});
          }
          ViewBag.Recipe = Recipe;
          return View("UpdateUserRecipe");
        }
        return RedirectToAction("UserRecipe", "UserRecipes", new { Title = Recipe.Title});
      }
      return RedirectToAction("UserRecipes", "Home");
    }
    [HttpPost("/UserRecipe/{RecipeId}/Delete")]
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
        dbContext.Add(Comment);
        dbContext.SaveChanges();
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