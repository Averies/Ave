using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_AVE_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void comboTime()
        {
            comboBoxtime.Items.Add("Pk. 13.00");
            comboBoxtime.Items.Add("Pk. 16.00");
            comboBoxtime.Items.Add("Pk. 19.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
