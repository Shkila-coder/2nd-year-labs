using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace The3._3Laba
{
    class Object
    {
        private static DataTable complexesTable;

        public Object()
        {
            complexesTable = new DataTable("Object");
            complexesTable.Columns.Add("Номер записи", typeof(string));
            complexesTable.Columns.Add("| Емкость (в байтах/МегаБайтах)", typeof(string));
            complexesTable.Columns.Add("| Объем занятой памяти (в байтах/МегаБайтах)", typeof(string));
            complexesTable.Columns.Add("| Количество байт в мегабайте", typeof(string));
            complexesTable.Columns.Add("| Процент заполнения памяти", typeof(string));
        }
        //    private double container, volume;
       //     double stand = 1048576;
       public void AddElement(int a)
        {

            DataRow row = complexesTable.NewRow();
            int number = a;
            row["Номер записи"] = number;

            Console.WriteLine("Введите емкость (в байтах):");
            int container = int.Parse(Console.ReadLine());
            double container2 = Convert.ToDouble(container) / 1048576.0;
            row["| Емкость (в байтах/МегаБайтах)"] = "| " + Convert.ToString(container) + " ( " + Convert.ToString(Math.Round(container2, 2)) + " )" ;

            Console.WriteLine("Введите объем занятой памяти (в байтах):");
            int volume = int.Parse(Console.ReadLine());
            double volume2 = Convert.ToDouble(volume) / 1048576.0;
            row["| Объем занятой памяти (в байтах/МегаБайтах)"] = "| " + Convert.ToString(volume) + " ( " + Convert.ToString(Math.Round(volume2, 2)) + " )";

            //Console.WriteLine("Введите количество запасов воздуха:");
            int stand = int.Parse(Convert.ToString(1048576));
            row["| Количество байт в мегабайте"] = "| " + Convert.ToString(stand);


            //Console.WriteLine("Введите Процент заполнения памяти:");
            //double percent = double.Parse(Console.ReadLine());
            //row["Расход воздуха на 1 человека в сутки"] = percent;

            double percent = (Convert.ToDouble(volume) / Convert.ToDouble(container)) *100;
            row["| Процент заполнения памяти"] = "| " + Convert.ToString(Math.Round(percent, 2)) + '%' ;

            complexesTable.Rows.Add(row);

            Console.WriteLine("Запись добавлена.");
        }

        public void Deleteelement()
        {
            Console.WriteLine("Введите номер записи для удаления:");
            int index = int.Parse(Console.ReadLine());
            complexesTable.Rows.RemoveAt(index - 1);

            Console.WriteLine("Запись удалена.");
        }

        public void Deleteelement1(int j)
        {
            int index = int.Parse(Convert.ToString(j));
            complexesTable.Rows.RemoveAt(index - 1);

            //Console.WriteLine("Запись удалена.");
        }


        public void ShowTable()
        {
            Console.WriteLine("Таблица устройств:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            // Определяем форматирование для каждого столбца
            var format = "{0,-15}{1,-35}{2,-45}{3,-35}{4,-35}";

            // Выводим заголовки столбцов
            Console.WriteLine(format, complexesTable.Columns[0].ColumnName,
                complexesTable.Columns[1].ColumnName, complexesTable.Columns[2].ColumnName,
                complexesTable.Columns[3].ColumnName, complexesTable.Columns[4].ColumnName);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        
            // Выводим каждую запись соответствующим образом
            foreach (DataRow row in complexesTable.Rows) Console.WriteLine(format, row[0], row[1], row[2], row[3], row[4]);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void SaveTable()
        {
            /*Console.WriteLine("Введите путь к файлу: ");
            var path = Console.ReadLine();*/

            FileStream fs = new FileStream(@"C:\Users\Пользователь\source\repos\the1stC#\The3.3Laba\bin\Debug\table.txt", FileMode.Create);
            StreamWriter Table = new StreamWriter(fs);
            /*Console.WriteLine("Введите путь к файлу: ");
             var path = Console.ReadLine();*/
            try
            {

                var delimiter = "";

                // Создаем строку заголовка таблицы
                var header =
                    string.Join(delimiter, complexesTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName)) +
                    Environment.NewLine;

                // Создаем строки с данными
                var data = "";
                foreach (DataRow row in complexesTable.Rows) data += string.Join(delimiter, row.ItemArray) + Environment.NewLine;

                // Сохраняем таблицу в файл
                //Table.Write(header);
                //Table.WriteLine();
                Table.Write(data);
                Table.Close();
                fs.Close();
                Console.WriteLine(@"Таблица сохранена в файл \C:\\Users\\Пользователь\\source\\repos\\the1stC#\\The3.3Laba\\bin\\Debug\\table.txt\");
            }
            catch
            {
                Console.WriteLine("Ошибка при сохранении файла!");
            }
        }

        public void ShowFile()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Пользователь\source\repos\the1stC#\The3.3Laba\bin\Debug\table.txt");
            string s;
            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();

                Console.WriteLine(s);
            }
            sr.Close();
        }
        public void ReadFile()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Пользователь\source\repos\the1stC#\The3.3Laba\bin\Debug\table.txt");
            string s;
            int a = 1;
            while (sr.EndOfStream != true)
            {
                
                string str="";
                s = sr.ReadLine();
                int N = s.Count();
                //Console.WriteLine(N);
                string[] arr = new string[5];
                string[] sNum = s.Split('|');
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = sNum[i];
                    str = str + arr[i];
                    //Console.WriteLine(arr[i]);
                    //Console.WriteLine(str);
                }
                sNum = str.Split(' ');
                N = sNum.Count();
                //for (int i = 0; i < N; i++)
                //{
                    //Console.WriteLine(sNum[i]);
                    //1 - 1 столбик
                    //5 - 2 столбик
                    //9 - 3 столбик
                //}
               // Console.WriteLine(s);
                //Console.WriteLine(sNum);


                DataRow row = complexesTable.NewRow();
                int number = a;
                row["Номер записи"] = number;

                //Console.WriteLine("Введите емкость (в байтах):");
                int container = int.Parse(sNum[1]);
                double container2 = Convert.ToDouble(container) / 1048576.0;
                row["| Емкость (в байтах/МегаБайтах)"] = "| " + Convert.ToString(container) + " ( " + Convert.ToString(Math.Round(container2, 2)) + " )";

                //Console.WriteLine("Введите объем занятой памяти (в байтах):");
                int volume = int.Parse(sNum[5]);
                double volume2 = Convert.ToDouble(volume) / 1048576.0;
                row["| Объем занятой памяти (в байтах/МегаБайтах)"] = "| " + Convert.ToString(volume) + " ( " + Convert.ToString(Math.Round(volume2, 2)) + " )";

                //Console.WriteLine("Введите количество запасов воздуха:");
                int stand = int.Parse(Convert.ToString(1048576));
                row["| Количество байт в мегабайте"] = "| " + Convert.ToString(stand);

                double percent = (Convert.ToDouble(volume) / Convert.ToDouble(container)) * 100;
                row["| Процент заполнения памяти"] = "| " + Convert.ToString(Math.Round(percent, 2)) + '%';

                complexesTable.Rows.Add(row);
                a++;
            }
            a = 0;
            ShowTable();
            sr.Close();

        }

    }
}
