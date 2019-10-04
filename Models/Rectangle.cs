namespace RectangleCalc.Models
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }
}
