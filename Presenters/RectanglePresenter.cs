using RectangleCalc.Models;
using RectangleCalc.Views;

namespace RectangleCalc.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;
        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);
            rectangleView.Areatext = rectangle.CalculateArea().ToString();
        }
    }
}
