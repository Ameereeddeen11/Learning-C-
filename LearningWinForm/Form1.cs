using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LearningWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //obvod ctverce
                int a = int.Parse(textBox1.Text);
                int c = a * 4;
                label3.Text = "Odpoved je " + c;
            }
            else if (radioButton2.Checked)
            {
                //obvod obdelniku
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = 2 * (a + b);
                label3.Text = "Odpoved je " + c;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //obsah ctverce
                int a = int.Parse(textBox1.Text);
                int c = a * a;
                label3.Text = "Odpoved je " + c;
            }
            else if (radioButton2.Checked)
            {
                //obsah obdelniku
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = a * b;
                label3.Text = "Odpoved je " + c;
            }
        }


    }
}
