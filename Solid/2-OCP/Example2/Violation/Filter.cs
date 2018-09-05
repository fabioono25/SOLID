using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._2_OCP.Example2.Violation
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product {

        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size){

            if (name == null)
                throw new ArgumentNullException(paramName: nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }
    }

    //filtering the product
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        //I want a filter by size and color - we need to change de body every time
        //we already have Filter by Color and Filter by Size. For each customization of filter, we can use other strategy
        //like specification pattern
        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
    }

    public class ExecuteExample
    {
        public static void Execute()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Apple", Color.Green, Size.Large);
            var house = new Product("Apple", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.Write("Green products:");
            foreach (var item in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {item.Name} is green");
            }
        }
    }
}

