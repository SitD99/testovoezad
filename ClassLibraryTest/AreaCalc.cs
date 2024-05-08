namespace ShapeLibrary
{
    // не совсем понятен пункт "легкость добавления других фигур". тут добавлениен новых фигур будет происходить через реализацию
    // интерфейса IShape, вроде-бы легко, но всё опять же зависит от дальнейших требований
    public interface IShape
    {
        public double CalcArea();


    }

    public class Circle : IShape
    {
        public const double Pi = Math.PI;
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным.", nameof(radius));

            Radius = radius;
        }

        public double CalcArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (!IsTriangleValid(a, b, c))
                throw new ArgumentException("Треугольник с такими сторонами не существует.",
                                            nameof(a) + ", " + nameof(b) + ", " + nameof(c));
            A = a; B = b; C = c;
        }

        public double CalcArea()
        {
            double polyPerimetr = (A + B + C) / 2;
            return Math.Sqrt(polyPerimetr * (polyPerimetr - A) * (polyPerimetr - B) * (polyPerimetr - C));
        }
        public bool IsRightTriangle()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];
            return Math.Abs(c * c - (a * a + b * b)) < double.Epsilon;
        }
        private static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a; 
        }
    }
}