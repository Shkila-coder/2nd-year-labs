using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace the1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов в массиве");
            int k = Convert.ToInt32(Console.ReadLine());
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
            System.Console.ReadKey();
        }
    }
}
