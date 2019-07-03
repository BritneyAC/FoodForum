using System.ComponentModel.DataAnnotations;

namespace FoodForum.Models
{
  public class Rating{
    [Key]
    public int RatingId{get;set;}
    [Required]
    [Range(1,5)]
    public int Rate{get;set;}
    [Required]
    public int RecipeId{get;set;}
    [Required]
    public int UserId{get;set;}
    [Required]
    public Recipe Recipe{get;set;}
    [Required]
    public User User{get;set;}
  }
}