using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            lbResult.Text = "";
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String product = "";
            foreach (String s in listBox1.SelectedItems)
            {
                product += s + "\n";
            }
            lbResult.Text = "Thông tin khách hàng\nKhách hàng: " + txtName.Text + "\nĐiện thoại: " + txtPhone.Text + "\nSản phẩm đặt mua:\n" + product;
        }
    }
}
