using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallow_VS_Deep_Copy
{
    internal class Address
    {
        public string Street { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address GetClone()
        {
            return (Address) this.MemberwiseClone();
        }
    }
}
