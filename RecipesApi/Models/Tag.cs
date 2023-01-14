using System.ComponentModel.DataAnnotations;

namespace RecipesApi.Models;

public class Tag
{

    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public ICollection<Recipe> Recipes { get; set; }

}

