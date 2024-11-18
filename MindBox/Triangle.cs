namespace Shapes
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        private double P
        {
            get => A + B + C;
        }

        private double HalfP
        {
            get => P / 2;
        }

        public Triangle(double a, double b, double c)
        {
            if (a > 0 
                && b > 0 
                && c > 0
                && a < b + c
                && b < a + c
                && c < b + a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double GetArea()
        {
            return Math.Sqrt(HalfP * (HalfP - A) * (HalfP - B) * (HalfP - C));
        }

        public bool IsRectangular()
        {
            double[] sides = { A, B, C };

            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
