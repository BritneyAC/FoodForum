using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodForum.Models
{
  public class User
  {
    [Key]
    [Required]
    public int UserId{get;set;}
    [Required]
    [MinLength(3, ErrorMessage="Password must be 3 characters or longer")]
    [MaxLength(16, ErrorMessage="Password must be 16 or less characters long")]
    public string Username{get;set;}
    [DataType(DataType.Password)]
    [Required]
    public string Password{get;set;}
    [Required]
    public int AdminState{get;set;}
    [NotMapped]
    [Compare("Password", ErrorMessage="Passwords must match")]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer")]
    [MaxLength(32, ErrorMessage="Password must be 32 or less characters long")]
    [DataType(DataType.Password)]
    public string ConfirmPassword{get;set;}
    public List<Recipe> Recipes{get;set;}
    public List<Like> Likes{get;set;}
    public List<Comment> Comments{get;set;}
    public List<Rating> Ratings{get;set;}

    public User(){
      Recipes = new List<Recipe>();
      Likes = new List<Like>();
      Comments = new List<Comment>();
      Ratings = new List<Rating>();
    }
  }
}