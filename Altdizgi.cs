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
    public partial class Altdizgi : Form
    {
        public Altdizgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Altdizgi mi? ilk girdi {0} ikinci girdi {1} Zaman {2}", txtAlt1.Text, txtAlt2.Text, DateTime.Now);
            
            if (txtAlt1==null || txtAlt2==null )
            {
                
                sw.WriteLine("Girdi hatası Zaman {0}",DateTime.Now);
                sw.Close();
                MessageBox.Show("Lütfen 2 dizgiyi doğru giriniz.", "Hata");
            }
            else
            {
                if (txtAlt2.Text.Contains(txtAlt1.Text))
                {
                    txtAltSonuc.Text = "Altdizgidir";
                    sw.WriteLine("Sonuç {0} Zaman {1}", txtAltSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else
                {
                    txtAltSonuc.Text = "Altdizgi değildir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", txtAltSonuc.Text, DateTime.Now);
                    sw.Close();
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
