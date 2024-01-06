using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        // Create a DataTable to store data
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create table with 3 columns (Date, Title, Content)
            dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Title", typeof(String));
            dt.Columns.Add("Content", typeof(String));

            // Connect to table to dataGridView
            dataGridView.DataSource = dt;

            // unvisible column "Context"
            dataGridView.Columns["Content"].Visible = false;

            // Set width for column "Date" and "Title"
            dataGridView.Columns["Date"].Width = 127;
            dataGridView.Columns["Title"].Width = 127;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            name.Clear();
            content.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(DateTime.Now, name.Text, content.Text);
            name.Clear();
            content.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            if (index >= 0)
            {
                dt.Rows[index].Delete();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            if (index >= 0)
            {
                name.Text = dt.Rows[index].ItemArray[1].ToString();
                content.Text = dt.Rows[index].ItemArray[2].ToString();
            }
        }
    }
}
