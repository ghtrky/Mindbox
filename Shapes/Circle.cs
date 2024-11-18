namespace Shapes
{
    public class Circle: IShape
    {
        public double R { get; }

        public Circle(double r)
        {
            R = r > 0 
                ? r 
                : throw new ArgumentException();
        }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
