using Food;
namespace Food_Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ToString_Valid_ReturnsFormattedString()
    {
        var ingredient = new FoodIngredient("Tej", 1.5, Unit.Liter);
        string expected = "Tej: 1.5 Liter";

        string actual = ingredient.ToString();
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}