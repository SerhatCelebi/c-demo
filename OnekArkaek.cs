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
    public partial class OnekArkaek : Form
    {
        public OnekArkaek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("On veya art ek mi ? ilk girdi {0} ikinci girdi {1} Zaman {2}", txtEk1.Text,txtEk2.Text,DateTime.Now);
            
            if (txtEk1 == null || txtEk2 == null)
            {
                sw.WriteLine("Girdi hatası Zaman {0}",DateTime.Now);
                sw.Close();
                MessageBox.Show("Lütfen boşlukları doldurunuz.", "Hata");
            }
            else
            {
                int a = txtEk1.Text.Length;
                int b = txtEk2.Text.Length;
                if ((txtEk2.Text.Substring(0,a)).Contains(txtEk1.Text))
                {
                    
                    txtEkSonuc.Text = "Ön ektir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}",txtEkSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else if((txtEk2.Text.Substring(b-a,a)).Contains(txtEk1.Text))
                {
                    txtEkSonuc.Text = "Art ektir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", txtEkSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else
                {
                    txtEkSonuc.Text = "İkiside değildir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", txtEkSonuc.Text, DateTime.Now);
                    sw.Close();
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEkSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
