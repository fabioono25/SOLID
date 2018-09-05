using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._2_OCP.Example2.Solution
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {

        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
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
    }

    //we'll use a Specification Pattern to solve these problem of multiple new filters
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    //implementation of interfaces
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color color;

        public ColorSpecification(Color color) => this.color = color;

        public bool IsSatisfied(Product t) => t.Color == color;
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size) => this.size = size;

        public bool IsSatisfied(Product t) => t.Size == size;
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        //private ISpecification<T> first, second;
        private ISpecification<T> first { get; }
        private ISpecification<T> second { get; }

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;
            }
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

            //implementing a better way
            var bf = new BetterFilter();
            Console.Write("Green products:");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.Write("Large blue items:");
            foreach (var p in bf.Filter(products, 
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
            {
                Console.WriteLine($" - {p.Name} is blue and large.");
            }
        }
    }
}
