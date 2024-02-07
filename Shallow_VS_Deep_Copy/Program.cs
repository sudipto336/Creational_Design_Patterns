namespace Shallow_VS_Deep_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "Sam",
                Department = "IT",
                Age = 25,
                EmpAddress = new Address() { Street = "ABC", City = "Kolkata", Country = "India", Zip = 700002 }
            };
            Employee employee2 = employee1.GetDeepCopy();
            employee2.Name = "Peter";
            employee2.Age = 30;
            employee2.EmpAddress.Street = "DEF";

            Employee employee3 = new Employee()
            {
                Name = "John",
                Department = "HR",
                Age = 35,
                EmpAddress = new Address() { Street = "XYZ", City = "Mumbai", Country = "India", Zip = 400001 }
            };
            Employee employee4 = employee3.GetShallowCopy();
            employee2.Name = "Andrew";
            employee2.Age = 20;
            employee2.EmpAddress.Street = "MNO";

            Console.WriteLine($"Employee 1: Name: {employee1.Name}, Age: {employee1.Age}, Department: {employee1.Department}, Address: {employee1.EmpAddress.Street}, {employee1.EmpAddress.City}, {employee1.EmpAddress.Country}, {employee1.EmpAddress.Zip}");
            Console.WriteLine($"Employee 2: Name: {employee2.Name}, Age: {employee2.Age}, Department: {employee2.Department}, Address: {employee2.EmpAddress.Street}, {employee2.EmpAddress.City}, {employee2.EmpAddress.Country}, {employee2.EmpAddress.Zip}");
            Console.WriteLine($"Employee 3: Name: {employee3.Name}, Age: {employee3.Age}, Department: {employee3.Department}, Address: {employee3.EmpAddress.Street}, {employee3.EmpAddress.City}, {employee3.EmpAddress.Country}, {employee3.EmpAddress.Zip}");
            Console.WriteLine($"Employee 4: Name: {employee4.Name}, Age: {employee4.Age}, Department: {employee4.Department}, Address: {employee4.EmpAddress.Street}, {employee4.EmpAddress.City}, {employee4.EmpAddress.Country}, {employee4.EmpAddress.Zip}");
        }
    }
}
