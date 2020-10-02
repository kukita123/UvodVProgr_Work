using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            //Console.Write("Enter x=");
            //x = int.Parse(Console.ReadLine());

            //Console.Write("Enter y=");
            //y = int.Parse(Console.ReadLine());

            //z = (x + y) * x - 4 * x + y;
            //Console.WriteLine("z=" + z);

            double a, b, h, s;

            Console.Write("Enter a=");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter b=");
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter h=");
            h = double.Parse(Console.ReadLine());

            s = ((a + b) * h) / 2;

            Console.WriteLine($"s={s}");

            Console.ReadKey();
        }
    }
}
