using Microsoft.AspNetCore.Mvc;
using RecipesApi.Models;

namespace RecipesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    public static List<Recipe> recipes = new List<Recipe>();

    [HttpPost]
    public void AddRecipe([FromBody] Recipe recipe)
    {
        recipes.Add(recipe);
    }

    [HttpGet]
    public List<Recipe> ListRecipes()
    {
        return recipes;
    }
}