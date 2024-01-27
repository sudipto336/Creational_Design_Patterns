namespace Singleton_Thread_Safe_Eager_Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => CallSingletonMethod1(),
                () => CallSingletonMethod2()
            );
        }

        private static void CallSingletonMethod1()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.PrintMessage("message1");
        }

        private static void CallSingletonMethod2()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.PrintMessage("message2");
        }
    }
}
