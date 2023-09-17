using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Core.Entities;

public class RecipeContext : DbContext
{
    //public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    public string DbPath { get; }

    public RecipeContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "database.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
