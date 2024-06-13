using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Расчёты_в_астрофизике
{
    public partial class Form5 : Form
    {
        Thread h;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || (int)e.KeyChar == ','))
                e.KeyChar = (char)0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p = double.Parse(textBox3.Text);
            textBox1.Text = textBox3.Text;
            textBox4.Text = (Math.Round((3.26 / p), 2)).ToString();
            textBox2.Text = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "?";
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
