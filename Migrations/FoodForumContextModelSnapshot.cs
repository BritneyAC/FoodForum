﻿// <auto-generated />
using System;
using FoodForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodForum.Migrations
{
    [DbContext(typeof(FoodForumContext))]
    partial class FoodForumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodForum.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("RecipeId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FoodForum.Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecipeId");

                    b.Property<int>("UserId");

                    b.HasKey("LikeId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("FoodForum.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Rate");

                    b.Property<int>("RecipeId");

                    b.Property<int>("UserId");

                    b.HasKey("RatingId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("FoodForum.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("IngredientEight");

                    b.Property<string>("IngredientEleven");

                    b.Property<string>("IngredientFifteen");

                    b.Property<string>("IngredientFive");

                    b.Property<string>("IngredientFour");

                    b.Property<string>("IngredientFourteen");

                    b.Property<string>("IngredientNine");

                    b.Property<string>("IngredientOne")
                        .IsRequired();

                    b.Property<string>("IngredientSeven");

                    b.Property<string>("IngredientSix");

                    b.Property<string>("IngredientTen");

                    b.Property<string>("IngredientThirteen");

                    b.Property<string>("IngredientThree")
                        .IsRequired();

                    b.Property<string>("IngredientTwelve");

                    b.Property<string>("IngredientTwo")
                        .IsRequired();

                    b.Property<string>("PictureURL");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Recipe");
                });

            modelBuilder.Entity("FoodForum.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminState");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodForum.Models.AdminRecipe", b =>
                {
                    b.HasBaseType("FoodForum.Models.Recipe");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.ToTable("AdminRecipe");

                    b.HasDiscriminator().HasValue("AdminRecipe");
                });

            modelBuilder.Entity("FoodForum.Models.UserRecipe", b =>
                {
                    b.HasBaseType("FoodForum.Models.Recipe");


                    b.ToTable("UserRecipe");

                    b.HasDiscriminator().HasValue("UserRecipe");
                });

            modelBuilder.Entity("FoodForum.Models.Comment", b =>
                {
                    b.HasOne("FoodForum.Models.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodForum.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodForum.Models.Like", b =>
                {
                    b.HasOne("FoodForum.Models.Recipe", "Recipe")
                        .WithMany("Likes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodForum.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodForum.Models.Rating", b =>
                {
                    b.HasOne("FoodForum.Models.Recipe", "Recipe")
                        .WithMany("Ratings")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodForum.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodForum.Models.Recipe", b =>
                {
                    b.HasOne("FoodForum.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
