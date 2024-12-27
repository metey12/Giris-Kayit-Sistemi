using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje35
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MailYonetimSistemiEntities mse = new MailYonetimSistemiEntities();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var mevcutMail = mse.Bilgiler.FirstOrDefault(b => b.Mail == txtKytMail.Text);

            if (mevcutMail != null)
            {
                MessageBox.Show("Bu e-posta adresi zaten kayıtlı!");
            }
            else
            {
                mse.Bilgiler.Add(new Bilgiler
                {
                    Ad = txtKytAd.Text,
                    Soyad = txtKytSoyad.Text,
                    Mail = txtKytMail.Text,
                    Sifre = txtKytSifre.Text
                });

                var sonuc = mse.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu!");
                }
            }
        }
    }
}
