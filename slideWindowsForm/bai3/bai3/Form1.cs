using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = true;
            label2.Text = name + ".Turn OFF the Light, please!";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = false;
            this.pictureBox1.Visible = true;
            label2.Text = name + ".Turn ON the Light, please!";
        }
        String name = "Giang";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            lbName.Text = name;
            label2.Text = name+".Turn ON the Light, please!";
        }
    }
}
