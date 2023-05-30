using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K = 0;
            double a, b,t,c,d,m;
            Console.WriteLine("Введите 't'");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 'd'");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 'c'");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 'm'");
            m = Convert.ToDouble(Console.ReadLine());
            a = (Math.Pow(t, 2) + d) / c;
            b = t * Math.Cos(t) - m;
            if (a>5)
            {
                K=Math.Pow(a, 2)+b;
            }
            if (a == 5)
            {
                K = a * Math.Cos(a);
            }
            if (a<5)
            {
                K = a - b;
            }
            Console.WriteLine(a);
            Console.WriteLine(K);
        }
    }
}
