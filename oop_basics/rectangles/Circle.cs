namespace inheritance;

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(string color, bool isHoley, double radius) : base(color, isHoley)
    {
        this.radius = radius;
    }

    public override bool Displayable => radius > 0;

    public override double Perimeter() => 2 * radius * Math.PI;
    public override double Area() => Math.PI * Math.Pow(radius, 2);

    public override void Copy(Shape other)
    {
        base.Copy(other);
        if (other is Circle otherCircle)
        {
            this.radius = otherCircle.radius;
        }
    }

    public override string ToString()
    {
        return "Kör: " + base.ToString();
    }
    
    public override bool Equals(object obj)
    {
        if (base.Equals(obj) && obj is Circle other)
        {
            return this.radius == other.radius;
        }
        return false;
    }
}
        
    
    