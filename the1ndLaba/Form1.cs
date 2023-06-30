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
namespace the1ndLaba
{
    public partial class Form1 : Form
    {
        int a,b,c,d = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на открытие 1го окна
            Form2 obj = new Form2();
            a++;
            obj.Show();
            if (a > 1)
            {
                obj.Close();
                a= 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            d++;
            obj.Show();
            if (d > 1)
            {
                obj.Close();
                d = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            b++;
            obj.Show();
            if (b > 1)
            {
                obj.Close();
                b = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            c++;
            obj.Show();
            if (c > 1)
            {
                obj.Close();
                c = 0;
            }
        }


    }
}
