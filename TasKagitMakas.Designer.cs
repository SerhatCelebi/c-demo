
namespace Proje
{
    partial class TasKagitMakas
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
            this.lstSecim1 = new System.Windows.Forms.ListBox();
            this.lstSecim2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tasKagitMakasSonuc = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tasKagitMakasSonuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lstSecim2);
            this.groupBox1.Controls.Add(this.lstSecim1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lstSecim1
            // 
            this.lstSecim1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSecim1.FormattingEnabled = true;
            this.lstSecim1.Items.AddRange(new object[] {
            "Taş",
            "Kağıt",
            "Makas"});
            this.lstSecim1.Location = new System.Drawing.Point(91, 81);
            this.lstSecim1.Name = "lstSecim1";
            this.lstSecim1.Size = new System.Drawing.Size(120, 93);
            this.lstSecim1.TabIndex = 0;
            this.lstSecim1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstSecim2
            // 
            this.lstSecim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSecim2.FormattingEnabled = true;
            this.lstSecim2.Items.AddRange(new object[] {
            "Taş",
            "Kağıt",
            "Makas"});
            this.lstSecim2.Location = new System.Drawing.Point(266, 81);
            this.lstSecim2.Name = "lstSecim2";
            this.lstSecim2.Size = new System.Drawing.Size(120, 93);
            this.lstSecim2.TabIndex = 1;
            this.lstSecim2.SelectedIndexChanged += new System.EventHandler(this.lstSecim2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oyna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tasKagitMakasSonuc
            // 
            this.tasKagitMakasSonuc.Location = new System.Drawing.Point(526, 81);
            this.tasKagitMakasSonuc.Multiline = true;
            this.tasKagitMakasSonuc.Name = "tasKagitMakasSonuc";
            this.tasKagitMakasSonuc.ReadOnly = true;
            this.tasKagitMakasSonuc.Size = new System.Drawing.Size(100, 44);
            this.tasKagitMakasSonuc.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 44);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Seçiminizi yapın.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 197);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 44);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Rakip şeçimini yapsın.";
            // 
            // TasKagitMakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TasKagitMakas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSecim1;
        private System.Windows.Forms.ListBox lstSecim2;
        private System.Windows.Forms.TextBox tasKagitMakasSonuc;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}