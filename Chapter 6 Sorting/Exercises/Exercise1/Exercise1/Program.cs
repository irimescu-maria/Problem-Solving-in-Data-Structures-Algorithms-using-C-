using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[] { "Ana", "are", "are", "mere" };
            TextSort ts = new TextSort(text);
            ts.frequency();
            for(int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + "");
            }
        }
    }
}
