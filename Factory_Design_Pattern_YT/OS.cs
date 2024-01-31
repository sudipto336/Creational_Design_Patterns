using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_YT
{
    internal abstract class OS
    {
        public readonly string _version;
        public readonly string _architecture;

        public OS(string version, string architecture) {
            _version = version;
            _architecture = architecture;
        }

        public abstract void ChangeDir();
        public abstract void RemoveDir();
    }
}
