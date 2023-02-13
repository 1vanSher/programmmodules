using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                string str = (string)listBox1.Items[index];
                string[] reverse = str.Split(new char[] { ' ' });
                string item = "";
                item = reverse[reverse.Length - 1];
                reverse[reverse.Length - 1] = reverse[0];
                reverse[0] = item;
                string result = string.Join(" ", reverse);
                listBox1.Items[index] = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
