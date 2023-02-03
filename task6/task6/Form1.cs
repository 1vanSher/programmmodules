using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string operation;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + (sender as Button).Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
                textBox1.Text = $"{textBox1.Text} + ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "i";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                operation = (sender as Button).Text;
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox4.Text = " " + operation;
            }
        }

        public void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
            textBox1.Text = "";
            string [] arr = textBox2.Text.TrimEnd('i').Split(' ');
            string[] arr2 = textBox3.Text.TrimEnd('i').Split(' ');
            Complex d = new Complex(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[2]));
            Complex n = new Complex(Convert.ToInt32(arr2[0]), Convert.ToInt32(arr2[2]));
            if (operation == "+")
            {
               Complex rm = Complex.plus(d, n);
                textBox1.Text = $"{rm.A} + {rm.B}i";
            }
            if (operation == "-")
            {
                Complex rm = Complex.minus(d, n);
                textBox1.Text = $"{rm.A} + {rm.B}i";
            }
            if (operation == "*")
            {
                Complex rm = Complex.umnojit(d, n);
                textBox1.Text = $"{rm.A} + {rm.B}i";
            }
        }
    }

    public class Complex
    {
        public int A;
        public int B;

        public Complex(int a, int b)
        {
            A = a;
            B = b;
        }

        public static Complex plus(Complex A, Complex B)
        {
            return new Complex(A.A + B.A, A.B + B.B);

        }
        public static Complex minus(Complex A, Complex B)
        {
            return new Complex(A.A - B.A, A.B - B.B);

        }
        public static Complex umnojit(Complex A, Complex B)
        {
            return new Complex((A.A * B.A - A.A * B.B), (A.B * B.A + A.A * B.B));
        }
    }
}
