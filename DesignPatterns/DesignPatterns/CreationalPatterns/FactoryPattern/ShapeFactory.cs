using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetShape(string input)
        {
            switch (input.ToLower())
            {
                case "circle":
                    return new Circle();
                    
                case "square":
                    return new Square();
                    
                default:
                    return null;
                    
            }
                
        }
    }
}
