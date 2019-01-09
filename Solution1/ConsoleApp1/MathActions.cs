using System;

namespace ConsoleApp1
{
    public class MathActions
    {
        public static void Main()
        {
            var rectTringle = new RectangularTriangle();
            var equalTriangle = new EqualSidesTriangle();
            var regularTriangle = new RegularTriangle();
            
            Console.WriteLine("Rectangular triangle sides sum: " + SidesSum(rectTringle.SideA, rectTringle.SideB, rectTringle.SideC));
            Console.WriteLine("EqualSides triangle sides sum: " + SidesSum(equalTriangle.SideA, equalTriangle.SideB, equalTriangle.SideC));
            Console.WriteLine("Regular triangle sides sum: " + SidesSum(regularTriangle.SideA, regularTriangle.SideB, regularTriangle.SideC));

            Console.WriteLine("Rectangular triangle angles sum: " + AnglesSum(rectTringle.AngleA, rectTringle.AngleB, rectTringle.AngleC));
            Console.WriteLine("EqualSides triangle angles sum: " + AnglesSum(equalTriangle.AngleA, equalTriangle.AngleB, equalTriangle.AngleC));
            Console.WriteLine("Regular triangle angles sum: " + AnglesSum(regularTriangle.AngleA, regularTriangle.AngleB, regularTriangle.AngleC));

            Console.WriteLine("Rectangular triangle median size: " + MedianSizeCalculation(rectTringle.Type, rectTringle.SideA));
            Console.WriteLine("EqualSides triangle median size: " + MedianSizeCalculation(equalTriangle.Type, equalTriangle.SideA));
            Console.WriteLine("Regular triangle median size: " + MedianSizeCalculation(regularTriangle.Type, regularTriangle.SideA));
        }

        public static double SidesSum(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double AnglesSum(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double MedianSizeCalculation(string type, double side)
        {
            if (type != "equalSides")
            {
                throw new Exception("The triangle is not EqualSide");
            }

            return (side * Math.Sqrt(3)) / 2;
        }
    }
}