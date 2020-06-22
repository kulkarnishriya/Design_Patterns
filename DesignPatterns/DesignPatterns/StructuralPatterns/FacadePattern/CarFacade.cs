using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;
        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetCarModel();
            engine.SetCarEngine();
            body.SetCarBody();
            accessories.SetCarAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
