using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class SportsCar : ICar
    {
        public void GetCarDetails()
        {
            Console.WriteLine("Getting details from sports car"); ;
        }
    }
}
