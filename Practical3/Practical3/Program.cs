using Practical3.Classes;
using System;


namespace Practical3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // work 7.1.1
            ChildTriangle triangle1 = new ChildTriangle(3, 4, 5);
            ChildTriangle triangle2 = new ChildTriangle(3, 4);
            ChildTriangle triangle3 = new ChildTriangle(3);

            int perimeter1 = triangle1.CalculatePerimeterOfTriangle();
            int perimeter2 = triangle2.CalculatePerimeterOfTriangle();
            int perimeter3 = triangle3.CalculatePerimeterOfTriangle();

            Console.WriteLine($"Perimeter of Triangle1 with pages: " +
                $"\npage1 = {triangle1.side1}; " +
                $"\npage2 = {triangle1.side2}; " +
                $"\npage3 = {triangle1.side3}; " +
                $"\nPerimeter => {perimeter1};\n");
            Console.WriteLine($"Perimeter of Triangle1 with pages: " +
                $"\npage1 = {triangle2.side1}; " +
                $"\npage2 = {triangle2.side2}; " +
                $"\npage3 = {triangle2.side3}; " +
                $"\nPerimeter => {perimeter2};\n");
            Console.WriteLine($"Perimeter of Triangle1 with pages: " +
                $"\npage1 = {triangle3.side1}; " +
                $"\npage2 = {triangle3.side2}; " +
                $"\npage3 = {triangle3.side3}; " +
                $"\nPerimeter => {perimeter3};\n");

            // work 7.2.1
            Kvadrati kvadrati = new Kvadrati(5,7);

            int area = kvadrati.rectangleArea();

            Samkutxedi samkutxedi = new Samkutxedi(6,7,10);

            int perimeter = samkutxedi.trianglePerimeter();

            Console.WriteLine($"Perimeter of Triangle:" +
                $"\none page is {samkutxedi.side1};" +
                $"\nsecond page is {samkutxedi.side2};" +
                $"\nthird page is {samkutxedi.side3};" +
                $"\nand Perimeter is: {perimeter};\n");

            Console.WriteLine($"Area of Rectangle:" +
                $"\nheight is {kvadrati.Height};" +
                $"\nwidth is {kvadrati.Width};" +
                $"\nand Area is: {area};\n");

            // work 7.3.1
            TriangleChild childTriangle = new TriangleChild();
            childTriangle.Side1 = 5;
            childTriangle.Side2 = 7;
            childTriangle.Side3 = 13;

            ((TriangleParrent)childTriangle).Side1 = 15;
            ((TriangleParrent)childTriangle).Side2 = 17;
            ((TriangleParrent)childTriangle).Side3 = 23;

            Console.WriteLine(value: $"perimeter of parent triangle is {childTriangle.ParrentPerimeter()};");
            Console.WriteLine(value: $"perimeter of child triangle is {childTriangle.ChildPerimeter()};");
            
            // work 7.4.1
            Phigure phig = new Phigure(4,6,5,6);

            Rectangle rec = new Rectangle(7, 6);

            Square square = new Square(5);

            Console.WriteLine($"perimeter of Phigure is {phig.Perimeter()};" +
                $"\nPerimeter of Rectangle is {rec.Perimeter()};" +
                $"\nPerimeter of Square is {square.Perimeter()};\n");
        }
    }
}
