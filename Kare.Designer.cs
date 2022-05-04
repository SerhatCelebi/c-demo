
namespace Proje
{
    partial class Kare
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
            this.kareKenar = new System.Windows.Forms.TextBox();
            this.kareAlan = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kareSonuc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kareSonuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.kareAlan);
            this.groupBox1.Controls.Add(this.kareKenar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // kareKenar
            // 
            this.kareKenar.Location = new System.Drawing.Point(54, 88);
            this.kareKenar.Name = "kareKenar";
            this.kareKenar.Size = new System.Drawing.Size(88, 20);
            this.kareKenar.TabIndex = 0;
            // 
            // kareAlan
            // 
            this.kareAlan.Location = new System.Drawing.Point(169, 88);
            this.kareAlan.Name = "kareAlan";
            this.kareAlan.Size = new System.Drawing.Size(88, 20);
            this.kareAlan.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Karenin bir kenarını giriniz.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 132);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Karenin alanını giriniz.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kare mi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kareSonuc
            // 
            this.kareSonuc.Location = new System.Drawing.Point(427, 85);
            this.kareSonuc.Multiline = true;
            this.kareSonuc.Name = "kareSonuc";
            this.kareSonuc.ReadOnly = true;
            this.kareSonuc.Size = new System.Drawing.Size(88, 23);
            this.kareSonuc.TabIndex = 5;
            // 
            // Kare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox kareAlan;
        private System.Windows.Forms.TextBox kareKenar;
        private System.Windows.Forms.TextBox kareSonuc;
        private System.Windows.Forms.Button button1;
    }
}