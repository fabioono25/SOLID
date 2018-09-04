using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example5.Solution
{
    //class that calculate area
    public class RectangleShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area() => Width * Height;
    }

    //class that draw something
    public class RectangleDraw
    {
        public void Draw(string form) => Console.WriteLine("Drawing: " + form);
    }

    //consume rectangle shape
    public class GeometricsCalculator
    {
        public int CalculateArea(RectangleShape recShape) => recShape.Area();
    }

    //consumes rectangle draw and shape
    public class GraphicsManager
    {
        public string Form { get; set; }

        public void Draw(RectangleDraw recDraw, RectangleShape recShape) {
            recDraw.Draw("asdasdasd");
            Console.WriteLine("Drawing: ");
        }
    }
}
