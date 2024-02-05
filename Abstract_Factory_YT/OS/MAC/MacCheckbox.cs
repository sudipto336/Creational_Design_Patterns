using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_YT.OS.MAC
{
    internal class MacCheckbox : CheckBox
    {
        public void paint()
        {
            Console.WriteLine("Mac checkbox painted");
        }
    }
}
