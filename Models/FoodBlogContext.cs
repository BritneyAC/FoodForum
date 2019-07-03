using Microsoft.EntityFrameworkCore;

namespace FoodForum.Models{
  public class FoodForumContext : DbContext{
    public FoodForumContext(DbContextOptions options) : base(options){}
    public DbSet<User> Users{get;set;}
    public DbSet<UserRecipe> UserRecipes{get;set;}
    public DbSet<AdminRecipe> AdminRecipes{get;set;}
    public DbSet<Like> Likes{get;set;}
    public DbSet<Comment> Comments{get;set;}
    public DbSet<Rating> Ratings{get;set;}
  }
}