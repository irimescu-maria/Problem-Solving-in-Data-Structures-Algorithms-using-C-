using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Circle : Shape
    {
        private double radius;


        public Circle(): this(1)
        {
                
        }

        public Circle(double r)
        {
            radius = r;
        }

        public virtual double Radius
        {
            set => radius = value;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
