using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Test()
        {
            Console.WriteLine("Ввести значение радиуса: "); // Main вызывается по умолчанию программы, какие бы и сколкьо бы класс
            double r = Convert.ToDouble(Console.ReadLine()); // то, что в мэйн можно было вынести в класс и назвать
            Console.WriteLine("Ввести значение угла: ");// а название вписать в статик войд мэйн
            double angle = Convert.ToDouble(Console.ReadLine());

            Sector sample = new Sector(r, angle);
            double s = sample.sqrSector();

            Console.WriteLine("Площадь сектора равна {0}", s);
        }
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }
    }
    public class Sector // описание класса
    {
        public double r, angle; // говорю о наличии этих переменных
        public Sector (double r, double angle) // конструктор. он поясняет классу, что переменные р и англ, которые я 
        {
            this.r = r;// ввел вручную, являются теми самыми переменными,  которые я обозначил чуть выше
            this.angle = angle;
        }
       public double sqrSector() //метод класса
        {
            return ((Math.PI * Math.Pow(r, 2)) / 360) * angle;// формула по которой вычисляется площадь сектора круга
        }
 
    }

}
