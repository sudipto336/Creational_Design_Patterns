namespace Singleton_Thread_Safe_Lazy_Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => CallSingletonMethod(),
                () => CallSingletonMethod()
            );
        }

        private static void CallSingletonMethod()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.PrintMessage("message");
        }
    }
}
