using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class FrmMusteriList : Form
    {
        OleDbConnection baglanti=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\galeriKisiselbilgi.mdb");
        AracIslemleri aracIslemListe=new AracIslemleri();
        public FrmMusteriList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMusteriList_Load(object sender, EventArgs e) // müsteri listeleme sayfası
        {
            YenileListele();
           
        }

        private void YenileListele()
        {
            string cumle = "Select * from bilgiler";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = aracIslemListe.Listele(adtr2, cumle);
            
        }
       
        private void BtnGuncelle_Click(object sender, EventArgs e) // guncelle butonu
        {
            //TimerList.Start();
            string cumle = "update bilgiler set Isim = '"+TxtIsim.Text+"', SoyIsim = '"+TxtSoyIsim.Text+"', DogumTarihi = '"+dateTimePDogumT.Text+"', MailAdres = '"+TxtMail.Text+"', Sifre = '"+TxtSifre.Text+"' where TcNo = '"+TxtTC.Text+"'";
            OleDbCommand komut = new OleDbCommand(cumle, baglanti);            
            komut.Parameters.AddWithValue("@Isim", TxtIsim.Text);
            komut.Parameters.AddWithValue("@SoyIsim", TxtSoyIsim.Text);
            komut.Parameters.AddWithValue("@DogumTarihi", dateTimePDogumT.Text);            
            komut.Parameters.AddWithValue("@MailAdres", TxtMail.Text);
            komut.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
            komut.Parameters.AddWithValue("@TcNo", TxtTC.Text);
            
            try
            {
                aracIslemListe.EkleSilGuncelle(komut, cumle);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata tespit edildi: " + ex.Message);
            }

            YenileListele();
            

        }

        private void button2_Click(object sender, EventArgs e) // ara butonu
        {
            if (MskedTxtTcAra.Text.Length < 11)
            {
                MessageBox.Show("Tc kimlik numarası 11 haneden düşük olamaz");
                MskedTxtTcAra.Clear();
            }
            string cumle = "Select * from bilgiler where TcNo like '%"+MskedTxtTcAra.Text+"%'  ";// bu komut kullanıcının girdiği metin kutusundaki ifadeyi arar. 
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();

            
            dataGridView1.DataSource = aracIslemListe.Listele(adtr2, cumle);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow; // datagridwiev nesnesi olusturuldu. currrentrow, kullanıcının şu anki satırda bulunduğu satırı belirler 

            TxtTC.Text = satir.Cells["TcNo"].Value.ToString();
            TxtIsim.Text = satir.Cells["Isim"].Value.ToString();
            TxtSoyIsim.Text = satir.Cells["SoyIsim"].Value.ToString();    
            dateTimePDogumT.Text = satir.Cells["DogumTarihi"].Value.ToString(); 
            TxtMail.Text = satir.Cells["MailAdres"].Value.ToString();
            TxtSifre.Text = satir.Cells["Sifre"].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e) // sil butonu
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from bilgiler where Isim='" + satir.Cells["Isim"].Value + "' ";
            OleDbCommand komut = new OleDbCommand(cumle);
            
            aracIslemListe.EkleSilGuncelle(komut, cumle);         
            YenileListele();


        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }
        int zaman = 50;
        private void TimerList_Tick(object sender, EventArgs e)
        {
            ProgressBList.Visible = true;
            TimerList.Interval = 50;
            ProgressBList.Value = zaman;
            zaman++;
            if (zaman==100)
            {
                TimerList.Stop();
                MessageBox.Show("Kayıt başarıyla guncellendi.");
                
            }

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.ShowDialog();   
        }
    }
}
