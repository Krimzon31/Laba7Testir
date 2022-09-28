using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornai_7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            textBox20.Text = "Ошибка введено отрицательное значение отрезка";
        }

        private void Form3_Load(object sender, EventArgs e)
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
