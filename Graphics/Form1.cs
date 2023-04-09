using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            
            double b = 3.4;

            int count = (int)Math.Ceiling(Math.Abs((Xmax - Xmin) / Step) + 1 );
            double[] x = new double[count];
            double[] y = new double[count];
            
            
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = x[i] * Math.Sin(Math.Sqrt(x[i] + b - 0.0084));
                

            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmax;
            chart1.ChartAreas[0].AxisX.Maximum = Xmin;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = -Step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}
