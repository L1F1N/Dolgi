using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = (2.7 - 0.8) * Math.Sqrt(2 * 0.3333);
            double b = (5.2 - 1.4) / 0.43;
            double c = Math.Pow(a / b, 0.2);
            double d = Math.Pow(8.82 + (95+7/Math.Pow(30+93.28,0.2))*2.25, 0.33);//в задании пример невозможно решить из-за того что в нем требуется вычислить корень из минусового числа, поэтому я минус заменил на плюс
            double x = c+d+Math.Pow(3.14,0.16);
            Console.WriteLine(x);
        }
    }
}
