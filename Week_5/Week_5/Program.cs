using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5.Classes;

namespace Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral quadrilateral = new Quadrilateral(2, 3, 4, 5);
            Console.WriteLine($"Perimeter of the quadrialateral: {quadrilateral.Perimeter()}");

            Circle circle = new Circle(3);
            Console.WriteLine($"Perimeter of the circle: {circle.Perimeter()}");
        }
    }
}
