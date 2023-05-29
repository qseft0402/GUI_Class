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
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";

            foreach(Control c in panel2.Controls)
            {
                if(c is CheckBox)
                {
                    if(((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text+" ";
                    }
                }
            }


            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideFood += c.Text + " ";
                    }
                }
            }

            MessageBox.Show("主食:"+mainFood+ Environment.NewLine+"\n配菜:" +sideFood);

        }
    }
}
