using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
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
            vvod vvod = new vvod();
            vvod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {

                    deikstra.Size.Matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            MessageBox.Show("Успешно");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            nah nah = new nah();
            nah.ShowDialog();
            textBox1.Text = "";
            //окно со стартовой вершиной и алгоритм в отдельную функцию
            if (Program.begin_index > -1)
                for (int i = 0; i < deikstra.Size.N; i++)
                {
                    if (Program.d[i] != 10000)
                        textBox1.Text += String.Format("до вершины: {0} длинна пути: {1} ", i + 1, Program.d[i]) + '\r' + '\n';
                    else
                        textBox1.Text += String.Format("до вершины: {0} нет пути", i + 1) + '\r' + '\n';
                }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {

            rand.SaveTable(dataGridView1, textBox1);
            MessageBox.Show("сохранено");
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string vlCell = ((TextBox)sender).Text;
            bool temp = (vlCell.IndexOf(".") == -1);
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
