using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 2, length = 3;
            Shape rectangle = new Rectangle(width, length);
            Console.WriteLine("Rectangle width: " + width + " and length: " + length +
                "\nArea " + rectangle.area() + "\nPerimeter " + rectangle.perimeter());

            double radius = 10;
            Shape circle = new Circle(radius);
            Console.WriteLine("Circle radius: " + radius + "\nArea " + circle.area() + "\nPerimeter " + circle.perimeter());
        }
    }
}
