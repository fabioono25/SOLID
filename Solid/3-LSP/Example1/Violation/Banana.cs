using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3_LSP.Example1.Violation
{
    public class Lemon
    {
        public virtual string GetColor() { 
            return "green"; 
        }
    }

    public class Orange : Lemon
    {
        public override string GetColor()
        {
            return "orange";
        }
    }
    
    public class ExecuteTest
    {
        public static void Execute()
        {
            Lemon lemon = new Orange();
            //orange cannot be replaced by lemon, returning orange's color
            Console.WriteLine(lemon.GetColor());
        }
    }
}
