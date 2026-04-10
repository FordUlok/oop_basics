namespace Food;

public class StackEmptyException : StackException
{
    public StackEmptyException(IngredientStack sender) : base("A verem üres, nem lehet kivenni elemet!", sender)
    {
    }
}