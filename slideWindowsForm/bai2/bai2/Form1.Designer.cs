
namespace bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorBlack = new System.Windows.Forms.RadioButton();
            this.colorBlue = new System.Windows.Forms.RadioButton();
            this.colorGreen = new System.Windows.Forms.RadioButton();
            this.colorRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckUnderLine = new System.Windows.Forms.CheckBox();
            this.ckItalic = new System.Windows.Forms.CheckBox();
            this.ckBold = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Tên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.colorBlack);
            this.groupBox1.Controls.Add(this.colorBlue);
            this.groupBox1.Controls.Add(this.colorGreen);
            this.groupBox1.Controls.Add(this.colorRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // colorBlack
            // 
            this.colorBlack.AutoSize = true;
            this.colorBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBlack.ForeColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(57, 178);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(81, 28);
            this.colorBlack.TabIndex = 3;
            this.colorBlack.Text = "Black";
            this.colorBlack.UseVisualStyleBackColor = true;
            this.colorBlack.CheckedChanged += new System.EventHandler(this.colorBlack_CheckedChanged);
            // 
            // colorBlue
            // 
            this.colorBlue.AutoSize = true;
            this.colorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colorBlue.Location = new System.Drawing.Point(57, 132);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(73, 28);
            this.colorBlue.TabIndex = 2;
            this.colorBlue.TabStop = true;
            this.colorBlue.Text = "Blue";
            this.colorBlue.UseVisualStyleBackColor = true;
            this.colorBlue.CheckedChanged += new System.EventHandler(this.colorBlue_CheckedChanged);
            // 
            // colorGreen
            // 
            this.colorGreen.AutoSize = true;
            this.colorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGreen.ForeColor = System.Drawing.Color.Green;
            this.colorGreen.Location = new System.Drawing.Point(57, 86);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(89, 28);
            this.colorGreen.TabIndex = 1;
            this.colorGreen.TabStop = true;
            this.colorGreen.Text = "Green";
            this.colorGreen.UseVisualStyleBackColor = true;
            this.colorGreen.CheckedChanged += new System.EventHandler(this.colorGreen_CheckedChanged);
            // 
            // colorRed
            // 
            this.colorRed.AutoSize = true;
            this.colorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorRed.ForeColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(57, 37);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(69, 28);
            this.colorRed.TabIndex = 0;
            this.colorRed.TabStop = true;
            this.colorRed.Text = "Red";
            this.colorRed.UseVisualStyleBackColor = true;
            this.colorRed.CheckedChanged += new System.EventHandler(this.colorRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.ckUnderLine);
            this.groupBox2.Controls.Add(this.ckItalic);
            this.groupBox2.Controls.Add(this.ckBold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(276, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // ckUnderLine
            // 
            this.ckUnderLine.AutoSize = true;
            this.ckUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUnderLine.Location = new System.Drawing.Point(26, 167);
            this.ckUnderLine.Name = "ckUnderLine";
            this.ckUnderLine.Size = new System.Drawing.Size(133, 28);
            this.ckUnderLine.TabIndex = 2;
            this.ckUnderLine.Text = "Gạch chân";
            this.ckUnderLine.UseVisualStyleBackColor = true;
            this.ckUnderLine.CheckedChanged += new System.EventHandler(this.ckUnderLine_CheckedChanged);
            // 
            // ckItalic
            // 
            this.ckItalic.AutoSize = true;
            this.ckItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckItalic.Location = new System.Drawing.Point(26, 110);
            this.ckItalic.Name = "ckItalic";
            this.ckItalic.Size = new System.Drawing.Size(160, 28);
            this.ckItalic.TabIndex = 1;
            this.ckItalic.Text = "Nghiêng Italic";
            this.ckItalic.UseVisualStyleBackColor = true;
            this.ckItalic.CheckedChanged += new System.EventHandler(this.ckItalic_CheckedChanged);
            // 
            // ckBold
            // 
            this.ckBold.AutoSize = true;
            this.ckBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBold.Location = new System.Drawing.Point(26, 50);
            this.ckBold.Name = "ckBold";
            this.ckBold.Size = new System.Drawing.Size(122, 28);
            this.ckBold.TabIndex = 0;
            this.ckBold.Text = "Đậm Bold";
            this.ckBold.UseVisualStyleBackColor = true;
            this.ckBold.CheckedChanged += new System.EventHandler(this.ckBold_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lập trình bởi";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(155, 362);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(214, 38);
            this.lbResult.TabIndex = 6;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton colorRed;
        private System.Windows.Forms.RadioButton colorBlack;
        private System.Windows.Forms.RadioButton colorBlue;
        private System.Windows.Forms.RadioButton colorGreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckUnderLine;
        private System.Windows.Forms.CheckBox ckItalic;
        private System.Windows.Forms.CheckBox ckBold;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button button1;
    }
}

