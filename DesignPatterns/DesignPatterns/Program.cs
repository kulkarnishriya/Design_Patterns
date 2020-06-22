using DesignPatterns.CreationalPatterns.FactoryPattern;
using DesignPatterns.CreationalPatterns.SingletonPattern;
using DesignPatterns.StructuralPatterns.AdapterPattern;
using DesignPatterns.StructuralPatterns.CompositePattern;
using DesignPatterns.StructuralPatterns.FacadePattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory pattern
            ShapeClient.CallFactory();

            //Singleton pattern
             SingletonClient.TestSingleton();

            //Adapter pattern
            AdapterClient.CallAdapter();

            //Composite pattern
            CardClient cardClient = new CardClient();
             cardClient.CallComposite();

            //Fascade pattern
            FacadeClient facadeClient = new FacadeClient();
            facadeClient.CallFacade();

            Console.ReadKey();
        }
    }
}
