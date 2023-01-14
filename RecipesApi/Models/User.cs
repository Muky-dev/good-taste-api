namespace RecipesApi.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public List<Recipe> recipes { get; set; }
}

