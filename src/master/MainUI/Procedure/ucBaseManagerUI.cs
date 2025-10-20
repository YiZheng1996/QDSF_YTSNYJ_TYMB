using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    public partial class ucBaseManagerUI : UserControl
    {
        public ucBaseManagerUI()
        {
            InitializeComponent();
        }

        public virtual void Reload()
        {
        }
    }
}
