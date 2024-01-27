using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Thread_Unsafe
{
    internal sealed class Singleton
    {
        private static Singleton instance;

        private static int counter = 0;

        private Singleton() {
            counter++;
            Console.WriteLine($"Counter value increased");
            Console.WriteLine($"Counter value - {counter}");
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
