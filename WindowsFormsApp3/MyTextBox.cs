using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class MyTextBox : TextBox
    {
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        public MyTextBox()
        {
            this.AutoSize = false;
            //this.Margin = new Padding(3, 3, 3, 3);
        }
    }
}
