using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Matrix
{
   
    class Program
    {
            static StreamReader filein = new StreamReader("Inlet1.in");
            static StreamWriter fileout = new StreamWriter("Outlet1.out");

        static void Main(string[] args)
        {
            int G, P;
            double N;
            вводДанных(out N, out G, out P);

             
        }
        static void вводДанных(out double N, out int G, out int P )
        {
            string строкаВвода = filein.ReadLine();
            string[] element = строкаВвода.Split(' ');
           N = Double.Parse(element[0]); // N привели как дабл, чтобы использовать метод Math.Ceiling
           G = Int16.Parse(element[1]);
           P = Int16.Parse(element[2]);

           int [,] array = new int[Convert.ToInt32(N), Convert.ToInt32(N)];


            for (int z = 0; z < Math.Ceiling(N / 2); z++) /* этот метод и цикл используем, чтобы определить сколько квадратов есть 
                                                           * внутри матрицы. Если, например размер массива 6*6, то количество квадратов будет 3
                                                           * а метод сейлинг округляет к меньшему целому значению (тк 5 делится на 2 с остатком)
                                                           */
                
            {
                for (int i = z; i < N-z; i++)  //Далее используем цикл, чтобы пройти по всем i (строки матрицы)                                             * 
                                             
                {

                    
                        for (int j = z; j < N - z; j++) 
                            array[i, j] = G;                // после первой итерации весь массив будет заполнен двойками.
                                                             
                    


                                               /* И если i  равно z, где z - 0 (нулевой индекс) - то есть первая сстрока массива (матрицы), или равно  N-z, которое 
                                                * показывает индекс последней строки массива (матрицы), тогда 
                                                *  if (i == z || i == N - z) 
                                                * if (i > z && i < N - z)
                                                */
                }
                G += P;
            }

                                                                 /* Сейчас нужно записать двумерный массив в файл.
                                                                  * для этого создаем пустую строку, а затем цикл, который проходится по граням квадратов
                                                                  * и после первой итерации заполняет массив одинаковыми значениями, а затем, "отрубает" лишние значения 
                                                                  * (которые должны остаться неизменными по условию), и так на каждой итерации
                                                                  */
            string s ="";
             for (int i = 0; i<=N-1; i++) 
            {
                for (int j = 0; j <=N-1; j++)
                {
                    s += Convert.ToString(array[i, j]) + " "; 
                }
                fileout.WriteLine(s);
                s = "";            
            }
             


           fileout.Close();
        }
    }
}
