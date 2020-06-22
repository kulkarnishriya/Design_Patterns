using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;
        //private constructor
        Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            //thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
