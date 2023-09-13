using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s, p, d;
            Console.Write("Введите длину: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину: ");
            b = Convert.ToInt32(Console.ReadLine());
            s = a * b;
            p = (a + b) * 2;
            d = Math.Sqrt(a * a + b * b);
            Console.WriteLine("площадь равна " + s );
            Console.WriteLine("периметр равен " + p);
            Console.WriteLine("диагональ равна {0:0.00}" ,d);
            Console.ReadLine();
        }
    }
}
