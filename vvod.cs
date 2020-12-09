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
    public partial class vvod : Form
    {
        public static int p1;
        
        public vvod()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Size Size = new Size();
            // Показываем новое окно
            Size.Show();
            p1 = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Size Size = new Size();
            // Показываем новое окно
            Size.Show();
            p1 = 2;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
