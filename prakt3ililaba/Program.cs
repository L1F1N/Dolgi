using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Pract3mdk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double H = 0;
            double i, y, a;
           
            Console.WriteLine("Введите количество элементов ряда");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 'y'");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 'a'");
            a = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i < n + 1; i++)
            {
                if (i % 2 != 0)
                {
                    double factorial = 1.0;
                    for (int s = 1; s < i+2; s++)
                    {
                        factorial *= s;
                    }
                    H += (0.5*i * y + Math.Pow(Math.Cos(a), i)) / Math.Sin(factorial);
                }
                else
                {
                    double factorial = 1.0;
                    for (int s = 1; s < i+2; s++)
                    {
                        factorial *= s;
                    }
                    H += (y - Math.Pow(Math.Cos(a), i))/Math.Sin(factorial);
                }

            }
            Console.WriteLine(H);
        }
    }
}
