using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The3._3Laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("C:\\Users\\Пользователь\\source\\repos\\the1stC#\\The3.3Laba\\bin\\Debug");
            Object Object = new Object();
            int i = 0;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Выберите номер действия");
                Console.WriteLine("1 - Добавление новой записи");
                Console.WriteLine("2 - Удаление записи");
                Console.WriteLine("3 - Вывод таблицы");
                Console.WriteLine("4 - Сохранение таблицы в файл");
                Console.WriteLine("5 - Показать информацию из файла");
                Console.WriteLine("6 - Считать информацию с файла");
                Console.WriteLine("0 - Выход");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        i++;
                        Object.AddElement(i);
                        break;
                    case "2":
                        Object.Deleteelement();
                        i--;
                        break;
                    case "3":
                        Object.ShowTable();
                        break;
                    case "4":

                        Object.SaveTable();
                        break;
                    case "5":

                        Object.ShowFile();
                        break;
                    case "6":
                        for (int j=0; j < i; j++)
                        {
                            Object.Deleteelement1(1);
                        }
                        Object.ReadFile();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("-----------------------------------------------\n");
                        break;
                    default:
                        Console.WriteLine("Неверный номер");
                        break;

                }

            }
            Console.ReadKey();
        }
    }
}
