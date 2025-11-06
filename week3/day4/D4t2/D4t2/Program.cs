using System;

namespace D4t2
{
    
    public abstract class Shape
    {
        
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

       
        public override double Area()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.5, 5.2);
            Console.WriteLine("Area of Rectangle: " + rect.Area());

            Console.ReadLine();
        }
    }
}
