using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// См.сайт:  https://blog.foolsoft.ru/c-datagridview-i-primery-raboty-s-nim/

namespace MyClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Список-Хранилище объектов
        //BindingList - это специальный список List
        //с вызовом события обновления внутреннего состояния,
        //необходимого для автообновления datagridview
        private BindingList<SampleRow> data;

        private void Form1_Load(object sender, EventArgs e)
        {

            //Создание пустого Хранилища
            data = new BindingList<SampleRow>(); 

            //Создание Объектов и сохранение их в Хранилище
            data.Add(new SampleRow("Товар 1", 100, 1));
            data.Add(new SampleRow("Товар 2", 200, 2));
            data.Add(new SampleRow("Товар 3", 300, 3));

            //Привязка Хранилища к dataGridView1
            dataGridView1.DataSource = data;

            //Настройка dataGridView1
            dataGridView1.Width = 250; //Ширина 

            //Настройка колонок
            var column1 = dataGridView1.Columns[0];
            column1.HeaderText = "Название"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "Name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип колонки

            var column2 = dataGridView1.Columns[1];
            column2.HeaderText = "Цена";
            column2.Width = 50;
            column2.Name = "Price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = dataGridView1.Columns[2];
            column3.HeaderText = "Остаток";
            column2.Width = 50;
            column3.Name = "Count";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            //Назначаем метода-обработчика изменения значения ячейки "Цена"
            dataGridView1.CellValueChanged += CellValueChanged;

            //Принудительный вызов обрабочика для отрисовки цвета строк
            CellValueChanged(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Price = 0.0f;
            int Count = 0;
            string Name = tbName.Text.Trim(); //Обрезка ведущих и хвостовых пробелов

            try
            {
                Price = float.Parse(tbPrice.Text);
                Count = Int32.Parse(tbCount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Добавляем в Хранилище новый объект
            data.Add(new SampleRow(Name, Price, Count));

            //Принудительный вызов обрабочика для перерисовки цвета строк
            CellValueChanged(null, null);
        }

        /// <summary>
        /// Метод-обработчик отрисовки цвета строк dataGridView1
        /// Должен вызываться при изменении состава строк или изменении цены любого объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e == null || e.ColumnIndex == 1) //Изменилась цена - переопределить цвет
            {
                //Ищем Объект и строку с максимальной ценой
                float maxPrice = 0.0f;
                int maxRow = -1;
                for (int i = 0; i < data.Count; i++)
                    if (data[i].Price > maxPrice)
                    {
                        maxPrice = data[i].Price;
                        maxRow = i;
                    }
                // Изменение цвета строк
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == maxRow)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                    else
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }
            }
        }
        /// <summary>
        /// Удаление выбранной строки данных и Объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDel_Click(object sender, EventArgs e)
        {
            //Номер выбранной строки
            int selRowNum = dataGridView1.SelectedCells[0].RowIndex;
            if (MessageBox.Show("Удалить " + dataGridView1[selRowNum, 0].Value+" ?", "Удаление данных", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Удаляем выбранный объект из Хранилища
                data.RemoveAt(selRowNum);
                //Принудительный вызов обрабочика для перерисовки цвета строк
                CellValueChanged(null, null);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            tbName.Text = data[iRow].Name;
            tbPrice.Text=data[iRow].Price.ToString();
            tbCount.Text=data[iRow].Count.ToString();
        }

        private void btReadXML_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xmlFile = openFileDialog1.FileName;
                data = XMLClass.ReadFromXmlFile<BindingList<SampleRow>>(xmlFile);
                //Привязка Хранилища к dataGridView1
                dataGridView1.DataSource = data;

                //Принудительный вызов обрабочика для перерисовки цвета строк
                CellValueChanged(null, null);

                this.Text = "Работа с Объектами " + xmlFile;
            }
        }

        private void btWriteXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                XMLClass.WriteToXmlFile<BindingList<SampleRow>>(saveFileDialog1.FileName, data);
        }
    }
}
