using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Rectangle : Shape
    {
        private double width, length;

        public Rectangle()
        { }

        public Rectangle(double w, double l)
        {
            width = w;
            length = l;
        }

        public virtual double Weight
        {
            set => width = value;
        }

        public virtual double Length
        {
            set => length = value;
        }
        public override double area()
        {
            return width * length;
        }

        public override double perimeter()
        {
            return 2 * (width + length);
        }
    }
}
