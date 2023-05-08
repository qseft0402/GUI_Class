using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_0220
{
    public partial class Form_Timer : Form
    {
        int second=0;
        public Form_Timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = this.second + "秒";
            this.second++;
        }
    }
}
