using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;

namespace RecipesApi.Data;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> opts)
        : base(opts)
    {
        
    }

    public DbSet<Recipe> Recipes { get; set; }
}

