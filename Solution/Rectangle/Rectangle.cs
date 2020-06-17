namespace Rectangle
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }
    }
}
