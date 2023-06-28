using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            double x1, x2, h ,S, Y ,f;
            
            //Таблица значений функции 
            Console.WriteLine("Пункт 1");
            Console.WriteLine("Введите x1, x2");
            s = Console.ReadLine();
            x1 = Convert.ToDouble(s);
            s = Console.ReadLine();
            x2 = Convert.ToDouble(s);

            h = (x2 - x1) / 10;

            for (double x = x1; x <= x2; x += h)
            {
                Y = Math.Atan(x);
                Console.WriteLine("при x = {0} , Y(x) = {1}", x, Y);
            }
            
            //Разложение функции в ряд
            Console.WriteLine();
            Console.WriteLine("Пункт 2");
            
            int i, N, n;
            N = 15;

            for (double x = x1; x <= x2; x += h)
            {
                S = 0;
                for (n = 0; n <= N; n++)
                {
                    S = S + Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                }
                Console.WriteLine("при x = {0} , S(x) = {1}", x, S);
            }

            //оптимизация без вложенных циклов и Pow
            Console.WriteLine();
            Console.WriteLine("Пункт 3");
            for (double x = x1; x <= x2; x += h)
            {
                double xn = x;
                fn = 2 * n + 1;
                S = -x;
                int c = -1;
                for (n = 1; n <= N; n++)
                {
                    xn = xn * x * x;
                    fn = fn * (2 * n + 1) ;
                    S = S + c * xn / fn;
                    c = -c;
                }
            }

            Console.ReadKey();
        }
    }
}
