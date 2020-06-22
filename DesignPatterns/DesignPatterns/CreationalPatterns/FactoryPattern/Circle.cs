using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        private string _color;
        public string color { get => _color; set => _color = value; }

        public int radius;

        private const double pi = 3.14;

        public void Getinputs()
        {
            Console.WriteLine("Enter side of square");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area of circle is {pi * radius * radius} and color is {color}");
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter of circle is {pi * radius * 2} and color is {color}");
        }
    }
}
