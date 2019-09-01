using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace FoodForum.Models
{
  public class UpdateUserRecipe
  {
    [Required]
    [NotMapped]
    [MinLength(3)]
    [MaxLength(55)]
    public string Title{get;set;}
    [Required]
    [NotMapped]
    [MinLength(8)]
    [MaxLength(2555)]
    public string Content{get;set;}
    [DataType(DataType.Upload)]
    [NotMapped]
    public IFormFile UploadPicture{get;set;}
    [FileExtensions(Extensions = "jpg, png, jpeg, bmp")]
    [NotMapped]
    public string PictureURL{get;set;}
    [Required]
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientOne{get;set;}
    [Required]
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientTwo{get;set;}
    [Required]
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientThree{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientFour{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientFive{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientSix{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientSeven{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientEight{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientNine{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientTen{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientEleven{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientTwelve{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientThirteen{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientFourteen{get;set;}
    [NotMapped]
    [MinLength(2)]
    [MaxLength(65)]
    public string IngredientFifteen{get;set;}
    [NotMapped]
    public List<string> Ingredients{get;set;}
    [NotMapped]
    public DateTime CreatedAt{get;set;} = DateTime.Now;
  }
}