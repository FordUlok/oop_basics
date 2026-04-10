namespace Food;

public class IngredientStack
{
    private FoodIngredient[] items;
    private int count;

    public IngredientStack(int size)
    {
        items = new FoodIngredient[size];
        count = 0;
    }

    public bool Empty()
    {
        return count == 0;
    }

    public bool Full()
    {
        return count == items.Length;
    }

    public void Push(FoodIngredient newItem)
    {
        if (Full())
        {
            throw new StackFullException(this, newItem);
        }
        items[count] = newItem;
        count++;
    }

    public FoodIngredient Pop()
    {
        if (Empty())
        {
            throw new StackEmptyException(this);
        }
        count--;
        FoodIngredient item = items[count];
        return item;
    }

    public FoodIngredient Top()
    {
        if (Empty())
        {
            return null;
        }
        return items[count - 1];
    }
    
    
    
    
    
    
    
}