using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            for (int i = 0; i < int.Parse(txtNumber.Text); i++)
            {
                Button bt = new Button();
                bt.Text = "a_" + (i + 1);
                bt.Location = new Point(100, y);
                bt.Size = new System.Drawing.Size(100, 40);
                bt.BackColor = Color.Red;
                bt.Click += new System.EventHandler(bt_Click);
                 void bt_Click(object sender, EventArgs e)
                {
                    lbMessage.Text ="bt : " + bt.Text+" war clicked";
                }
                panel1.Controls.Add(bt);
                y += 50;
            }
        }

       
    }
}
