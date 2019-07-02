using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodForum.Models;

namespace FoodForum.Models{
    public class AdminRecipe : Recipe{
        [Required]
        public string Note{get;set;}
    }
}