namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleThreadedSingleton1 = Singleton.GetInstance();
            singleThreadedSingleton1.PrintMessage("message1");
            Singleton singleThreadedSingleton2 = Singleton.GetInstance();
            singleThreadedSingleton2.PrintMessage("message2");
        }
    }
}
