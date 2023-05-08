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
    public partial class Form_TextBox : Form
    {
        public Form_TextBox()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int add1 = 0;
            int add2 = 0;
            try
            {
                add1 = Int32.Parse(textBox_Add1.Text);
                add2 = Int32.Parse(textBox_Add2.Text);
            }catch(Exception)
            {
                MessageBox.Show("發生錯誤");
                add1 = 0;
                add2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");
            }
            label_result.Text = (add1 + add2).ToString();

        }
    }
}
