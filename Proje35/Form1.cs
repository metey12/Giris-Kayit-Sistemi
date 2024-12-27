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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MailYonetimSistemiEntities mse = new MailYonetimSistemiEntities();  
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnGrsGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcının giriş yapmak için girdiği e-posta ve şifreyi al
            string mail = txtGrsMail.Text;
            string sifre = txtGrsSifre.Text;

            // E-posta ve şifre boşsa kullanıcıyı bilgilendir
            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen e-posta ve şifreyi doldurun.");
                return;
            }

            // E-posta adresini ve şifreyi veritabanında kontrol et
            var kullanici = mse.Bilgiler.FirstOrDefault(b => b.Mail == mail && b.Sifre == sifre);

            if (kullanici != null)
            {
                // Kullanıcı bilgileri doğruysa, başarılı giriş mesajı
                MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + kullanici.Ad + " " + kullanici.Soyad);
                // Giriş sonrası yapılacak işlemler (örneğin ana ekran açmak)
                // Ana ekran formunu açmak için bir örnek:
                // this.Hide(); // Mevcut formu gizle
                // AnaEkranFormu anaEkran = new AnaEkranFormu();
                // anaEkran.Show();
            }
            else
            {
                // Kullanıcı bilgileri yanlışsa, hata mesajı göster
                MessageBox.Show("Geçersiz e-posta veya şifre. Lütfen tekrar deneyin.");
            }
        }

        private void txtGrsMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtGrsSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
