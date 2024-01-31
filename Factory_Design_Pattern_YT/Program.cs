namespace Factory_Design_Pattern_YT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any of following type of OS");
            Console.WriteLine("windows");
            Console.WriteLine("linux");
            string enteredOSType = Console.ReadLine();
            OS enteredOS = OSFactory.GetOSInstance(enteredOSType, "1", "x64");
            enteredOS.ChangeDir();
            enteredOS.RemoveDir();
        }
    }
}
