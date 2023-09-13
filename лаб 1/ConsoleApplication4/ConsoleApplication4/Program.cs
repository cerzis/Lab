using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, v, t;
            Console.Write("Введите длину пути");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость");
            v = Convert.ToDouble(Console.ReadLine());
            t = s / v;
            Console.WriteLine("время {0:0.00}", t);
            Console.ReadLine();
        }
    }
}
