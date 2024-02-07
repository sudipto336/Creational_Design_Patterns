using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallow_VS_Deep_Copy
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        public Employee GetShallowCopy()
        {
            return (Employee) this.MemberwiseClone();
        }

        public Employee GetDeepCopy()
        {
            Employee clonedEmp = (Employee)this.MemberwiseClone();
            clonedEmp.EmpAddress = EmpAddress.GetClone();
            return clonedEmp;
        }
    }
}
