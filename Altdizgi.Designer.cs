
namespace Proje
{
    partial class Altdizgi
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
            this.txtAlt1 = new System.Windows.Forms.TextBox();
            this.txtAlt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAltSonuc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtAltSonuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAlt2);
            this.groupBox1.Controls.Add(this.txtAlt1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAlt1
            // 
            this.txtAlt1.Location = new System.Drawing.Point(78, 62);
            this.txtAlt1.Name = "txtAlt1";
            this.txtAlt1.Size = new System.Drawing.Size(100, 20);
            this.txtAlt1.TabIndex = 0;
            // 
            // txtAlt2
            // 
            this.txtAlt2.Location = new System.Drawing.Point(202, 63);
            this.txtAlt2.Name = "txtAlt2";
            this.txtAlt2.Size = new System.Drawing.Size(100, 20);
            this.txtAlt2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Altdizgi mi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAltSonuc
            // 
            this.txtAltSonuc.Location = new System.Drawing.Point(458, 59);
            this.txtAltSonuc.Multiline = true;
            this.txtAltSonuc.Name = "txtAltSonuc";
            this.txtAltSonuc.ReadOnly = true;
            this.txtAltSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtAltSonuc.TabIndex = 3;
            this.txtAltSonuc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 63);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Altdizgiyi giriniz.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 63);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Altdizgi kontrolü yapılmasını istediğiniz dizgiyi giriniz.";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Altdizgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Altdizgi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAlt2;
        private System.Windows.Forms.TextBox txtAlt1;
        private System.Windows.Forms.TextBox txtAltSonuc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}