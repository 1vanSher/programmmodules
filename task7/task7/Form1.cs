using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.MaxLength = 30;
        }
        string[] a = new string[10];
        double[] num = new double[10];
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToString(r.Next(-10, 11));
                }
                textBox2.Text = (String.Join(" ", a));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] words = textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = Convert.ToDouble(words[i]);
                }
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] < 0)
                    {
                        num[i] = Math.Pow(num[i], 3);
                    }
                    else
                    {
                        num[i] = Math.Pow(num[i], 2);
                    }                        
                }
                textBox1.Text = (String.Join(" ", num));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
