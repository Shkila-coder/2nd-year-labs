using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using the1._5._1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace the1ndLaba
{
    public partial class Form5 : Form
    {
        
       
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ввод массива с клавиатуры
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            string text = richTextBox1.Text;
            int N = Int32.Parse(textBox1.Text);
            int[] arr = new int[N];
            string[] sNum = text.Split(' ');
            //MessageBox.Show(Convert.ToString(N));
            //text = text.Replace(System.Environment.NewLine, "@"); //Замена символов "Конец строки" на "@"
            //text = text.TrimEnd(new char[] { '@' });
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(sNum[i]);
                //MessageBox.Show(Convert.ToString(arr[i]));
                //richTextBox1.Text = richTextBox1.Text + Convert.ToString(arr[i]);
            }
            for (int i = 0; i < N; i++)
            {
                MessageBox.Show("arr["+ Convert.ToString(i) + "] = "+ Convert.ToString(arr[i]));
                //richTextBox1.Text = richTextBox1.Text + Convert.ToString(arr[i]);
            }
            if (Class1MyLibrary.ArraySym(N, arr) == true)
            {
                textBox4.Text = "Массив симметричен";
                //Console.Write("Массив симметричен");
            }
            else
            {
                textBox4.Text = "Массив не симметричен";
                //Console.Write("Массив не симметричен");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
