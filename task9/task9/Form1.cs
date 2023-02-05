using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<basic> volume = new List<basic>();
        List<basic> res = new List<basic>();
        private void button1_Click(object sender, EventArgs e)
        { 
            volume.Add(new basic(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
            listBox1.Items.Add($"{textBox1.Text} {textBox2.Text} {textBox3.Text}");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null) 
            {
                string[] arr = listBox1.SelectedItem.ToString().Split(' ');
                double result = basic.volume(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
                volume.Add(new child(textBox4.Text, Convert.ToInt32(comboBox1.Text), result));
                listBox2.Items.Add($"{textBox4.Text} {comboBox1.Text} {result}");
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0;
            string[] arr = listBox2.SelectedItem.ToString().Split(' ');
            if (Convert.ToDouble(arr[1]) == 1)
            {
                 result = Convert.ToDouble(arr[2]) * 0.3;
            }else if(Convert.ToDouble(arr[1]) == 2)
            {
                 result = Convert.ToDouble(arr[2]) * 0.6;
            }else if (Convert.ToDouble(arr[1]) == 3)
            {
                 result = Convert.ToDouble(arr[2]);
            }
            textBox6.Text = Convert.ToString(result / Convert.ToInt32(textBox5.Text)) + " помесятятся в базовом объеме";
            textBox5.Text = "";

        }
    }

    public class basic
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public basic()
        {

        }

        public basic(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        static public double volume(double height, double width, double length)
        {
            double result = height * width * length;
            return result;
        }

    }

    public class child : basic
    {
        public string Name;
        public int Koef;
        public double Vol;

        public child(double height, double width, double length, string name, int koef, double vol)
        {
            Height = height;
            Width = width;
            Length = length;
            Name = name;
            Koef = koef;
            Vol = vol;
        }
        public child(string name, int koef, double vol)
        {
            Name = name;
            Koef = koef;
            Vol = vol;
        }
    }
}
