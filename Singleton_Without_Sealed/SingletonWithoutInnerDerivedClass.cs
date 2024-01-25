using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Without_Sealed
{
    internal class SingletonWithoutInnerDerivedClass
    {
        private int counter = 0;
        private static SingletonWithoutInnerDerivedClass instance;

        private SingletonWithoutInnerDerivedClass()
        {
            counter++;
            Console.WriteLine($"Counter value - {counter}");
        }

        public static SingletonWithoutInnerDerivedClass GetSingletonInstance()
        {
            if (instance == null)
            {
                instance = new SingletonWithoutInnerDerivedClass();
            }
            return instance;
        }

        public void printMessage(String message)
        {
            Console.WriteLine(message);
        }
    }
}
