using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt1.Text != string.Empty && txt2.Text != string.Empty) { 
                dataGridView1.Rows.Add(txt1.Text, txt2.Text, DateTime.Now);

                txt1.Clear();
                txt2.Clear();
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
