using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Thread_Safe_Lazy
{
    internal sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value increased");
            Console.WriteLine($"Counter value - {counter}");
        }

        public static Singleton GetInstance()
        {
            return instance.Value;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
