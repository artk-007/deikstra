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
    public partial class vryh : Form
    {

        public vryh()
        {
            InitializeComponent();
            dataGridView1.RowCount = deikstra.Size.Matrix.GetLength(0);
            dataGridView1.ColumnCount = deikstra.Size.Matrix.GetLength(1);
            for (int i = 0; i < deikstra.Size.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < deikstra.Size.Matrix.GetLength(1); j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = deikstra.Size.Matrix[i, j];
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Size Size = new Size();
            Size.Show();
        }
    }
}
