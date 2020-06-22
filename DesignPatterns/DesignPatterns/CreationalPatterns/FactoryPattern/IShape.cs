using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public interface IShape
    {
        string color { get; set; }
        void CalculateArea();
        void CalculatePerimeter();
        void Getinputs();
    }
}
