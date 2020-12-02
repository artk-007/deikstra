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
    
    public partial class Form1 : Form
    {
        public static int Matrix;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                vvod vvod = new vvod();
                // Показываем новое окно
                vvod.Show();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
