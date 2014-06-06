using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4Elephant
{
    class Elephant
    {
        public String Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", Name + " says...");
        }

    }
}
