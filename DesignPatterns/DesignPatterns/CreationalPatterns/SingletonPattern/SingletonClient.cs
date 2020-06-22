using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    class SingletonClient
    {
        public static void TestSingleton()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Instances are same.");
            }

            else
            {
                Console.WriteLine("Singleton pattern failed.");
            }

            Console.ReadKey();
        }

    }
}
