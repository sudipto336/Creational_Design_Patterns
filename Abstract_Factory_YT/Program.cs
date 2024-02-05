using Abstract_Factory_YT.Factory;

namespace Abstract_Factory_YT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application(new MacFactory());
            application.Paint();
        }
    }
}
