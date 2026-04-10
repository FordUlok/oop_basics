namespace Food;

public enum Unit
{
    Liter,
    Kilogramm,
    Darab,
    Csomag
}

public class FoodIngredient
{
    public string name { get; set; }
    public double amount { get; set; }
    public Unit foodUnit { get; set; }

    public FoodIngredient(string name, double amount, Unit foodUnit)
    {
        this.name = name;
        this.amount = amount;
        this.foodUnit = foodUnit;
    }

    public override string ToString()
    {
        return $"{name}: {amount} {foodUnit}";
    }
}