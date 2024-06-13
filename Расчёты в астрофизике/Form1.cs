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
    public partial class Form1 : Form
    {
        Thread h;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open7);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open7(object obj)
        {
            Application.Run(new Form8());
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
            Application.Run(new Form2());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open1);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open1(object obj)
        {
            Application.Run(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open3);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open3(object obj)
        {
            Application.Run(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open4);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open4(object obj)
        {
            Application.Run(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open5);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open5(object obj)
        {
            Application.Run(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            h = new Thread(open6);
            h.SetApartmentState(ApartmentState.STA);
            h.Start();
        }
        public void open6(object obj)
        {
            Application.Run(new Form7());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
