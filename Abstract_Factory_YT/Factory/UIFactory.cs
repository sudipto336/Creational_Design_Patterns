using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_YT.Factory
{
    internal interface UIFactory
    {
        Button CreateButton();
        CheckBox CreateCheckBox();
    }
}
