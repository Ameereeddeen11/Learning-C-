using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsah_a_obvod_kruznice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    double r = int.Parse(textBox1.Text);
                    double s = Math.PI * Math.Round(r, 2);
                    label2.Text = "obsah kruznice je " + s;
                }
                catch
                {
                    label2.Text = "zadejte cislo";
                }

            }
            else if(radioButton2.Checked)
            {
                try 
                { 
                    double r = int.Parse(textBox1.Text);
                    double o = Math.PI * 2 * r;
                    label2.Text = "obvod kruznice je " + o;
                }
                catch
                {
                    label2.Text = "zadejte cislo";
                }
            }
        }
    }
}
