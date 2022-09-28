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

namespace Laboratornai_7
{
    public partial class Form4 : Form
    {
        private double x;
        private double y;
        private double z;
        public Form4(double x, double y, double z)
        {
            InitializeComponent();

            this.x = x;
            this.y = y;
            this.z = z;

            textBox1.Text = "Треугольник со сторонами " + " " + x + " " + y + " " + z + " не существует";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
