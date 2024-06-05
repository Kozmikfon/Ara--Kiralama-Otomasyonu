using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class FrmMusteriUye : Form
    {
        AracIslemleri aracislemleri = new AracIslemleri();
        public FrmMusteriUye()
        {
            InitializeComponent();
        }

        private void FrmMusteriUye_Load(object sender, EventArgs e)
        {

        }

        private void BtnUye_Click(object sender, EventArgs e)
        {
            string cumle = "insert into bilgiler (TcNo,Isim,SoyIsim,DogumTarihi,MailAdres,Sifre) values (@TcNo,@Isim,@SoyIsim,@DogumTarihi,@MailAdres,@Sifre)";
            OleDbCommand komut = new OleDbCommand(cumle);
            if (MskdTxtTc.Text.Length < 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneden küçük olamaz");
            }
            else
            {
                komut.Parameters.AddWithValue("@TcNo", MskdTxtTc.Text);
            }
            komut.Parameters.AddWithValue("@Isim", TxtIsim.Text);
            komut.Parameters.AddWithValue("@SoyIsim", TxtSoyisim.Text);

            // DogumTarihi alanını uygun bir tarih formatına dönüştürme
            DateTime dogumTarihi;
            if (DateTime.TryParse(dateTimePDogum.Text, out dogumTarihi)) // out kullanım şekli, dondurulen degeri bool veri tipiyle saklar
            {
                komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            }
            else
            {
                // Uygun bir tarih elde edilemediyse, bir varsayılan değeri atayabilirsiniz.
                komut.Parameters.AddWithValue("@DogumTarihi", DBNull.Value);
            }

            komut.Parameters.AddWithValue("@MailAdres", TxtMail.Text);
            komut.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
            try
            {
                aracislemleri.EkleSilGuncelle(komut, cumle);
                MessageBox.Show("Kayıt başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Alanlar boş bırakılamaz");
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is DateTimePicker) item.Text = "";

            FrmMusteriList liste= new FrmMusteriList();
            liste.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.ShowDialog();
        }
    }
}
