using System.ComponentModel.DataAnnotations;

namespace RecipesApi.Models;

public class Recipe
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public List<string> Steps { get; set; }
    public List<string> Ingredients { get; set; }
}
