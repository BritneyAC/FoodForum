using Microsoft.EntityFrameworkCore;

namespace FoodForum.Models
{
  public class FoodForumContext : DbContext
  {
    public FoodForumContext(DbContextOptions options) : base(options){}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>()
            .HasOne(u => u.User).WithMany(u => u.Comments).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Comment>()
            .HasKey(t => new { t.CommentId});
        modelBuilder.Entity<Comment>()
            .HasOne(pt => pt.User)
            .WithMany(p => p.Comments)
            .HasForeignKey(pt => pt.UserId);
        modelBuilder.Entity<Like>()
            .HasOne(u => u.User).WithMany(u => u.Likes).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Like>()
            .HasKey(t => new { t.LikeId });
        modelBuilder.Entity<Like>()
            .HasOne(pt => pt.User)
            .WithMany(p => p.Likes)
            .HasForeignKey(pt => pt.UserId);
        modelBuilder.Entity<Rating>()
            .HasOne(u => u.User).WithMany(u => u.Ratings).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Rating>()
            .HasKey(t => new { t.RatingId });
        modelBuilder.Entity<Rating>()
            .HasOne(pt => pt.User)
            .WithMany(p => p.Ratings)
            .HasForeignKey(pt => pt.UserId);
    }
    public DbSet<User> Users{get;set;}
    public DbSet<UserRecipe> UserRecipes{get;set;}
    public DbSet<AdminRecipe> AdminRecipes{get;set;}
    public DbSet<Recipe> Recipes{get;set;}
    public DbSet<Like> Likes{get;set;}
    public DbSet<Comment> Comments{get;set;}
    public DbSet<Rating> Ratings{get;set;}
  }
}