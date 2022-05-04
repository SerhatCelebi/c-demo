using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TasKagitMakas taskagıtmakas = new TasKagitMakas();
            taskagıtmakas.TopLevel = false;
            pnlControl.Controls.Add(taskagıtmakas);
            taskagıtmakas.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnekArkaek onekArkaek = new OnekArkaek();
            onekArkaek.TopLevel = false;
            pnlControl.Controls.Add(onekArkaek);
            onekArkaek.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Altdizgi altdizgi = new Altdizgi();
            altdizgi.TopLevel = false;
            pnlControl.Controls.Add(altdizgi);
            altdizgi.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.TopLevel = false;
            pnlControl.Controls.Add(ucgen);
            ucgen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.TopLevel = false;
            pnlControl.Controls.Add(kare);
            kare.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Kapatmak istiyormusun?", "Uyarı!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Uygulama kapatıldı.{0}",DateTime.Now);
                sw.Close();
                System.Environment.Exit(1);
            }
        }
    }
}
