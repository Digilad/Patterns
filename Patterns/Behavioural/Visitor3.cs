using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Visitor
    /// Посетитель
    /// Tepljakov book pg. 256
    /// </summary>

    public class Visitor3
    {
        public void Using()
        {
            var circle = new Circle();
            var square = new Square();
            var rectangle = new Rectangle();
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(square.GetArea());
            Console.WriteLine(rectangle.GetArea());
        }
    }

    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }

    public interface IShapeVisitor
    {
        void Visit(Circle m);
        void Visit(Square m);
        void Visit(Rectangle m);
    }

    public class AreaVisitor : IShapeVisitor
    {
        public double Area { get; private set; }

        public void Visit(Circle c)
        {
            Area = Math.PI * Math.Sqrt(c.Radius);
        }

        public void Visit(Square s)
        {
            Area = s.X * s.X;
        }

        public void Visit(Rectangle r)
        {
            Area = r.X * r.Y;
        }
    }

    public static class ShapeEx
    {
        public static double GetArea(this IShape shape)
        {
            var visitor = new AreaVisitor();
            shape.Accept(visitor);
            return visitor.Area;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; } = 3;

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Square : IShape
    {
        public double X { get; set; } = 4;

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Rectangle : IShape
    {
        public double X { get; set; } = 2;
        public double Y { get; set; } = 3;

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
