using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratornai_7
{
    public partial class Form2 : Form
    {
        private double a1;
        private double b1;
        private double c1;
        private double d1;

        public Form2(double a1, double b1, double c1, double d1)
        {
            InitializeComponent();

            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.d1 = d1;

            if (a1 > 0 && b1 > 0 && c1 > 0 && d1 > 0)
            {
                textBox15.Text = Convert.ToString(Plo(a1, b1, c1));
                textBox16.Text = Convert.ToString(Plo(a1, b1, d1));
                textBox17.Text = Convert.ToString(Plo(a1, c1, d1));
                textBox18.Text = Convert.ToString(Plo(b1, c1, d1));
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private double Plo(double x, double y, double z)
        {
            double sq = 0;
            if ((y + z - x) > 0 && (x + z - y) > 0 && (x + y - z) > 0)
            {
                sq = (double)Math.Sqrt((((x + y + z) / 2) * ((y + z + x) / 2 - x) * ((y + z + x) / 2 - y) * ((y + z + x) / 2 - z)));
            }
            else
            {
                Form4 form4 = new Form4(x, y, z);
                form4.Show();
            }
            return sq;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
