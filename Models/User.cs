using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodForum.Models
{
  public class User{
    [Key]
    [Required]
    public int UserId{get;set;}
    [Required]
    public string Username{get;set;}
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password{get;set;}
    [Required]
    public int AdminState{get;set;}
    [NotMapped]
    [Compare("Password", ErrorMessage="Passwords must match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword{get;set;}
    public List<Like> Likes{get;set;}
    public List<Comment> Comments{get;set;}
    public List<Rating> Ratings{get;set;}
  }
}