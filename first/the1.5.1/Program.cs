using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using the1._5._1;
namespace the1._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            while (N != 0)
            {
                Console.WriteLine("Выберите номер задания");
                Console.WriteLine("1 - Задание 1");
                Console.WriteLine("2 - Задание 2");
                Console.WriteLine("3 - Задание 3");
                Console.WriteLine("4 - Задание 4");
                Console.WriteLine("0 - Выход");
                N = Convert.ToInt32(Console.ReadLine());
                switch (N)
                {
                    case 1:
                        Console.WriteLine("Задание 1");
                        Console.WriteLine("Введите значение переменной a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение переменной b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение переменной c:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nРезультат вычисления функции h = " + Class1MyLibrary.LinearFunc(a, b, c));
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("Задание 2");
                        Console.WriteLine("Введите возраст");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Class1MyLibrary.HowOld(k));
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    case 3:
                        Console.WriteLine("Задание 3");
                        Console.WriteLine("Введите x1, x2");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        double h = (x2 - x1) / 10.0;
                        Console.WriteLine("\nТаблица для X, Y");
                        for (double x = x1; x <= x2; x += h)
                        {
                            double Y = Class1MyLibrary.MathATan(x);
                            double S = Class1MyLibrary.MathATan2(x);
                            Console.WriteLine("при x = {0} , Y(x) = {1} , S(x) = {2}", x, Y, S);
                        }
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    case 4:
                        Console.WriteLine("Задание 4");
                        Console.WriteLine("Введите количество символов в массиве");
                        k = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[k];
                        Console.WriteLine("Введите символы");
                        for (int i = 0; i < k; i++)
                        {
                            Console.Write("Введите элемент массива arr[{0}] = ", i);
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        if (Class1MyLibrary.ArraySym(k, arr) == true)
                        {
                            Console.Write("Массив симметричен");
                        }
                        else
                        {
                            Console.Write("Массив не симметричен");
                        }
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    case 0:
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    default:
                        Console.WriteLine("Неверный номер задания");
                        break;
                }
            }
            
            //выбор задания через swich
            
            /*Console.WriteLine("Задание 1");
            Console.WriteLine("Введите значение переменной a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nРезультат вычисления функции h = " + Class1MyLibrary.LinearFunc(a, b, c));*/

           
            /*Console.WriteLine("Задание 2");
            Console.WriteLine("Введите возраст");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Class1MyLibrary.HowOld(k));*/



            /*Console.WriteLine("Задание 3");
            Console.WriteLine("Введите x1, x2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            double h = (x2 - x1) / 10.0;
            Console.WriteLine("\nТаблица для X, Y");
            for (double x = x1; x <= x2; x += h)
            {
                double Y = Class1MyLibrary.MathATan(x);
                double S = Class1MyLibrary.MathATan2(x);
                Console.WriteLine("при x = {0} , Y(x) = {1} , S(x) = {2}", x, Y, S);
            }*/
            
         
           /* Console.WriteLine("Задание 4");
            Console.WriteLine("Введите количество символов в массиве");
            k = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine("Введите символы");
            for (int i = 0; i < k; i++)
            {
                Console.Write("Введите элемент массива arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (Class1MyLibrary.ArraySym(k, arr) == true)
            {
                Console.Write("Массив симметричен");
            }
            else
            {
                Console.Write("Массив не симметричен");
            }*/

            Console.ReadKey();
        }
    }
}
