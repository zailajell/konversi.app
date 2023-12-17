using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konversi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jam, menit, detik, sisa, input;
            input = int.Parse(this.textBox1.Text);
            jam = input / 3600;
            sisa = input % 3600;
            menit = sisa / 60;
            detik = sisa % 60;
            this.textBox2.Text = Convert.ToString(jam);
            this.textBox3.Text = Convert.ToString(menit);
            this.textBox4.Text = Convert.ToString(detik);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(button1_Click);
            Controls.Add(button1);
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
