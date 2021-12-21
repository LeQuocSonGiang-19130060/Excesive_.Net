
namespace bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(1, -1);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(700, 55);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(127, 90);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(51, 20);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Họ lót";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(127, 129);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(32, 20);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(199, 86);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(343, 27);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(199, 125);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(343, 27);
            this.txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(97, 192);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(97, 37);
            this.btnHo.TabIndex = 5;
            this.btnHo.Text = "Họ lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(307, 192);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(97, 37);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(504, 192);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(97, 37);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(285, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát Chương Trình";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Leave);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 382);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbHo);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnExit;
    }
}

