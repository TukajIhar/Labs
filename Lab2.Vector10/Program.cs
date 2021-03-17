using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2Vector10
{
    class Program
    {
        static StreamReader файлIn = new StreamReader("Inlet.in");
        static StreamWriter файлOut = new StreamWriter("outlet.out");

        static void Main(string[] args)
        {
            int N, B;
            int[] A;
            int[] C;
            вводДанных(out N,out B, out C, out A);
            string строкаР = "";
            выводРезультата(B, A, C, строкаР);
        }
        static void вводДанных(out int N, out int B, out int [] C, out int[] A)
        {
            string строкаВвода = файлIn.ReadLine();
            string[] аргумент = строкаВвода.Split(' ');
            N = Convert.ToInt16(аргумент[0]); //Int16.Parse(аргумент[0]);
            B = Int16.Parse(аргумент[1]);
            C = new int[] { 1, 2, 3 };
            A = new int[N];

            string arraynumbers = файлIn.ReadLine();
            string[] arrayA = arraynumbers.Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = Int16.Parse(arrayA[i]);
            }
            файлIn.Close();
        }
        static void выводРезультата(int B, int[] A, int[] C, string строкаР)

        {

            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < C.Length; j++)
                    if (A[i] % B == C[j])
                        строкаР += Convert.ToString(A[i]) + " ";

            файлOut.Write(строкаР);
            файлOut.Close();

        }
       
    }
}
 