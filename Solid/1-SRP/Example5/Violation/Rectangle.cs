using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example5
{
    //class to calculate area and draw something
    public class RectangleShape
    {
        public  int Height { get; set; }
        public  int Width { get; set; }

        public  int Area() => Width * Height;

        public  void Draw(string form) => Console.WriteLine("Drawing: " + form);
    }

    //class that consumes the Rectangle
    public class GeometricsCalculator
    {
        public int CalculateArea(RectangleShape recShape) => recShape.Area();
    }

    //another actor using the Rectangle class
    public class GraphicsManager
    {
        public void DrawOnScreen(RectangleShape recShape) => recShape.Draw("Adasdasdasdasd");
    }
}
