namespace Singleton_Vs_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select option to convertor direction");
            Console.WriteLine("1. From Celsius to Farhenheit");
            Console.WriteLine("2. From Farhenheit to Celsius");
            string selection = Console.ReadLine();
            switch (selection) {
                case "1":
                    Console.Write("Enter temperature in Celsius: ");
                    Console.WriteLine("Temperature in Farhenheit: {0:F2}", TemperatureConverter.ConvertCelsiusToFarhenheit(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Enter temperature in Farhenheit: ");
                    Console.WriteLine("Temperature in Celsius: {0:F2}", TemperatureConverter.ConvertFarhenheitToCelsius(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Please select option to convertor direction");
                    break;

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
