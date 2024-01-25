using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class SingleThreadedSingleton
    {
        private static SingleThreadedSingleton instance;

        private static int counter = 0;

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

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
