using System.Data.SqlTypes;
using System.Runtime.Serialization.Formatters;

namespace inheritance;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[5];
        shapes[0] = new Rectangle("Piros", false, 5, 10);
        shapes[1] = new Square("Kék", false, 8);
        shapes[2] = new Circle("Zöld", false, 4);
        shapes[3] = new Rectangle("Sárga", false, 2, 3);
        shapes[4] = new Circle("Lila", false, 10);
        
        Square sq1 = new Square("Piros", false, 10);
        Square sq2 = new Square("Kék", true, 5);

        sq1.Copy(sq2);
        
    }
    static void GetHoley(Shape s)
    {
        if (s.Area() > s.Perimeter())
        {
            s.MakeHoley();
        }
    }

    static Shape CreateShape(string color, bool isHoley, double h, double w)
    {
        if (h == w)
        {
            return new Square(color, isHoley, h);
        }
        return new Rectangle(color, isHoley, h, w);
    }

    static Shape GetLargestAreaShape(Shape[] shapes)
    {
        if (shapes == null || shapes.Length == 0) return null;
        {
            Shape max = shapes[0];
            for (int i = 1; i < shapes.Length; i++)
            {
                if (shapes[i].Area() > max.Area())
                {
                    max = shapes[i];
                }
            }
            return max;
        }
    }
}