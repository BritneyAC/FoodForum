using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodForum.Models;

namespace FoodForum.Models{
  public class LoginUser{
    public string Username{get;set;}
    [DataType(DataType.Password)]
    public string Password{get;set;}
  }
}