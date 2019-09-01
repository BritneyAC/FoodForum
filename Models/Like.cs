using System.ComponentModel.DataAnnotations;

namespace FoodForum.Models
{
  public class Like
  {
    [Key]
    public int LikeId{get;set;}
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