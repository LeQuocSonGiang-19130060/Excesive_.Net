using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.lbResult.Text = this.textBox1.Text;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void colorRed_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Red;
        }

        private void colorGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Green;
        }

        private void colorBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Blue;
        }

        private void colorBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Black;
        }

        private void ckBold_CheckedChanged(object sender, EventArgs e)
        {
            handling_CheckedChange();
        }

        private void ckItalic_CheckedChanged(object sender, EventArgs e)
        {
            handling_CheckedChange();
        }

        private void ckUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            handling_CheckedChange();
        }

        private void handling_CheckedChange()
        {
            if (ckBold.Checked && ckItalic.Checked && ckUnderLine.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))), ((byte)(0)));
            }
            else if (ckBold.Checked && ckItalic.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold))), ((byte)(0)));
            }
            else if (ckItalic.Checked && ckUnderLine.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Italic))), ((byte)(0)));
            }
            else if (ckBold.Checked && ckUnderLine.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold))), ((byte)(0)));
            }
            else if (ckBold.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), ((byte)(0)));
            }
            else if (ckItalic.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), ((byte)(0)));
            }
            else if (ckUnderLine.Checked)
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline))), ((byte)(0)));
            }
            else
            {
                this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular))), ((byte)(0)));
            }
        }

    }
}
