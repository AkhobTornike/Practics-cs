namespace Week_5.Classes
{
    class Quadrilateral : GeometricFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Quadrilateral(double side1, double side2, double side3, double side4) 
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
    }
}
