using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Var10
{
    class Program
    {
        static double F(double x)
        {
            return 2*x* Math.Sin(x)-Math.Cos(x);
        }
               static void Main(string[] args)
        {
            Random random = new Random();
            double X = random.Next(4/10);
            double Xlast = random.Next(1);
            double XGrandLast;
            double eps = 0.1;
            Console.WriteLine($"X0 = {X}");
            double dX = double.MaxValue;
            while (Math.Abs(dX) < eps)
            {
                XGrandLast = Xlast;
                Xlast= X;
                X -= F(Xlast) * (Xlast - XGrandLast) / (F(Xlast) - F(XGrandLast));
                dX = X - Xlast;
            }
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"F(x) = {F(X)}");
            Console.ReadKey();
        }
    }
}
