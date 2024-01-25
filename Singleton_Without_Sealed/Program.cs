namespace Singleton_Without_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonWithInnerDerivedClass singleton = SingletonWithInnerDerivedClass.GetSingletonInstance();
            singleton.PrintMessage("message1");
            singleton.PrintMessage("message2");
            SingletonWithInnerDerivedClass.DerivedSingletonWithInnerDerivedClass derivedSingleton = new SingletonWithInnerDerivedClass.DerivedSingletonWithInnerDerivedClass();
            derivedSingleton.PrintMessage("meesage3");
            derivedSingleton.PrintMessage("meesage4");


        }
    }
}
