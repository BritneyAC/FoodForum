using System.ComponentModel.DataAnnotations;

namespace FoodForum.Models
{
  public class AdminRecipe : Recipe
  {
    [Required]
    [MinLength(8)]
    [MaxLength(255)]
    public string Note{get;set;}
  }
}