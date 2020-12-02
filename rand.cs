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
        public rand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    switch (checkedListBox2.SelectedIndex)
                    {
                        case 0:
                            int[,] Matrix = new int[deikstra.Size.N, deikstra.Size.N];
                            for (int i = 0; i < deikstra.Size.N; i++)
                            {
                                for (int j = 0; j < deikstra.Size.N; j++)
                                {
                                    Random rand = new Random();
                                    if (i == j)
                                    {
                                        Matrix[i, j] = 0;
                                    }
                                    if (i < j)
                                    {
                                        if (rand.Next() % 100 > 50)
                                        {
                                            Matrix[i, j] = rand.Next() % 10;
                                            if (rand.Next() % 100 > 50)
                                                Matrix[j, i] = 0;
                                            else
                                                Matrix[j, i] = Matrix[i, j];
                                        }
                                        else
                                            if (rand.Next() % 100 > 50)
                                        {
                                            Matrix[j, i] = rand.Next() % 10;
                                            Matrix[i, j] = 0;
                                        }
                                        else
                                        {
                                            Matrix[i, j] = 0;
                                            Matrix[j, i] = 0;
                                        }
                                    }
                                }
                            }
                    
                            break;
                        case 1:
                            // rand_Zap_or(a, size);
                            break;
                        default:
                            button1.Text = "Ошибка";
                            break;
                    }
                    break;
                        case 1:
                            switch (checkedListBox2.SelectedIndex)
                            {
                                case 0:
                                    //rand_Zap_vz_nor(a, size);
                                    break;
                                case 1:
                                    //rand_Zap_vz_or(a, size);
                                    break;
                                default:
                            button1.Text = "Ошибка";
                                    break;
                            }

                            break;
                default:
                    button1.Text = "Ошибка";
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = "генерация";
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = "генерация";
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
