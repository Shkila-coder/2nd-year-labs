using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            double a, b, c, f;
            Console.WriteLine("Введите a");
            s = Console.ReadLine();
            a = Convert.ToDouble(s);

            Console.WriteLine("Введите b");
            s = Console.ReadLine();
            b = Convert.ToDouble(s);

            Console.WriteLine("Введите c");
            s = Console.ReadLine();
            c = Convert.ToDouble(s);
            
            f = (2 * a * b * (a - b)) / ((a - b) * (a + c));
            Console.WriteLine("значение f по формуле : " + f.ToString());
            Console.ReadKey();
            

        }
    }
}
