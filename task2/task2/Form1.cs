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

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hello
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
            textBox4.Text = (String.Join(" ", a));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(f);
            string s = r.ReadToEnd();
            textBox4.Text = s;
            r.Close();
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string res = textBox4.Text;
                string[] words = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }
                string result;
                SearchMin(mas, out result);
                textBox3.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string res = textBox4.Text;
                string[] words = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }
                string result;
                SearchMax(mas, out result);
                textBox3.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        static void SearchMin(int[] mas, out string s)
        {
            int temp = mas[1];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i]<temp)
                {
                    temp = mas[i];
                }
            }
            s = Convert.ToString(temp);
        }
        static void SearchMax(int[] mas, out string s)
        {
            int temp = mas[1];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > temp)
                {
                    temp = mas[i];
                }
            }
            s = Convert.ToString(temp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string res = textBox4.Text;
                string[] words = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }

                bool number = true;
                string num = textBox1.Text;
                int num2 = Convert.ToInt32(num);
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == num2)
                    {
                        textBox2.Text = $"Число {num2} под индексом {i}";
                        number = false;
                    }
                }
                if (number)
                {
                    textBox2.Text = "Число не пришло";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string res = textBox4.Text;
                string[] words = res.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }
                BubbleSort(mas);
                int b = Convert.ToInt32(textBox1.Text);
                int k = BinarySearch(mas, b, 0, mas.Length);
                if (k == -1)
                    textBox2.Text = "В данном массиве такого числа нет, попробуйте еще раз!";
                else
                    textBox2.Text = $"Выбранное Вами число массива находится в {k + 1} позиции";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
        static int BinarySearch(int[] a, int b, int L, int R)
        {
            int k = (R + L) / 2;
            int counter = 0;
            while (L < R - 1)
            {
                counter++;
                k = (R + L) / 2;
                if (a[k] == b)
                    return k;
                counter++;
                if (a[k] < b)
                    L = k;
                else
                    R = k;
            }
            if (a[k] != b)
            {
                if (a[L] == b)
                    k = L;
                else
                {
                    if (a[R] == b)
                        k = R;
                    else
                        k = -1;
                };
            }
            return k;
        }
    }
}
