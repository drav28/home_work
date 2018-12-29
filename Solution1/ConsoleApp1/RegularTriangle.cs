namespace ConsoleApp1
{
    public class RegularTriangle : ITriangle
    {
        public RegularTriangle()
        {
            Type = "regular";

            SideA = 12.0;
            SideB = 7.0;
            SideC = 9.0;

            AngleA = 80;
            AngleB = 45;
            AngleC = 65;
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