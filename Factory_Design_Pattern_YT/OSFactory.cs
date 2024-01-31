using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern_YT
{
    internal class OSFactory
    {
        public static OS GetOSInstance(string osType, string version, string architecture)
        {
            switch (osType)
            {
                case "windows":
                    return new WindowsOS(version, architecture);
                case "linux":
                    return new LinuxOS(version, architecture);
                default:
                    throw new ArgumentException("Enetered OS not supported");
            }
        }
    }
}
