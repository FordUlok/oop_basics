namespace inheritance;

public class Square : Rectangle
{
    public Square(string color, bool isHoley, double side) : base(color, isHoley, side, side)
    {
    }
    public override string ToString()
    {
        return "Négyzet: " + base.ToString();
    }
}