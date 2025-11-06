using System;

namespace D4t3
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
            try
            {
                if (length < 0 || width < 0)
                {
                    throw new ArgumentException("Length and width must be non-negative.");
                }

                return length * width;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0; // Return 0 as a fallback
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error occurred: " + ex.Message);
                return 0;
            }
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rect1 = new Rectangle(10.5, 5.2);
            Console.WriteLine("Area of Rectangle 1: " + rect1.Area());

           
            Rectangle rect2 = new Rectangle(-4, 6);
            Console.WriteLine("Area of Rectangle 2: " + rect2.Area());

            Console.ReadLine();
        }
    }
}
