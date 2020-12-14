using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deikstra
{
    public partial class nah : Form
    {
        public nah()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && Convert.ToInt32(textBox2.Text) != 0 && Convert.ToInt32(textBox2.Text) <= deikstra.Size.N)
            {

                Program.begin_index = Convert.ToInt32(textBox2.Text) - 1;
                Program.alg();
                this.Hide();
            }
            else {
                MessageBox.Show("Введите вершину для начала обхода");
                textBox2.Text = ""; 
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(this, EventArgs.Empty);

            }
        }
    }
}
