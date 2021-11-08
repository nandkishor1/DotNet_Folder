using System;

namespace AbstractMethodAndClassImplementation
{
    public abstract class Figure
    {
        public double width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }
    public class Rectangle: Figure
    {
        public Rectangle(double width, double Height)
        {
            this.width = width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return width * Height;   
        }
    }
    public class Circle: Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius*Radius;
        }
    }
    public class Cone: Figure
    {
        public Cone(double Height, double Radius)
        {
            this.Height = Height;
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
    
    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.52, 58.52);
            Circle c = new Circle(54.25);
            Cone cn = new Cone(10.25, 5.36);

            Console.WriteLine("Area of Rectangle: " + r.GetArea());
            Console.WriteLine("Area of Circle: " + c.GetArea());
            Console.WriteLine("Area of Cone: " + cn.GetArea());

            Console.ReadLine();
        }
    }
}

