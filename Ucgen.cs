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
    public partial class Ucgen : Form
    {
        public Ucgen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
       
        private void btnUcgenControl_Click(object sender, EventArgs e)

        {
            FileStream fs = new FileStream("C:\\proje\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Üçgen mi? ilk girdi {0} ikinci girdi {1} üçüncü girdi {2} Zaman {3}", ucgenKenar1.Text, ucgenKenar2.Text,ucgenKenar3.Text, DateTime.Now);
            
            if (ucgenKenar1.Text==null || ucgenKenar2.Text==null || ucgenKenar3.Text == null || 
                Convert.ToInt32(ucgenKenar1.Text)<=0 || Convert.ToInt32(ucgenKenar2.Text)<=0 || Convert.ToInt32(ucgenKenar3.Text)<=0 )
            {
                sw.WriteLine("Girdi hatası Zaman {0}", DateTime.Now);
                sw.Close();
                MessageBox.Show("Lütfen üçgenin kenarlarını doğru giriniz.","Hata");
            }
            else
            {
                if (Convert.ToInt32(ucgenKenar1.Text) + Convert.ToInt32(ucgenKenar2.Text) >= Convert.ToInt32(ucgenKenar3.Text)
                    && Convert.ToInt32(ucgenKenar2.Text) + Convert.ToInt32(ucgenKenar3.Text) >= Convert.ToInt32(ucgenKenar1.Text)
                    && Convert.ToInt32(ucgenKenar3.Text) + Convert.ToInt32(ucgenKenar1.Text) >= Convert.ToInt32(ucgenKenar2.Text)
                    )
                {
                    ucgenSonuc.Text = "Üçgendir";
                    sw.WriteLine("Sonuç {0} Zaman {1}", ucgenSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                else
                {
                    ucgenSonuc.Text = "Üçgen değildir.";
                    sw.WriteLine("Sonuç {0} Zaman {1}", ucgenSonuc.Text, DateTime.Now);
                    sw.Close();
                }
                
            }
        }

        private void ucgenKenar1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ucgenKenar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ucgenKenar3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
