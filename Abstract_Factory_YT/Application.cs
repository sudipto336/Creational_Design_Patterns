using Abstract_Factory_YT.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_YT
{
    internal class Application
    {
        Button button;
        CheckBox checkBox;
        public Application(UIFactory uiFactory)
        {
            this.button = uiFactory.CreateButton();
            this.checkBox = uiFactory.CreateCheckBox();
        }
        public void Paint ()
        {
            button.paint ();
            checkBox.paint ();
        }
    }
}
