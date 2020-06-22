using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class ShapeClient
    {
        public static void CallFactory()
        {
            IShape _IShape;
            Console.WriteLine("Type shape to display.");
            string sh = Console.ReadLine();
            _IShape = ShapeFactory.GetShape(sh);
            Console.WriteLine("Enter shape color");
            string color = Console.ReadLine();
            _IShape.color = color;

            _IShape.Getinputs();
            _IShape.CalculateArea();
            _IShape.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
