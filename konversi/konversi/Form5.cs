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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ardian_Supardi_txtInput.Text != null)
            {
                if (rdBalik.Checked == true)
                {
                    Ardian_Supardi_txtHasil.Text = String.Join("", Ardian_Supardi_txtInput.Text.Split().Reverse());
                }
                else if (rdReplace.Checked == true)
                {
                    Ardian_Supardi_txtHasil.Text = Ardian_Supardi_txtInput.Text.Replace("a", "o");
                }
                else
                {
                    MessageBox.Show("Please Select Option!", "Aplikasi Konversi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mohon isi sumber kata!", "Aplikasi Konversi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Ardian_Supardi_txtInput.Select();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(button1_Click);
            Controls.Add(button1);
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }
    }
}
