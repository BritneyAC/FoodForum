using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FoodForum.Models
{
  public class Recipe
  {
        private FoodForumContext dbContext;
        public Recipe(FoodForumContext context)
        {
        dbContext = context;
        }
        [Key]
        [Required]
        public int RecipeId{get;set;}
        [Required]
        [MinLength(3)]
        [MaxLength(55)]
        public string Title{get;set;}
        [Required]
        [MinLength(8)]
        [MaxLength(2555)]
        public string Content{get;set;}
        [DataType(DataType.Upload)]
        [NotMapped]
        public IFormFile UploadPicture{get;set;}
        [FileExtensions(Extensions = "jpg, png, jpeg, bmp")]
        public string PictureURL{get;set;}
        [Required]
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientOne{get;set;}
        [Required]
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientTwo{get;set;}
        [Required]
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientThree{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientFour{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientFive{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientSix{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientSeven{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientEight{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientNine{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientTen{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientEleven{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientTwelve{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientThirteen{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientFourteen{get;set;}
        [MinLength(2)]
        [MaxLength(65)]
        public string IngredientFifteen{get;set;}
        [NotMapped]
        public List<string> Ingredients{get;set;}
        [Required]
        public int UserId{get;set;}
        public User User{get;set;}
        public List<Like> Likes{get;set;}
        public List<Comment> Comments{get;set;}
        public List<Rating> Ratings{get;set;}
        public double GetRating()
        {
            double avg = 0;
            foreach(var rating in Ratings)
            {
                avg += rating.Rate;
            } 
            avg = avg / Ratings.Count;
            if (double.IsNaN(avg))
            {
                return 0;
            }
            return avg;
        }
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;

        public Recipe(){
            Ingredients = new List<string>();
            Likes = new List<Like>();
            Comments = new List<Comment>();
            Ratings = new List<Rating>();
        }
        public User GetAuthor(){
            User User = dbContext.Users.FirstOrDefault(user => user.UserId == this.UserId);
            return User;
        }
        public List<String> GetIngredients()
        {
            Ingredients.Add(IngredientOne);
            Ingredients.Add(IngredientTwo);
            Ingredients.Add(IngredientThree);
            if(IngredientFour != null){
                Ingredients.Add(IngredientFour);
            }
            if(IngredientFive != null){
                Ingredients.Add(IngredientFive);
            }
            if(IngredientSix != null){
                Ingredients.Add(IngredientSix);
            }
            if(IngredientSeven != null){
                Ingredients.Add(IngredientSeven);
            }
            if(IngredientEight != null){
                Ingredients.Add(IngredientEight);
            }
            if(IngredientNine != null){
                Ingredients.Add(IngredientNine);
            }
            if(IngredientTen != null){
                Ingredients.Add(IngredientTen);
            }
            if(IngredientEleven != null){
                Ingredients.Add(IngredientEleven);
            }
            if(IngredientTwelve != null){
                Ingredients.Add(IngredientTwelve);
            }
            if(IngredientThirteen != null){
                Ingredients.Add(IngredientThirteen);
            }
            if(IngredientFourteen != null){
                Ingredients.Add(IngredientFourteen);
            }
            if(IngredientFifteen != null){
                Ingredients.Add(IngredientFifteen);
            }
            return Ingredients;
        }
        public CloudBlobContainer GetBlobContainer(string azureConnectionString, string containerName)
        {
            var storageAccount = CloudStorageAccount.Parse(azureConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient.GetContainerReference(containerName);
        }

    }
}