using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodForum.Models
{
  public class Comment
  {
    [Key]
    public int CommentId{get;set;}
    [Required]
    public string Content{get;set;}
    [Required]
    [ForeignKey("Recipe")]
    public int RecipeId{get;set;}
    [Required]
    [ForeignKey("User")]
    public int UserId{get;set;}
    [Required]
    public Recipe Recipe{get;set;}
    [Required]
    public User User{get;set;}
    [Required]
    public DateTime CreatedAt{get;set;} = DateTime.Now;
    [Required]
    public DateTime UpdatedAt{get;set;} = DateTime.Now;
  }
}