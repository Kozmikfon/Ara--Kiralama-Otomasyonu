using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GaleriOtomasyonu
{
    public partial class FrmSifremiUnuttum : Form
    {
        string cumle = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mahmu\\Desktop\\projeler\\galeriKisiselbilgi.mdb";

        public static string sifre;
        public static string mailadres;
        string pass;
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(cumle);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT* FROM Yonetici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (TxtMail.Text == oku["Mail"].ToString())
                {
                    Microsoft("mahmutbagl58@hotmail.com", "mahmut58+", TxtMail.Text);
                    Up();
                    MessageBox.Show("Girilen bilgiler eşleştirildi ve şifreniz yenilendi. Mailinizi kontrol ediniz.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BtnSifremiUnuttum.Click -= BtnSifremiUnuttum_Click;
                    this.Hide();
                    FrmYonetici frmYonetici = new FrmYonetici();
                    frmYonetici.ShowDialog();
                }
                else if (TxtMail.Text == "")
                {
                    MessageBox.Show("Mail adresi boş bırakılamaz", " Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Mail adresi ile veri tabanındaki adresler uyuşmuyor", " Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            oku.Close();// datareader kapandı
            baglanti.Close();// veritabanı baglantısı kapanadı
        }
        public void Microsoft(string gondericiMail, string gondericiPass, string aliciMail)
        {
            OleDbConnection baglanti = new OleDbConnection(cumle);
            baglanti.Open();
            OleDbCommand komutUp = new OleDbCommand("SELECT * FROM Yonetici", baglanti);
            OleDbDataReader oku = komutUp.ExecuteReader();

            while (oku.Read())
            {
                if (TxtMail.Text == oku["Mail"].ToString())
                {
                    Random rnd = new Random();
                    int a = rnd.Next(1000, 9999);
                    pass = a.ToString();// random sayıyı stringr çevirerek pass değişkenine atadı
                    SmtpClient sc = new SmtpClient();// e posta gödermek için kullanılan bir sınıftır
                    sc.Port = 587;// mail port numarası girilir
                    sc.Host = "smtp.outlook.com";
                    sc.EnableSsl = true;// ssl bağlantısını etkinleştirmek için kullanılır
                    sc.Credentials = new NetworkCredential(gondericiMail, gondericiPass);// smtp sunucusuna bağlanırken kullanıcı adı ve şifre bilgilerini girmek için kullanılan bir komuttur

                    MailMessage mail = new MailMessage(); // e posta mesajları oluşturmak için kullanılır
                    mail.From = new MailAddress(gondericiMail, "Sifremi unuttum");
                    mail.To.Add(aliciMail);
                    mail.Subject = "Şifre sıfırlama  talebi";
                    mail.IsBodyHtml = true;
                    mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre hatırlatma talebinde bulundunuz. Yeni şifreniz:{a}";
                    sc.Send(mail);
                }
                else
                {
                    MessageBox.Show("Bilgileri yanlış girdiniz", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } // while
            baglanti.Close();

        }
        public void Up()
        {
            OleDbConnection baglanti = new OleDbConnection(cumle);
            baglanti.Open();
            string komutcumlesiUp = "update Yonetici Set Mail='" + TxtMail.Text + "'";
            OleDbCommand komutUp = new OleDbCommand(komutcumlesiUp, baglanti);
            komutUp.Parameters.AddWithValue("@Sifre", pass.ToString());
            komutUp.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komutUp.ExecuteNonQuery(); // delete uptade gibi vei tabanı sorgularını yürütür
            baglanti.Close();

        }
    }
}
