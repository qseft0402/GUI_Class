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
    public partial class Form_FinalGame : Form
    {
        int _answer;
        public Form_FinalGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random(); // 宣告一個 Random 物件：r
            //MessageBox.Show(r.Next().ToString());
            _answer= r.Next(100);
            MessageBox.Show(_answer.ToString());

            //MessageBox.Show(r.Next(-20,-10).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Int32.Parse(tb_input.Text);
                if (result > this._answer)
                    MessageBox.Show("太大囉");
                else if (result == this._answer)
                    MessageBox.Show("答對囉!");
                else if (result < this._answer)
                    MessageBox.Show("太小囉");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
