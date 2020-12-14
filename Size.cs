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
    
    public partial class Size : Form
    {
        public static int N=0;
        public static int[,] Matrix;


        public Size()
        {
            InitializeComponent();
        }

        private void Size_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            vvod vvod = new vvod();
            // Показываем новое окно
            vvod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && Convert.ToInt32(textBox2.Text)!= 0)
            {
                N = Convert.ToInt32(textBox2.Text);
                this.Hide();
                Matrix = new int[deikstra.Size.N, deikstra.Size.N];
                switch (deikstra.vvod.p1)
                {
                    case 1:
                        this.Hide();
                        rand rand = new rand();
                        rand.Show();
                        break;
                    case 2:
                        this.Hide();
                        vryh vryh = new vryh();
                        vryh.Show();
                        break;
                }

            }
            else { 
                MessageBox.Show("Введите размер графа");
            textBox2.Text = "";
        }
    }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vvod vvod = new vvod();
            vvod.Show();
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
