namespace Core.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public IngredientUnit Unit { get; set; }
    public IngredientPrice Price { get; set; }

    public string ShortUnit => Unit switch
    {
        IngredientUnit.Grams => "g",
        IngredientUnit.Milliliters => "ml",
        IngredientUnit.Pieces => "",
        IngredientUnit.Teaspoons => "tsp",
        IngredientUnit.Tablespoons => "tbsp",
        IngredientUnit.Pinches => "pinches",
        IngredientUnit.Handfuls => "handfuls",
        IngredientUnit.Cloves => "cloves",
        IngredientUnit.Slices => "slices",
        IngredientUnit.Leaves => "leaves",
        _ => ""
    };
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