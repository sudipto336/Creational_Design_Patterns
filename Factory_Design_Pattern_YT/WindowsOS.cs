using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_YT
{
    internal class WindowsOS: OS
    {
        public WindowsOS(string version, string architecture) : base(version, architecture) { }

        public override void ChangeDir()
        {
            Console.WriteLine("Changing directory in Windows OS...");
        }

        public override void RemoveDir()
        {
            Console.WriteLine("Removing directory in Windows OS...");
        }
    }
}
