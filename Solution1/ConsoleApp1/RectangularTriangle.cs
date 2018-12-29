using System;

namespace ConsoleApp1
{
    public class RectangularTriangle : ITriangle
    {
        public RectangularTriangle()
        {
            Type = "rectangular";

            SideA = 6;
            SideB = 12;
            SideC = HypotenuseCalculation(SideA, SideB);

            AngleA = 30;
            AngleB = 60;
            AngleC = 90;
        }

        public string Type { get; set; }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double AngleA { get; set; }
        public double AngleB { get; set; }
        public double AngleC { get; set; }

        private double HypotenuseCalculation(double sideA, double sideB)
        {
            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}