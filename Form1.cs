using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeLine_Test_wINDOWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            pipeLineSQLTableBindingSource.AddNew();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pipeLineDataSet._PipeLine_SQLTable' table. You can move, or remove it, as needed.
            this.pipeLine_SQLTableTableAdapter.Fill(this.pipeLineDataSet._PipeLine_SQLTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pipeLine_SQLTableTableAdapter.Update(pipeLineDataSet);
            MessageBox.Show("Data Saved");
            Application.Exit();
            
        }

        private void pipeLine_SQLTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
