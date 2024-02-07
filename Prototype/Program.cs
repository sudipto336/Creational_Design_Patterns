namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fullTimeEmployeePrototype = new FullTimeEmployee(){
                Name = "Test_Name",
                Department = "Test_Department",
                Type = "Full Time",
                FixedSalary = 20000,
                Bonus = 5000
            };

            Employee contractualEmployeePrototype = new ContractualEmployee()
            {
                Name = "Test_Name",
                Department = "Test_Department",
                Type = "Contractual",
                FixedSalary = 10000
            };

            Employee fullTimeEmployee1 = fullTimeEmployeePrototype.GetClone();
            fullTimeEmployee1.Name = "Sam";
            fullTimeEmployee1.Department = "HR";

            fullTimeEmployee1.ShowDetails();

            Employee contractualEmployee1 = contractualEmployeePrototype.GetClone();
            contractualEmployee1.Name = "Peter";
            contractualEmployee1.Department = "IT";

            contractualEmployee1.ShowDetails();
        }
    }
}
