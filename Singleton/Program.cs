namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleThreadedSingleton singleThreadedSingleton1 = SingleThreadedSingleton.GetInstance();
            singleThreadedSingleton1.PrintMessage("message1");
            SingleThreadedSingleton singleThreadedSingleton2 = SingleThreadedSingleton.GetInstance();
            singleThreadedSingleton2.PrintMessage("message2");
        }
    }
}
