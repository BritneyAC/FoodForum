using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FoodForum.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodForum.Models{    
    public class Recipe{
        private FoodForumContext dbContext;
        public Recipe(FoodForumContext context)
        {
        dbContext = context;
        }
        [Key]
        [Required]
        public int RecipeId{get;set;}
        [Required]
        public string Title{get;set;}
        [Required]
        public string Content{get;set;}
        public string PictureUrl{get;set;}
        [Required]
        public string IngredientOne{get;set;}
        [Required]
        public string IngredientTwo{get;set;}
        [Required]
        public string IngredientThree{get;set;}
        public string IngredientFour{get;set;}
        public string IngredientFive{get;set;}
        public string IngredientSix{get;set;}
        public string IngredientSeven{get;set;}
        public string IngredientEight{get;set;}
        public string IngredientNine{get;set;}
        public string IngredientTen{get;set;}
        public string IngredientEleven{get;set;}
        public string IngredientTwelve{get;set;}
        public string IngredientThirteen{get;set;}
        public string IngredientFourteen{get;set;}
        public string IngredientFifteen{get;set;}
        [NotMapped]
        public List<string> Ingredients{get;set;}
        [Required]
        public int UserId{get;set;}
        public User User{get;set;}
        public List<Like> Likes{get;set;}
        public List<Comment> Comments{get;set;}
        public List<Rating> Ratings{get;set;}
        public double GetRating(){
            if(Ratings.Count < 1){
                return 0;
            }
            double avg = 1;
            foreach(var rating in Ratings){
                avg += rating.Rate;
            } 
            return avg / Ratings.Count;
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
        public List<String> GetIngredients(){
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
    }
}