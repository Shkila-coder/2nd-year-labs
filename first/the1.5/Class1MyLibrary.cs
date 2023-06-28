using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1stStaticClass
{
    public static class Class1MyLibrary
    {


        public static double LinearFunc(double a, double b, double c)
        {
            f = (2 * a * b * (a - b)) / ((a - b) * (a + c));
            return f;
        }


        public static double HowOld(double a)
        {
            m = a % 10;
            if (a < 0)
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
            
            return 0;
            
        }





        public static double MathF(double x1, double x2)
        {
            double h = (x1 - x2) / 10;
            for (double x = x1; x <= x2; x += h)
            {
                Y = Math.Atan(x);
                Console.WriteLine("при x = {0} , Y(x) = {1}", x, Y);
            }

            return 0;
        }
        
        public static double ArraySym(int k)
        {
            int[] arr = new int[k];
            Console.WriteLine("Введите символы");
            for (int i = 0; i < k; i++)
            {
                Console.Write("Введите элемент массива arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            for (int i = 0; i < k; i++)
            {
                if (arr[i] == arr[k - 1 - i])
                {
                    j++;
                }
            }
            if (j == k)
            {
                Console.WriteLine("Массив симметричен");
            }
            else
            {
                Console.WriteLine("Массив не симметричен");
            }
            return 0;
        }
    }
}
