using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ctverec = radioButton1.Checked;
            bool obdelnik = radioButton2.Checked;
            bool obsah = radioButton3.Checked;
            bool obvod = radioButton4.Checked;
            
            
            switch (ctverec)
            {
                case true:
                    switch (obsah)
                    {
                        case obsah:
                            int a = ((int)numericUpDown1.Value);
                            int c = a * a;
                            label3.Text = "Obsah ctverce je " + c;
                            break;
                        case false:
                            int
                    }
                break;

                case false:
                    int z = ((int)numericUpDown1.Value);
                    int b = ((int)numericUpDown2.Value);
                    int q = z * b;
                    break;

                default:
                    label3.Text = "neco jste spatne udelal";
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
