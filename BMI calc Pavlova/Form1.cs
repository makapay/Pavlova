using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calc_Pavlova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rost = Convert.ToDouble(textBox1.Text) / 100;
            double ves = Convert.ToDouble(textBox2.Text);
            int BMI = Convert.ToInt32( ves / (rost * rost));
            table10.text = BMI.ToString();
            if (BMI < 10)
            { trackBar1.Value = Convert.ToInt32(BMI); lable3.text =  }
        }

    }
}
