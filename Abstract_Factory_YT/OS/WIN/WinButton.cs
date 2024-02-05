using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_YT.OS.MAC
{
    internal class WinButton : Button
    {
        public void paint()
        {
            Console.WriteLine("Windows button painted");
        }
    }
}
