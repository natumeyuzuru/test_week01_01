using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大地椭球坐标转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double x = double.Parse(textBox4.Text);
            //double y = double.Parse(textBox5.Text);
            //double z = double.Parse(textBox6.Text);
            double h = double.Parse(textBox3.Text);
            double l = double.Parse(textBox2.Text);
            double b = double.Parse(textBox1.Text);
            double x, y, z;
            b = b * Math.PI / 180;
            l = l * Math.PI / 180;
            double n = ComputeN(b);
            x = (n + h) * Math.Cos(b) * Math.Cos(l);
            y = (n + h) * Math.Cos(b) * Math.Sin(l);
            z = (n * (1 - ComputeE2()) + h) * Math.Sin(b);
            textBox4.Text = x.ToString();
            textBox5.Text = y.ToString();
            textBox6.Text = z.ToString();
        }
        public  static double ComputeE2()
        {
            double f = 1 / 298.257;
            return 2 * f - f * f;
        }
        public static double ComputeN(double b)
        {
            double a = 6738137;
            double sinb = Math.Sin(b);
            double w = Math.Sqrt(1 - ComputeE2() * sinb * sinb);
            return a / w;
        }

       
    }
}
