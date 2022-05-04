
namespace Proje
{
    partial class OnekArkaek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEk1 = new System.Windows.Forms.TextBox();
            this.txtEk2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEkSonuc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEkSonuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtEk2);
            this.groupBox1.Controls.Add(this.txtEk1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtEk1
            // 
            this.txtEk1.Location = new System.Drawing.Point(76, 103);
            this.txtEk1.Name = "txtEk1";
            this.txtEk1.Size = new System.Drawing.Size(100, 20);
            this.txtEk1.TabIndex = 0;
            // 
            // txtEk2
            // 
            this.txtEk2.Location = new System.Drawing.Point(214, 103);
            this.txtEk2.Name = "txtEk2";
            this.txtEk2.Size = new System.Drawing.Size(100, 20);
            this.txtEk2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 158);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 63);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Ek giriniz.";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 158);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 63);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Ek kontrolü yapılmasını istediğiniz dizgiyi giriniz.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ön ek veya art ek mi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEkSonuc
            // 
            this.txtEkSonuc.Location = new System.Drawing.Point(515, 106);
            this.txtEkSonuc.Multiline = true;
            this.txtEkSonuc.Name = "txtEkSonuc";
            this.txtEkSonuc.ReadOnly = true;
            this.txtEkSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtEkSonuc.TabIndex = 8;
            this.txtEkSonuc.TextChanged += new System.EventHandler(this.txtEkSonuc_TextChanged);
            // 
            // OnekArkaek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OnekArkaek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEk2;
        private System.Windows.Forms.TextBox txtEk1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEkSonuc;
    }
}