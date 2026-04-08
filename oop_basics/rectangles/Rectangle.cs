namespace inheritance;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(string color, bool isHoley, double height, double width)
        : base(color, isHoley)
    {
        this.height = height;
        this.width = width;
    }

    public override bool Displayable => height > 0 && width > 0;
    public override string ToString()
    {
        return "Téglalap: " + base.ToString();
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }

    public override double Area()
    {
        return height * width;
    }

    public override void Copy(Shape other)
    {
        base.Copy(other);

        if (other is Rectangle)
        {
            Rectangle r = (Rectangle)other;

            this.height = r.height;
            this.width = r.width;
        }
    }

    public override bool Equals(object? obj)
    {
        if (base.Equals(obj) && obj is Rectangle other)
        {
            return this.height == other.height &&
                   this.width == other.width;
        }
        return false;
    }
}