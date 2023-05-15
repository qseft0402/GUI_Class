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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("我被點擊了");
            Form form_Button = new Form_Button();
            form_Button.Show();
        }

        private void btn_Button_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("我移開了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form_FinalGame();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form_TextBox();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form_Timer();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form_CheckBox();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form_Layout();
            form.Show();
        }
    }
}
