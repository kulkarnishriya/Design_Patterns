using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class FacadeClient
    {
        public void CallFacade() 
        {
            CarFacade facade = new CarFacade();
            facade.CreateCompleteCar();
        }
    }
}
