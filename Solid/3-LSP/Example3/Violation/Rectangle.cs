using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example3.Violation
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    //here the problems begin
    public class Square : Rectangle
    {
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public static class ExecuteSample
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        public static void Execute()
        {
            Rectangle rc = new Rectangle();
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Square sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}"); //16

            Rectangle rc2 = new Square();
            rc2.Width = 4;
            Console.WriteLine($"{rc2} has area {Area(rc2)}"); //0 - error!
        }
    }
}
