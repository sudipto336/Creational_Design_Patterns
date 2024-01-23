namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleThreadedSingleton singleThreadedSingleton1 = SingleThreadedSingleton.GetInstance();
            singleThreadedSingleton1.printMessage("message1");
            SingleThreadedSingleton singleThreadedSingleton2 = SingleThreadedSingleton.GetInstance();
            singleThreadedSingleton2.printMessage("message2");
        }
    }
}
