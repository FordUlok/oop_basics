namespace Food;

public class IngredientStackHandler
{
    private IIngredientStack _stack;

    public IngredientStackHandler(IIngredientStack stack)
    {
        _stack = stack;
    }

    public FoodIngredient[] AddItems(FoodIngredient[] foodIngredients)
    {
        List<FoodIngredient> leftovers = new List<FoodIngredient>();

        foreach (var item in foodIngredients)
        {
            try
            {
                _stack.Push(item);
            }
            catch (StackFullException)
            {
                leftovers.Add(item);
            }
        }
        return leftovers.ToArray();
    }



}