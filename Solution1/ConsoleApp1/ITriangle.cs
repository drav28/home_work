namespace ConsoleApp1
{
    public interface ITriangle
    {
        string Type { get; set; }

        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
        
        double AngleA { get; set; }
        double AngleB { get; set; }
        double AngleC { get; set; }
    }
}