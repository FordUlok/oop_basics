namespace Food;

public class StackFullException : StackException
{
    public FoodIngredient FailedIngredient { get; }
    
    public StackFullException(IngredientStack sender, FoodIngredient ingredient) : base($"A verem tele van! Nem sikerült betenni: {ingredient.name}", sender)
    {
        FailedIngredient = ingredient;
    }
}