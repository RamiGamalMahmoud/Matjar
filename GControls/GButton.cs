using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GControls
{
    public class GButton : Button
    {
        public GButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Arial",10);
            this.Size = new Size(16,16);
        }
    }
}
