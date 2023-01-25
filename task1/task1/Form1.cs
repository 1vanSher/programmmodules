using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string path = "C:\\Users\\Public\\text.txt";
        string[] a = new string[10];
        int[] mas = new int[10];
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToString(r.Next(0, 20));
            }
            textBox1.Text = (String.Join(" ", a));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(f);
            string s = r.ReadToEnd();
            textBox1.Text = s;
            r.Close();
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var stopWatch = Stopwatch.StartNew();
                string res = textBox1.Text;
                string[] words = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }
                BubbleSort(mas);

                textBox3.Text = (String.Join(" ", mas));

                stopWatch.Stop();
                textBox2.Text = stopWatch.ElapsedMilliseconds.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.BackColor = Color.Blue;
                button3_Click(sender, e);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

    }
}
