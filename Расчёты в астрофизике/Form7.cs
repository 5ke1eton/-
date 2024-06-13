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
    public partial class Form7 : Form
    {
        Thread h;
        public Form7()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox5.Text = "?";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double S1 = double.Parse(textBox2.Text);
            double S2 = double.Parse(textBox1.Text);
            double T1 = double.Parse(textBox4.Text);
            double T2 = double.Parse(textBox3.Text);
            textBox6.Text = textBox2.Text;
            textBox7.Text = textBox1.Text;
            textBox8.Text = textBox4.Text;
            textBox9.Text = textBox3.Text;
            textBox10.Text = Math.Round((Math.Pow((S1/S2), 3) * Math.Pow((T2/T1), 1)), 2).ToString();
            textBox5.Text = textBox10.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || (int)e.KeyChar == ','))
                e.KeyChar = (char)0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
