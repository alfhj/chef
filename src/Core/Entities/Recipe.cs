namespace Core.Entities;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? URL { get; set;}
    public Guid ImageId { get; set; }
    public List<RecipeIngredient> Ingredients { get; set; } = new();
    public List<RecipeStep> Steps { get; set; } = new();
    //public RecipeType Type { get; set; }
    //public int Servings { get; set; }
    //public int PreparationTime { get; set; }
    //public int CookingTime { get; set; }
    //public int TotalTime { get; set; }
}

public class RecipeIngredient
{
    public int Id { get; set; }
    public Ingredient? Ingredient { get; set; }
    public decimal Amount { get; set; }

    public override string ToString()
        => $"{Amount} {Ingredient.ShortUnit} {Ingredient.Name}";
}

public class RecipeStep
{
    public int Id { get; set; }
    public string? Description { get; set; }
}
