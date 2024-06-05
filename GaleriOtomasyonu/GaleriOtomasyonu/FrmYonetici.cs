using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GaleriOtomasyonu
{
    public partial class FrmYonetici : Form
    {
        public static string ad;
        public static string soyad;
        public static string mail_adresi;
        public static string sifre;
        string baglantiCumlesi="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mahmu\\Desktop\\projeler\\galeriKisiselbilgi.mdb";
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
        }
        public void Getir()
        {
            OleDbConnection baglanti = new OleDbConnection(baglantiCumlesi);// veri tabanı bağlantısını ve verileri çekmemize yarar
            baglanti.Open();
            string komutCumlesi = "Select * From Yonetici where Mail like '" + TxtMail.Text + "' ";
            OleDbCommand komutYeni = new OleDbCommand(komutCumlesi, baglanti);  // veritabanıyla etkileşim sağlar ;select,uptade,delete,insert
            OleDbDataReader oku = komutYeni.ExecuteReader();  // sorgu sonucu dönen verileri satır satır okumaya yarar

            while (oku.Read())
            {
                
                mail_adresi = oku["Mail"].ToString();
                sifre = oku["Sifre"].ToString();
            }
            baglanti.Close();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            Getir();
            OleDbConnection baglanti = new OleDbConnection(baglantiCumlesi);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Yonetici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();// sorgu sonucu dönen verileri satır satır okumaya yarar

            while (oku.Read())
            {
                if (TxtMail.Text == oku["Mail"].ToString() && TxtSifre.Text == oku["Sifre"].ToString())
                {
                    MessageBox.Show("Giriş başarılı");
                    FrmPersonel personel= new FrmPersonel();
                    personel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bilgileri yanlış girdiniz", " Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            oku.Close();
            baglanti.Close();

        }

        private void PictureBoxGoz_Click(object sender, EventArgs e)
        {
            TxtSifre.PasswordChar = '\0';
            
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSifremiUnuttum sifreyenile=new FrmSifremiUnuttum();
            sifreyenile.ShowDialog();
        }
    }
}
