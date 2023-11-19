using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Max(x1, x2) - Math.Min(x1, x2); // 50
            double height = Math.Max(y1, y2) - Math.Min(y1, y2); // 30
            Console.WriteLine("Area = " + width * height); // 50 x 30  - 1500
            Console.WriteLine("Perimeter =" + 2 * (width + height)); // 2 x (50 + 30) - 160


        }
    }
}
