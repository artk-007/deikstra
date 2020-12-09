using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deikstra
{
    static class Program
    {
        
        public static int[] d;
        public static int begin_index;
        public static void alg()
        {
            d = new int[deikstra.Size.N]; // минимальное расстояние
            int[] vis = new int[deikstra.Size.N]; // посещенные вершины
            int temp, minindex, min;
            
            
            
            //Инициализация вершин и расстояний
            for (int i = 0; i < deikstra.Size.N; i++)
            {
                d[i] = 10000;
                vis[i] = 1;
            }
            d[begin_index] = 0;
            // Шаг алгоритма
            do
            {
                minindex = 10000;
                min = 10000;
                for (int i = 0; i < deikstra.Size.N; i++)
                { // Если вершину ещё не обошли и вес меньше min
                    if ((vis[i] == 1) && (d[i] < min))
                    { // Переприсваиваем значения
                        min = d[i];
                        minindex = i;
                    }
                }
                // Добавляем найденный минимальный вес
                // к текущему весу вершины
                // и сравниваем с текущим минимальным весом вершины
                if (minindex != 10000)
                {
                    for (int i = 0; i < deikstra.Size.N; i++)
                    {
                        if (deikstra.Size.Matrix[minindex , i] > 0)
                        {
                            temp = min + deikstra.Size.Matrix[minindex, i];
                            if (temp < d[i])
                            {
                                d[i] = temp;
                            }
                        }
                    }
                    vis[minindex] = 0;
                }
            } while (minindex < 10000);
    
            /*// Вывод кратчайших расстояний до вершин
            printf("\nКратчайшие расстояния до вершин: \n");
            for (int i = 0; i < SIZE; i++)
                printf("%5d ", d[i]);*/
/* кратчайшийи путь
            // Восстановление пути
            int ver[SIZE]; // массив посещенных вершин
            int end = 4; // индекс конечной вершины = 5 - 1
            ver[0] = end + 1; // начальный элемент - конечная вершина
            int k = 1; // индекс предыдущей вершины
            int weight = d[end]; // вес конечной вершины

            while (end != begin_index) // пока не дошли до начальной вершины
            {
                for (int i = 0; i < SIZE; i++) // просматриваем все вершины
                    if (a[i][end] != 0)   // если связь есть
                    {
                        int temp = weight - a[i][end]; // определяем вес пути из предыдущей вершины
                        if (temp == d[i]) // если вес совпал с рассчитанным
                        {                 // значит из этой вершины и был переход
                            weight = temp; // сохраняем новый вес
                            end = i;       // сохраняем предыдущую вершину
                            ver[k] = i + 1; // и записываем ее в массив
                            k++;
                        }
                    }
            }
            // Вывод пути (начальная вершина оказалась в конце массива из k элементов)
            printf("\nВывод кратчайшего пути\n");
            for (int i = k - 1; i >= 0; i--)
                printf("%3d ", ver[i]);
            getchar(); getchar();
            return 0;
        }*/
    }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
