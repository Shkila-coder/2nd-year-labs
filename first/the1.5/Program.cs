using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using My1stStaticClass;
namespace the1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите значение переменной a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nРезультат вычисления функции h = " + Class1MyLibrary.LinearFunc(a, b, c));
            
            Console.WriteLine("-----------------------------------------------\n");
           
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите возраст");
            int k = Convert.ToInt32(Console.ReadLine());
            Class1MyLibrary.HowOld(k);
            
            Console.WriteLine("-----------------------------------------------\n");
            
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите x1, x2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nТаблица для X, Y");
            Class1MyLibrary.MathF(x1, x2);

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите количество символов в массиве");
            k = Convert.ToInt32(Console.ReadLine());
            Class1MyLibrary.ArraySym(k);

            Console.ReadKey();






        }
    }
}
