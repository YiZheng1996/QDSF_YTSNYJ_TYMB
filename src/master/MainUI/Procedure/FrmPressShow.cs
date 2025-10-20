using MainUI.Procedure.TestHelpClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    public partial class FrmPressShow : Form
    {
        public FrmPressShow()
        {
            InitializeComponent();
        }
        public FrmPressShow(int value)
        {
            InitializeComponent();
            this._value = value;
        }
        private int _value;
        public int value
        {
            get { return _value; }
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //uiTextBox1.Text = Class_JYF.Elect.ACGQ.ToString();
            //uiTextBox2.Text = Class_JYF.Elect.BCGQ.ToString();
        }

        private void FrmPressShow_Load(object sender, EventArgs e)
        {
            uiLabel3.Text = "试验标准为" + value + "±10kPa";
            timer1.Enabled = true;
        }
    }
}
