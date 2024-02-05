using Abstract_Factory_YT.OS.MAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_YT.Factory
{
    internal class MacFactory : UIFactory
    {
        public CheckBox CreateCheckBox()
        {
            return new MacCheckbox();
        }

        public Button CreateButton()
        {
            return new MacButton();
        }
    }
}
