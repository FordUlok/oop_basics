namespace Food;

public interface IIngredientStack
{
    void Push(FoodIngredient newItem);
    FoodIngredient Pop();
    bool Empty();
    FoodIngredient Top();
}