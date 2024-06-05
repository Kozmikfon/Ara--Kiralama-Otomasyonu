using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{

    public partial class FrmAnaSayfa : Form
    {
        

        OleDbConnection baglanti =new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\galeriKisiselbilgi.mdb");
        public FrmAnaSayfa()
        {
            InitializeComponent();
            
            InitializeDatabaseConnection();
            // ComboBox'ı doldur
            FillComboBox();
            FillArabalarComboBox();

        }
        private void InitializeDatabaseConnection()
        {
            //string connectionString = "Data Source=your_database.db;Version=3;";
            //baglanti = new OleDbConnection(connectionString);

            try
            {
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kurulamadı: " + ex.Message);
            }
        }
        private void FillComboBox()
        {
            // Veritabanından verileri çek
            string query = "SELECT * FROM Arabalar";
           OleDbCommand cmd = new OleDbCommand(query, baglanti);

            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Veritabanından çekilen verileri ComboBox'a ekle
                    
                    string araba = reader["araba"].ToString();

                    // ComboBox'a öğe eklemek için bir veri yapısı kullanabilirsiniz
                    ComboboxItem item = new ComboboxItem(araba);
                    CmboxMarka.Items.Add(item);
                }
            }
        }
        
        private void FillSerilerComboBox(string selectedaraba)
        {
            CmboxSeri.Items.Clear();

            // Seçilen arabanın serilerini çek
            string serilerQuery = $"SELECT seri1, seri2, seri3, seri4 FROM Arabalar WHERE araba = '{selectedaraba}'";
            OleDbCommand serilerCommand = new OleDbCommand(serilerQuery, baglanti);

            using (OleDbDataReader serilerReader = serilerCommand.ExecuteReader())
            {
                if (serilerReader.Read())
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        string seriValue = serilerReader["Seri" + i.ToString()].ToString();
                        if (!string.IsNullOrEmpty(seriValue))
                        {
                            ComboboxItem comboboxItem = new ComboboxItem(seriValue);
                            CmboxSeri.Items.Add(comboboxItem);
                        }
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }    

        private void BtnMusteriGiris_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Müşteri kaydınız var mı?", "Müşteri kaydı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
            {
                FrmMusteriUye uye = new FrmMusteriUye();
                uye.ShowDialog();
            }
            else
            {
                FrmMusteriList liste= new FrmMusteriList();
                liste.ShowDialog();
            }
            this.Hide();
            
        }

        private void BtnMusteriLis_Click(object sender, EventArgs e)
        {
            FrmMusteriList musteriListele = new FrmMusteriList();
            musteriListele.ShowDialog();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmCikis cikis= new FrmCikis(); 
            cikis.ShowDialog();
            
        }

        private void BtnAracList_Click(object sender, EventArgs e)
        {
            FrmAracListele aracListele = new FrmAracListele();
            aracListele.ShowDialog();   
        }

        

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            CmboxSeri.Items.Clear();
        }

        private void BtnSatıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSatis satis=new FrmSatis();
            satis.ShowDialog();
            
        }

        private void FillArabalarComboBox()
        {
            string arabalarQuery = "SELECT DISTINCT araba FROM Arabalar";
            OleDbCommand arabalarCommand = new OleDbCommand(arabalarQuery, baglanti);

            OleDbDataReader arabalarReader = arabalarCommand.ExecuteReader();
            
                while (arabalarReader.Read())
                {
                    CmboxMarka.Items.Add(arabalarReader["araba"].ToString());
                }            
        }
        private void CmboxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selected = (ComboboxItem)CmboxMarka.SelectedItem;
            // string selectedMarka = CmboxMarka.SelectedItem as string;
            string selectedAraba = CmboxMarka.SelectedItem.ToString();
            FillSerilerComboBox(selectedAraba);
        }
        
        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmYonetici giris= new FrmYonetici();
            giris.ShowDialog();
        }

        private void BtnAracKayit_Click(object sender, EventArgs e)
        {
            FrmAracKayıt kayit=new FrmAracKayıt();
            kayit.ShowDialog();
        }

        private void BtnSozlesme_Click(object sender, EventArgs e)
        {
            FrmSozlesme sozlesme=new FrmSozlesme();
            sozlesme.ShowDialog();
        }

       
    }
    public class ComboboxItem  // veri tabanından comboboxa veri cekme
    {
        public string Text { get; set; }
        

        public ComboboxItem(string text)
        {
            Text = text;
            
        }
        public override string ToString()
        {
            return Text;
        }
    }
    
}
