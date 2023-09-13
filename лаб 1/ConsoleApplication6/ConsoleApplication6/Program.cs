using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, s;
            Console.Write("Введите целое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 100000;
            c = a / 1000 % 10;
            d = a % 10;
            s = b + c + d;
            Console.Write("Сумма равна " + s);
            Console.ReadKey();
        }
    }
}
