using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using the1._5._1;

namespace the1ndLaba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            try
            {
                int a;
                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Class1MyLibrary.HowOld(a);
            }
            catch
            {
                MessageBox.Show("Неверный формат введенных данных");
                textBox2.Text = "Error";
            }
        }
    }
}
