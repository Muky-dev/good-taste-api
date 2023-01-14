using System.ComponentModel.DataAnnotations;

namespace RecipesApi.Models;

public class Recipe
{
    public int RecipeId { get; set; }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public User Author { get; set; }

    public List<Favorite> Favorites { get; set; }

    public ICollection<Tag> Tags { get; set; }
}
