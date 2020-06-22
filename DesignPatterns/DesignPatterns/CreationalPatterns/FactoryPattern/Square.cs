using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class Square : IShape
    {
        private string _color;
        public string color { get => _color; set => _color = value; }

        public int side;

        public void Getinputs()
        {
            Console.WriteLine("Enter side of square");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of square is {side * side} and color is {color}");
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter of square is {4 * side} and color is {color}");
        }
    }
}
