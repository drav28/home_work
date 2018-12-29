namespace ConsoleApp1
{
    public class EqualSidesTriangle : ITriangle
    {
        public EqualSidesTriangle()
        {
            Type = "equalSides";

            SideA = 8;
            SideB = 8;
            SideC = 8;

            AngleA = 60;
            AngleB = 60;
            AngleC = 60;
        }

        public string Type { get; set; }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double AngleA { get; set; }
        public double AngleB { get; set; }
        public double AngleC { get; set; }
    }
}