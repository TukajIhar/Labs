using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2Var10
{
    class Program
    {
               static void Main(string[] args)
        {
            Console.WriteLine("Введите eps"); 
            double eps = double.Parse(Console.ReadLine());
            double s = 0; 
            double z = 1; 
            int n = 0;
                       
            while (z > eps)
            {
                z = 1/(Math.Pow(2*n+1,2));
                s += z;
                n++;
            } 
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
