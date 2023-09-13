using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            Console.Write("Введите сторону a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону c ");
            c = Convert.ToDouble(Console.ReadLine());
            d = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
            e = Math.Acos(d) * 180 / Math.PI;
            Console.Write("Угол между сторонами a и b равен " + e);
            Console.ReadKey();

        }
    }
}
