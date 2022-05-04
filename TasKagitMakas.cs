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
    public partial class TasKagitMakas : Form
    {
        public TasKagitMakas()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSecim2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Taş kağıt makas ilk girdi {0} ikinci girdi {1} Zaman {2}", lstSecim1.SelectedIndex,lstSecim2.SelectedIndex, DateTime.Now);
            
            if (lstSecim1.SelectedIndex == -1 || lstSecim2.SelectedIndex == -1)
            {
                sw.WriteLine("Girdi hatası Zaman {0}", DateTime.Now);
                sw.Close();
                MessageBox.Show("Lütfen listeden seçim yapınız", "Hata");

            }
            else
            {
                if ((lstSecim1.SelectedIndex == 0 && lstSecim2.SelectedIndex == 2)
                    || (lstSecim1.SelectedIndex == 1 && lstSecim2.SelectedIndex == 0)
                    || (lstSecim1.SelectedIndex == 2 && lstSecim2.SelectedIndex == 1)
                    )
                {
                    tasKagitMakasSonuc.Text = "Kazandın.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", tasKagitMakasSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else if (lstSecim1.SelectedIndex == lstSecim2.SelectedIndex)
                {
                    tasKagitMakasSonuc.Text = "Berabere.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", tasKagitMakasSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else
                {
                    tasKagitMakasSonuc.Text = "Kaybettin.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", tasKagitMakasSonuc.Text, DateTime.Now);
                    sw.Close();
                }
            }

        }
    }
}
