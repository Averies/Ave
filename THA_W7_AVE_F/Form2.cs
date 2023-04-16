using Choosemovie;
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
    public partial class Form2 : Form
    {
        Button[] btnseat = new Button[100];
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < btnseat.Length; i++)
            {
                btnseat[i] = new Button();
                btnseat[i].Text = "";
                btnseat[i].Location = new Point(10 + (i % 10) * 50, 10 + (i / 10) * 30);
                btnseat[i].Size = new Size(40, 20);
                btnseat[i].Click += button_Click;
                btnseat[i].BackColor = Color.Green;
                this.Controls.Add(btnseat[i]);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button tap =sender as Button;
            tap.BackColor = Color.Red;
            tap.Enabled = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
