using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int fak = Convert.ToInt32(textBox1.Text);
                string factorial = Convert.ToString(Factorial(fak));
                textBox2.Text = factorial;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int Factorial(int fak)
        {
            if (fak == 1) return 1;

            return fak * Factorial(fak - 1);
        }
    }
}
