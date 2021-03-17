using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1Var10
{
    class Program
    {
        static long Fact (long value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите eps");
            double eps = double.Parse(Console.ReadLine());
            double s = 0 ; 
            double z = 0 ; 
            int n = 0; 
          
            while (z < eps)
            {
                z = Math.Pow(-1, n)*(Math.Pow(x, 2*n)/Fact (2*n));
                s = s + z;
                n++;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
