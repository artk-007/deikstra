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
           if (textBox2.Text == "" || textBox2.Text == "Ошибка")
            {
                textBox2.Text = "Ошибка";
                
            }
            if (textBox2.Text != "" && textBox2.Text != "Ошибка")
            {
                N = Convert.ToInt32(textBox2.Text);
                this.Hide();
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
                
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
