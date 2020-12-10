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
    public partial class fail : Form
    {
        public fail()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vvod vvod = new vvod();
            vvod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
