using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulb b = new Bulb();
            b.size = Bulb.BulbSize.MEDIUM;
            Console.WriteLine("Bulb size: " + b.size);
        }
    }
}
