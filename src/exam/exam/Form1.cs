using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            if (x * x + y * y < 4  && y<-x && x > -2)
            {
                MessageBox.Show("Точка находится внути закрашенной области");
            }
            else if (x * x + y * y == 4 || y ==-x && x >= -2)
            {
                MessageBox.Show("Точка находится на границе закрашенной области");
            }
            else
            {
                MessageBox.Show("Точка находится ВНЕ закрашенной области");
            }
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            string fil = "";
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            fil = fileDialog.FileName;
            var uri = new Uri(fileDialog.FileName);
            webBrowser1.Navigate(uri);

        }
    }
}
