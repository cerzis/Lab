using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, h, P, S;
            Console.Write("Введите первое основание ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе основание ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту ");
            h = Convert.ToInt32(Console.ReadLine());
            c = (b-a)/2;
            P = 2*c + a + b;
            S = (a + b) /2 * h ;
            Console.WriteLine("Периметр равен {0:0.00}", P);
            Console.WriteLine("Площадь равна {0:0.00}", S);
            Console.ReadLine();



        }
    }
}
