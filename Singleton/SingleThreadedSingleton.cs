using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingleThreadedSingleton
    {
        private static SingleThreadedSingleton instance;

        private int counter = 0;

        private SingleThreadedSingleton() {
            counter++;
            Console.WriteLine($"Counter value increased");
            Console.WriteLine($"Counter value - {counter}");
        }

        public static SingleThreadedSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new SingleThreadedSingleton();
            }
            return instance;
        }

        public void printMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
