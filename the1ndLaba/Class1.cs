using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the1._5._1
{
    internal class Class1MyLibrary
    {
        public static double LinearFunc(double a, double b, double c)
        {
            double f = (2 * a * b * (a - b)) / ((a - b) * (a + c));
            return f;
        }


        public static string HowOld(int a)
        {
            string s;
            double m = a % 10.0;
            if (a > 150)
            {
                s = "Ты еще жив?";
            }
            else if (a < 0)
            {
                s = "Ты еще не родился";
            }
            else if ((a > 10) && (a < 15))
            {
                s = "Мне " + a.ToString() + " лет";
            }
            else
            {
                if (m == 1)
                {
                    s = "Мне " + a.ToString() + " год";
                }
                else if (m == 2 || m == 3 || m == 4)
                {
                    s = "Мне " + a.ToString() + " года";
                }
                else
                {
                    s = "Мне " + a.ToString() + " лет";
                }
            }

            return s;

        }


        public static double MathATan(double x1)
        {
            double Y = Math.Atan(x1);
            return Y;
        }
        public static double MathATan2(double x1)
        {
            double n = 0.0, N = 15.0;
            double xn = x1;
            double fn = 2 * n + 1;
            double S = -x1;
            int c = 1;
            for (n = 1; n <= N; n++)
            {
                xn = xn * x1 * x1;
                fn = fn * (2 * n + 1);
                S = S + c * xn / fn;
                c = -c;
            }
            //double Y = Math.Atan(x1);
            return -S;
        }
        

        public static bool ArraySym(int k, int[] arr)
        {
           
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
