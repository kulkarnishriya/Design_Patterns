using DesignPatterns.CreationalPatterns.FactoryPattern;
using DesignPatterns.CreationalPatterns.SingletonPattern;
using DesignPatterns.StructuralPatterns.AdapterPattern;
using DesignPatterns.StructuralPatterns.CompositePattern;
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
            CardClient client = new CardClient();
            client.CallComposite();

            Console.ReadKey();
        }
    }
}
