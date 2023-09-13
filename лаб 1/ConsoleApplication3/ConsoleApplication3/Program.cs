using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, S, K, L;
             Console.Write("Введите длину пути ");
            S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расход на 100км ");
            L = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену за литр ");
            K = Convert.ToDouble(Console.ReadLine());
            a = L / 100;
            b = a * K;
            Console.Write("Цена поездки " + S*b);
            Console.ReadLine();

        }
    }
}
