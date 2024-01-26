namespace Singleton_Thread_Safe_Double_Check_Locking
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
