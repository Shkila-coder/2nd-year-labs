using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            double k, m;

            Console.WriteLine("Введите возраст");
            s = Console.ReadLine();
            k = Convert.ToDouble(s);
            m = k % 10;
            // Console.WriteLine(m);
            if (k < 0)
            {
                Console.WriteLine("Ты еще не родился");
            }
            else
            {
                if (m == 1)
                {
                    Console.WriteLine("Мне " + k.ToString() + " год");
                }
                else if (m == 2 || m == 3 || m == 4)
                {
                    Console.WriteLine("Мне " + k.ToString() + " года");
                }
                else
                {
                    Console.WriteLine("Мне " + k.ToString() + " лет");
                }
            }
            System.Console.ReadKey();
        }
    }
}
