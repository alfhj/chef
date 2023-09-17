namespace Core.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public IngredientUnit Unit { get; set; }
    public IngredientPrice Price { get; set; }
}

public enum IngredientUnit
{
    Grams,
    Milliliters,
    Pieces,
    Teaspoons,
    Tablespoons,
    Pinches,
    Handfuls,
    Cloves,
    Slices,
    Leaves
}

public enum IngredientPrice
{
    Low,
    Medium,
    High
}
