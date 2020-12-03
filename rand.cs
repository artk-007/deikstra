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

    public partial class rand : Form
    {
        int[,] Matrix = new int[deikstra.Size.N, deikstra.Size.N];


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
                        Matrix[i,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                        {
                            Matrix[i,j] = rand.Next(0, 10);
                            if (rand.Next(0, 10) > 4)
                                Matrix[j,i] = 0;
                            else
                                Matrix[j,i] = Matrix[i,j];
                        }
                        else
                            if (rand.Next(0, 10) > 4)
                        {
                            Matrix[j,i] = rand.Next(0, 10);
                            Matrix[i,j] = 0;
                        }
                        else
                        {
                            Matrix[i,j] = 0;
                            Matrix[j,i] = 0;
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
                        Matrix[i ,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                            Matrix[i,j] = rand.Next(0, 10);
                        else
                            Matrix[i,j] = 0;
                        Matrix[j ,i] = Matrix[i ,j];
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
                        Matrix[i,j] = 0;
                    }
                    if (i < j)
                    {
                        Matrix[i ,j] = rand.Next(0, 2);
                        Matrix[j,i] = Matrix[i,j];
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
                        Matrix[i ,j] = 0;
                    }
                    if (i < j)
                    {
                        if (rand.Next(0, 10) > 4)
                        {
                            Matrix[i ,j] = rand.Next(0, 2);
                            if (rand.Next(0, 10) > 4)
                                Matrix[j ,i] = 0;
                            else
                                Matrix[j ,i] = Matrix[i ,j];
                        }
                        else
                            if (rand.Next(0, 10) > 4)
                        {
                            Matrix[j,i] = rand.Next(0, 2);
                            Matrix[i,j] = 0;
                        }
                        else
                        {
                            Matrix[i,j] = 0;
                            Matrix[j,i] = 0;
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
            dataGridView1.RowCount = Matrix.GetLength(0);
            dataGridView1.ColumnCount = Matrix.GetLength(1);
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = Matrix[i, j];
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
    }
}
