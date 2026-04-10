namespace Food;

public class StackException : Exception
{
    public IngredientStack Sender { get; }

    public StackException(string message, IngredientStack sender) : base(message)
    {
        Sender = sender;
    }
}
