using System.ComponentModel.DataAnnotations;

namespace FoodForum.Models
{
  public class AdminRecipe : Recipe{
        [Required]
        public string Note{get;set;}
    }
}