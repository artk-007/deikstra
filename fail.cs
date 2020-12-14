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
    public partial class fail : Form
    {
        public static string file=" ";
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
        private bool b1=false;
        
        private void button1_Click(object sender, EventArgs e)
        {

            //Folder folder = new Folder();
            //folder.Show();
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "файл Excel (Spisok.xlsx)|*.xlsx";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
               
                fail.file = OPF.FileName;
            }
            if (file != " ")
            {
                Excel.Application ObjWorkExcel = new Excel.Application(); //открыть эксель
                Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(file); //открыть файл
                Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
                int S = Convert.ToInt32(ObjWorkSheet.Rows[1].Columns[1].Text.ToString());
                dataGridView1.RowCount = S;
                dataGridView1.ColumnCount = S;
                deikstra.Size.N = S;
                
                for (int i = 0; i < dataGridView1.RowCount; i++) //по всем колонкам
                    for (int j = 0; j < dataGridView1.ColumnCount; j++) // по всем строкам
                        dataGridView1.Rows[i].Cells[j].Value = Convert.ToInt32(ObjWorkSheet.Rows[i+1].Columns[j+2].Text.ToString());

                ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
                ObjWorkExcel.Quit(); // выйти из экселя
                GC.Collect(); // убрать за собой
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ObjWorkExcel);
                MessageBox.Show("Успешно");
                b1 = true;
            }
            else
                MessageBox.Show("Выберите файл");
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deikstra.Size.Matrix = new int[deikstra.Size.N, deikstra.Size.N];
            if (b1 == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        deikstra.Size.Matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
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
            else
                MessageBox.Show("Выберите файл");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rand.SaveTable(dataGridView1, textBox1);
            MessageBox.Show("сохранено");
        }
    }
}
