using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace deikstra
{

    public partial class rand : Form
    {


        
        public rand()
        {
            InitializeComponent();
        }
        private void rand_Zap_vz_or()
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < deikstra.Size.N; i++)
                for (int j = 0; j < deikstra.Size.N; j++)
                {
                    if (i == j)
                    {
                        deikstra.Size.Matrix[i,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                        {
                            deikstra.Size.Matrix[i,j] = rand.Next(0, 10);
                            if (rand.Next(0, 10) > 4)
                                deikstra.Size.Matrix[j,i] = 0;
                            else
                                deikstra.Size.Matrix[j,i] = deikstra.Size.Matrix[i,j];
                        }
                        else
                            if (rand.Next(0, 10) > 4)
                        {
                            deikstra.Size.Matrix[j,i] = rand.Next(0, 10);
                            deikstra.Size.Matrix[i,j] = 0;
                        }
                        else
                        {
                            deikstra.Size.Matrix[i,j] = 0;
                            deikstra.Size.Matrix[j,i] = 0;
                        }
                    }
                }
        }
        private void rand_Zap_vz_nor()
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < deikstra.Size.N; i++)
                for (int j = 0; j < deikstra.Size.N; j++)
                {
                    if (i == j)
                    {
                        deikstra.Size.Matrix[i ,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                            deikstra.Size.Matrix[i,j] = rand.Next(0, 10);
                        else
                            deikstra.Size.Matrix[i,j] = 0;
                        deikstra.Size.Matrix[j ,i] = deikstra.Size.Matrix[i ,j];
                    }
                }
        }
        private void rand_Zap_nor()
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < deikstra.Size.N; i++)
                for (int j = 0; j < deikstra.Size.N; j++)
                {
                    if (i == j)
                    {
                        deikstra.Size.Matrix[i,j] = 0;
                    }
                    if (i < j)
                    {
                        deikstra.Size.Matrix[i ,j] = rand.Next(0, 2);
                        deikstra.Size.Matrix[j,i] = deikstra.Size.Matrix[i,j];
                    }
                }
        }
        private void rand_Zap_or()
        {
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < deikstra.Size.N; i++)
                for (int j = 0; j < deikstra.Size.N; j++)
                {
                    if (i == j)
                    {
                        deikstra.Size.Matrix[i ,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                        {
                            deikstra.Size.Matrix[i ,j] = rand.Next(0, 2);
                            if (rand.Next(0, 10) > 4)
                                deikstra.Size.Matrix[j ,i] = 0;
                            else
                                deikstra.Size.Matrix[j ,i] = deikstra.Size.Matrix[i ,j];
                        }
                        else
                            if (rand.Next(0, 10) > 4)
                        {
                            deikstra.Size.Matrix[j,i] = rand.Next(0, 2);
                            deikstra.Size.Matrix[i,j] = 0;
                        }
                        else
                        {
                            deikstra.Size.Matrix[i,j] = 0;
                            deikstra.Size.Matrix[j,i] = 0;
                        }
                    }
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    switch (checkedListBox2.SelectedIndex)
                    {
                        case 0: 
                            rand_Zap_vz_or();
                            break;
                        case 1:
                            rand_Zap_vz_nor();
                            break;
                       
                    }
                    break;
                        case 1:
                            switch (checkedListBox2.SelectedIndex)
                            {
                                case 0:
                            rand_Zap_or();
                            break;
                                case 1:
                            rand_Zap_nor();
                            break;
                                
                            }

                            break;
                default:
                    break;
            }
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
                checkedListBox2.SetItemChecked(checkedListBox2.SelectedIndex, true);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nah nah = new nah();
            nah.ShowDialog();
            textBox1.Text = "";
            //окно со стартовой вершиной и алгоритм в отдельную функцию
            
            for (int i = 0; i < deikstra.Size.N; i++)
            {
                textBox1.Text += String.Format("до вершины{0} длинна пути{1} ", i+1, Program.d[i])+ '\r' + '\n';
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Size Size = new Size();
            Size.Show();
        }

        void SaveTable(DataGridView What_save)
        {
            
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + String.Format("Save_Excel{0}.xlsx", DateTime.Now) ;

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < What_save.RowCount + 1; i++)
            {
                for (int j = 1; j < What_save.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = What_save.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveTable(dataGridView1);
            MessageBox.Show("сохранено");
        }
    }
}
