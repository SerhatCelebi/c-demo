
namespace Proje
{
    partial class Ucgen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucgenKenar3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnUcgenControl = new System.Windows.Forms.Button();
            this.ucgenSonuc = new System.Windows.Forms.TextBox();
            this.ucgenKenar2 = new System.Windows.Forms.TextBox();
            this.ucgenKenar1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ucgenKenar3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.btnUcgenControl);
            this.groupBox1.Controls.Add(this.ucgenSonuc);
            this.groupBox1.Controls.Add(this.ucgenKenar2);
            this.groupBox1.Controls.Add(this.ucgenKenar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 36);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Üçgenin bir kenarını girin";
            // 
            // ucgenKenar3
            // 
            this.ucgenKenar3.Location = new System.Drawing.Point(179, 82);
            this.ucgenKenar3.Name = "ucgenKenar3";
            this.ucgenKenar3.Size = new System.Drawing.Size(74, 20);
            this.ucgenKenar3.TabIndex = 6;
            this.ucgenKenar3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucgenKenar3_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 108);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(74, 36);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Üçgenin bir kenarını girin";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 108);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(74, 36);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Üçgenin bir kenarını girin";
            // 
            // btnUcgenControl
            // 
            this.btnUcgenControl.Location = new System.Drawing.Point(288, 82);
            this.btnUcgenControl.Name = "btnUcgenControl";
            this.btnUcgenControl.Size = new System.Drawing.Size(75, 23);
            this.btnUcgenControl.TabIndex = 3;
            this.btnUcgenControl.Text = "Üçgen mi";
            this.btnUcgenControl.UseVisualStyleBackColor = true;
            this.btnUcgenControl.Click += new System.EventHandler(this.btnUcgenControl_Click);
            // 
            // ucgenSonuc
            // 
            this.ucgenSonuc.Location = new System.Drawing.Point(406, 85);
            this.ucgenSonuc.Multiline = true;
            this.ucgenSonuc.Name = "ucgenSonuc";
            this.ucgenSonuc.ReadOnly = true;
            this.ucgenSonuc.Size = new System.Drawing.Size(90, 20);
            this.ucgenSonuc.TabIndex = 2;
            // 
            // ucgenKenar2
            // 
            this.ucgenKenar2.Location = new System.Drawing.Point(99, 82);
            this.ucgenKenar2.Name = "ucgenKenar2";
            this.ucgenKenar2.Size = new System.Drawing.Size(74, 20);
            this.ucgenKenar2.TabIndex = 1;
            this.ucgenKenar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucgenKenar2_KeyPress);
            // 
            // ucgenKenar1
            // 
            this.ucgenKenar1.Location = new System.Drawing.Point(19, 82);
            this.ucgenKenar1.Name = "ucgenKenar1";
            this.ucgenKenar1.Size = new System.Drawing.Size(74, 20);
            this.ucgenKenar1.TabIndex = 0;
            this.ucgenKenar1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.ucgenKenar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucgenKenar1_KeyPress);
            // 
            // Ucgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ucgen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ucgenKenar1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnUcgenControl;
        private System.Windows.Forms.TextBox ucgenSonuc;
        private System.Windows.Forms.TextBox ucgenKenar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ucgenKenar3;
    }
}