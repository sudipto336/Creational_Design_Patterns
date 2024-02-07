using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class ContractualEmployee : Employee
    {
        public double FixedSalary { get; set; }

        public override Employee GetClone()
        {
            return (ContractualEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Contractual Employee Details: ");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Department: {this.Department}");
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Fixed Salary: {this.FixedSalary}");
            Console.WriteLine("==============================");
        }
    }
}
