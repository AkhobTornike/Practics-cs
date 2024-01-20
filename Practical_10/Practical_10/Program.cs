using Practical_10.Classes;
using Practical_10.Classes._9._5._1;

class Program
{
    static void Main ()
    {
        // 9.4.1
        TriangleCalculator triangle1 = new TriangleCalculator ();

        double area = triangle1.CalculateArea1(5, 8);
        Console.WriteLine ($"Area of the triangle: {area}");

        double Perimeter = triangle1.CalculatePerimeter1(3, 4, 5);
        Console.WriteLine($"Perimeter of the triangle: {Perimeter}");

        // 9.5.1
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;

        Triangle triangle2 = new Triangle ( side1, side2, side3 );

        Console.WriteLine("Perimeter: " + triangle2.CalculatePerimeter2());
        Console.WriteLine("Area: " + triangle2.CalculateArea2());
    }
}