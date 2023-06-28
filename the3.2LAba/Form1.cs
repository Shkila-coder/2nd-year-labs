using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The3rdLaba;

namespace the3._2LAba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a, b;
        private int d;
        private Proverka tProv = new Proverka();
        private Result Result = new Result();

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                tProv.a = 0;
                tProv.b = 0;
                Result.d = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror: " + ex.Message);
            }

        }

        private void tbRez_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = tbA.Text;
            if (!double.TryParse(t, out a))
            {
                MessageBox.Show("Ошибка ввода параметра A !");
                tbA.Focus();
            }
            else
            {
                try
                {
                    tProv.a = a;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror: " + ex.Message);
                    tbA.Focus();
                    return;
                }

                MessageBox.Show("Параметр A считан !");
            }

            t = tbB.Text;
            if (!double.TryParse(t, out b))
            {
                MessageBox.Show("Ошибка ввода параметра B !");
                tbB.Focus();
            }
            else
            {
                try
                {
                    tProv.b = b;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror: " + ex.Message);
                    tbA.Focus();
                    return;
                }

                MessageBox.Show("Параметр В считан !");
            }

            t = tbD.Text;
            if(!int.TryParse(t, out d))
            {
                MessageBox.Show("Ошибка ввода параметра D !");
            }
            else
            {
                try
                {
                    Result.d = d;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror: " + ex.Message);
                    tbD.Focus();
                    return;
                }
                MessageBox.Show("Параметр d считан!");
            }

            double Rez = Result.Otvet();

            tbRez.Text = Rez.ToString("F4");

        }
    }
}
