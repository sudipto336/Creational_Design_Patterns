using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class SportsBike : IBike
    {
        public void GetBikeDetails()
        {
            Console.WriteLine("Getting details from sports bike"); ;
        }
    }
}
