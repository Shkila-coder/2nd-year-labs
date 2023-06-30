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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, h;
            string S,Y,X;
            richTextBox1.Text = null;
            richTextBox2.Text = null;
            richTextBox3.Text = null;
            try
            {
                x1 = Convert.ToDouble(textBox1.Text);
                x2 = Convert.ToDouble(textBox2.Text);
                h = (x2 - x1) / 10.0;
                for (double x = x1; x <= x2; x +=h)
                {
                    X = Convert.ToString(x);
                     Y = Convert.ToString(Math.Round(Class1MyLibrary.MathATan(x), 5));
                     S = Convert.ToString(Math.Round(Class1MyLibrary.MathATan2(x), 5));
                    //richTextBox1.Text = richTextBox1.Text + "При х = " + X + " | Y(x) = " + Y + " | S(x) = " + S + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "При х = " + X + "\r\n" + "-------" + "\r\n";
                    richTextBox2.Text = richTextBox2.Text + "Y(x) = " + Y + "\r\n" + "-------" + "\r\n";
                    richTextBox3.Text = richTextBox3.Text + "S(x) = " + S + "\r\n" + "-------" + "\r\n";
                    
                }
            
            }
            catch
            {
                MessageBox.Show("Неверный формат введенных данных");
                richTextBox1.Text = "Error";
                richTextBox2.Text = "Error";
                richTextBox3.Text = "Error";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
