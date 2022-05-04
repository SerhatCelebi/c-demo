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
    public partial class Kare : Form
    {
        public Kare()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Kare mi? ilk girdi {0} ikinci girdi {1} Zaman {2}", kareKenar.Text, kareAlan.Text, DateTime.Now);
            
            if (kareKenar.Text == null || kareAlan.Text == null || Convert.ToInt32(kareKenar.Text) <= 0 || Convert.ToInt32(kareAlan.Text) <= 0)
            {
                sw.WriteLine("Girdi hatası Zaman {0}", DateTime.Now);
                sw.Close();
                MessageBox.Show("Lütfen üçgenin kenarlarını doğru giriniz.", "Hata");
            }
            else
            {
                if (Math.Pow(Convert.ToInt32(kareKenar.Text),2) == Convert.ToInt32(kareAlan.Text))
                {
                    kareSonuc.Text = "Karedir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", kareSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else
                {
                    kareSonuc.Text = "Kare değildir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", kareSonuc.Text, DateTime.Now);
                    sw.Close();
                }

            }
        }
    }
}
