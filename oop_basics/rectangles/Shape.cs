namespace inheritance;

public abstract class Shape
{
    private bool isHoley;
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public Shape(string color, bool isHoley)
    {
         this.color = color;
         this.isHoley = isHoley;
    }
    public virtual bool Displayable
    {
        get
        {
            return false;
        }
    }
    public void MakeHoley()
    {
        this.isHoley = true;
    }

    public abstract double Perimeter();
    public abstract double Area();

    public virtual void Copy(Shape other)
    {
        if (other != null)
        {
            this.color = other.color;
            this.isHoley = other.isHoley;
        }
    }

    public override string ToString()
    {
        return "Szín: " + color +
               ", Lyukas: " + isHoley +
               ", Megjeleníthető: " + Displayable +
               ", Kerület: " + Perimeter() +
               ", Terület: " + Area();
    }

    public override bool Equals(object? obj)
    {
        if (obj is Shape other)
        {
            return this.color == other.color &&
                   this.isHoley == other.isHoley;
        }
        return false;
    }
}