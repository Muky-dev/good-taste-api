using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesApi.Models;

public class Favorite
{
    [Key]
    [Required]
    public int UserId { get; set; }

    public User User { get; set; }

    [Key]
    [Required]
    public int RecipeId { get; set; }

    public Recipe Recipe { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }
}

