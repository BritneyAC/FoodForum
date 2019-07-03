using System.ComponentModel.DataAnnotations;

namespace FoodForum.Models
{
  public class LoginUser{
    public string Username{get;set;}
    [DataType(DataType.Password)]
    public string Password{get;set;}
  }
}