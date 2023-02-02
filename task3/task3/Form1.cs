using System;
using System.Numerics;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public BigInteger Factorial(int fak)
        {
            if (fak == 1) return 1;

            return fak * Factorial(fak - 1);
        }
    }
}
