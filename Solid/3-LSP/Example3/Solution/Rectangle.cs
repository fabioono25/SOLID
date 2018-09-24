using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example3.Solution
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

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
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public static class ExecuteSample
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        public static void Execute()
        {
            Rectangle rc = new Rectangle(2,3);
            Console.WriteLine($"{rc} has area {Area(rc)}"); //6

            Square sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}"); //16

            Rectangle rc2 = new Square();
            rc2.Width = 4;
            Console.WriteLine($"{rc2} has area {Area(rc2)}"); //16
        }
    }
}
