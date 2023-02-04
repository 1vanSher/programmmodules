using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SalaryEmployees> salary = new List<SalaryEmployees>();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = textBox1.Text.Split(' ');
            salary.Add(new SalaryEmployees(arr[0], arr[1], arr[2], comboBox1.Text, Convert.ToInt32(textBox2.Text)));
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(SalaryEmployees i in salary)
            {
                if (i.salary % 3 == 0)
                {
                    listBox1.Items.Add(i.salary);
                }
            }
        }
    }

    public class SalaryEmployees
    {
        private string name;
        private string surname;
        private string patronymic;
        private string post;
        private int salary;

        public SalaryEmployees(string Name, string Surname, string Patronymic, string Post, int Salary)
        {
            name = Name;
            surname = Surname;
            patronymic = Patronymic;
            post = Post;
            salary = Salary;
        }


    }
}
