using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double H=0;
            double x, u, y, Bk,i, B0, bshag;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B0");
            B0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Bk");
            Bk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите bshag");
            bshag = Convert.ToDouble(Console.ReadLine());
            for (i=B0; i<Bk;i=i+bshag)
            {
                H=x*Math.Cos(u)-Math.Pow(y,u)-(Math.Sqrt(Math.Pow(u,2)+i*Math.Cos(i)))/Math.Tan(i);
            }
            Console.WriteLine(H);
        }
    }
}
