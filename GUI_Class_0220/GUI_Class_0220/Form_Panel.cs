using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace GUI_Class_0220
{
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
            File.WriteAllText("Temp.txt", "Hello I'm Awen\n");
            File.AppendAllText("Temp.txt","我是第二行\n");
            String input=File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
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
