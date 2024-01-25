using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Without_Sealed
{
    internal class SingletonWithInnerDerivedClass
    {
        private static int counter = 0;
        private static SingletonWithInnerDerivedClass instance;

        private SingletonWithInnerDerivedClass() {
            ++counter;
            Console.WriteLine($"Counter value - {counter}");
        }

        public static SingletonWithInnerDerivedClass GetSingletonInstance()
        {
            if (instance == null)
            {
                instance = new SingletonWithInnerDerivedClass();
            }
            return instance;    
        }

        public void PrintMessage(String message)
        {
            Console.WriteLine(message);
        }

        public class DerivedSingletonWithInnerDerivedClass: SingletonWithInnerDerivedClass
        {

        }
    }
}
