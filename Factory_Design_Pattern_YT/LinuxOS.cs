using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_YT
{
    internal class LinuxOS : OS
    {
        public LinuxOS(string version, string architecture): base(version, architecture) { }

        public override void ChangeDir()
        {
            Console.WriteLine("Changing directory in Linux OS...");
        }

        public override void RemoveDir()
        {
            Console.WriteLine("Removing directory in Linux OS...");
        }
    }
}
