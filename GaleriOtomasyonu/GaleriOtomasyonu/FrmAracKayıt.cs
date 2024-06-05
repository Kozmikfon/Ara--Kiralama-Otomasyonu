using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class FrmAracKayıt : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\galeriKisiselbilgi.mdb");
        AracIslemleri arackayıt=new AracIslemleri();    
        public FrmAracKayıt()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            // ComboBox'ı doldur
            FillComboBox();
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
                    CmboxItem item = new CmboxItem(araba);
                    CmboxMarka.Items.Add(item);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatıldığında veritabanı bağlantısını kapat
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void Btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBoxResim.ImageLocation = openFileDialog1.FileName; // dosyanın kendisi  pictureboxa gelmiş olacak  

        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            string cumle = "insert into AracBilgiler(Plaka,Marka,Seri,ModelYili,Renk,Km,Yakit,KiraUcreti,Resim,Tarih,durumu,KaporaMiktari,VitesTuru,Muayene,HasarKaydı) values(@Plaka,@Marka,@Seri,@ModelYili,@Renk,@Km,@Yakit,@KiraUcreti,@Resim,@Tarih,@durumu,@KaporaMiktari,@VitesTuru,@Muayene,@HasarKaydı)";            
            OleDbCommand komut = new OleDbCommand();

            komut.Parameters.AddWithValue("@Plaka",TxtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka",CmboxMarka.Text);
            komut.Parameters.AddWithValue("@Seri",CmboxSeri.Text);
            komut.Parameters.AddWithValue("@ModelYili",MsktexModel.Text);
            komut.Parameters.AddWithValue("@Renk", TxtRenk.Text);
            komut.Parameters.AddWithValue("@Km",TxtKm.Text);
            komut.Parameters.AddWithValue("@Yakit",CmboxYakit.Text);
            komut.Parameters.AddWithValue("@KiraUcreti",TxtKira.Text);           
            komut.Parameters.AddWithValue("@Resim",PictureBoxResim.ImageLocation);
            komut.Parameters.AddWithValue("@Tarih",DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@durumu","BOŞ");
            komut.Parameters.AddWithValue("@KaporaMiktari",TxtKapora.Text);
            komut.Parameters.AddWithValue("@VitesTuru",CmboxVites.Text);
            komut.Parameters.AddWithValue("@Muayene",DateTimPMuayene.Text);
            komut.Parameters.AddWithValue("@HasarKaydı",TxtTramer.Text);

            arackayıt.EkleSilGuncelle(komut,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
            PictureBoxResim.ImageLocation = "";

        }

        private void CmboxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmboxItem selected = (CmboxItem)CmboxMarka.SelectedItem;
            try
            {
                CmboxSeri.Items.Clear();

                if (CmboxMarka.SelectedIndex==0)// alfa romeo
                {
                    CmboxSeri.Items.Add("Distinctive");
                    CmboxSeri.Items.Add("Giulietta");
   
                }
                if (CmboxMarka.SelectedIndex==1)// audi
                {
                    CmboxSeri.Items.Add("A3 Sedan");
                    CmboxSeri.Items.Add("A4");
                    CmboxSeri.Items.Add("A5");
                    CmboxSeri.Items.Add("A6");
                    CmboxSeri.Items.Add("A7");
                }
                if (CmboxMarka.SelectedIndex==2)// bentley
                {
                    CmboxSeri.Items.Add("Continental");
                }
                if (CmboxMarka.SelectedIndex==3)// bmw
                {
                    CmboxSeri.Items.Add("M3");
                    CmboxSeri.Items.Add("M4");
                    CmboxSeri.Items.Add("M5");
                    
                }
                if (CmboxMarka.SelectedIndex==4)// cadillac
                {
                    CmboxSeri.Items.Add("DeVille");
                }
                if (CmboxMarka.SelectedIndex == 5)// chevrolet
                {
                    CmboxSeri.Items.Add("Aveo");
                    CmboxSeri.Items.Add("Cruze");
                    CmboxSeri.Items.Add("Captiva");
                }
                if (CmboxMarka.SelectedIndex == 6)// chrysler
                {
                    CmboxSeri.Items.Add("Sebring");
                    CmboxSeri.Items.Add("300 C");
                }
                if (CmboxMarka.SelectedIndex == 7)// cıtroen
                {
                    CmboxSeri.Items.Add("C3 AirCross");
                    CmboxSeri.Items.Add("C4 Cactus");
                    CmboxSeri.Items.Add("Executive");
                }
                if (CmboxMarka.SelectedIndex == 8)// cupra
                {
                    CmboxSeri.Items.Add("Formentor");
                }
                if (CmboxMarka.SelectedIndex == 9)// dacıa
                {
                    CmboxSeri.Items.Add("Sandero");
                    CmboxSeri.Items.Add("Duster");
                }
                if (CmboxMarka.SelectedIndex == 10)//dodge
                {
                    CmboxSeri.Items.Add("Challenger");
                }
                if (CmboxMarka.SelectedIndex ==11)// fıat
                {
                    CmboxSeri.Items.Add("Doblo");
                    CmboxSeri.Items.Add("Egea");
                    CmboxSeri.Items.Add("");
                }
                if (CmboxMarka.SelectedIndex == 12)// ford
                {
                    CmboxSeri.Items.Add("Tourneo Cuurier");
                    CmboxSeri.Items.Add("Kuga");
                    CmboxSeri.Items.Add("Puma");
                    CmboxSeri.Items.Add("Focus");                    
                }
                if (CmboxMarka.SelectedIndex == 13)// honda
                {
                    CmboxSeri.Items.Add("Civic");
                    CmboxSeri.Items.Add("Cr-v");
                }
                if (CmboxMarka.SelectedIndex == 14)//hyundaı
                {
                    CmboxSeri.Items.Add("Elantra");
                    CmboxSeri.Items.Add("Accent");
                }
                if (CmboxMarka.SelectedIndex == 15)//jaguar
                {
                    CmboxSeri.Items.Add("XJ");
                }
                if (CmboxMarka.SelectedIndex == 16)//kıa
                {
                    CmboxSeri.Items.Add("Rio");
                    CmboxSeri.Items.Add("Cerato");
                    CmboxSeri.Items.Add("Sportage");
                }
                if (CmboxMarka.SelectedIndex == 17)//maserati
                {
                    CmboxSeri.Items.Add("GranTurismo");
                }
                if (CmboxMarka.SelectedIndex == 18)// mazda
                {
                    CmboxSeri.Items.Add("SkyActive-G Power Sense ");
                }
                if (CmboxMarka.SelectedIndex == 19)// McLaren
                {
                    CmboxSeri.Items.Add("720S");
                }
                if (CmboxMarka.SelectedIndex == 20)// mını
                {
                    CmboxSeri.Items.Add("Cooper S");
                
                }
                if (CmboxMarka.SelectedIndex == 21)// mıtsubıshı
                {
                    CmboxSeri.Items.Add("Colt");
                    CmboxSeri.Items.Add("Lancer");
                }
                if (CmboxMarka.SelectedIndex ==22)// mercedes
                {
                    CmboxSeri.Items.Add("C180");
                    CmboxSeri.Items.Add("C200");
                    CmboxSeri.Items.Add("E180");
                    CmboxSeri.Items.Add("E200");
                }
                if (CmboxMarka.SelectedIndex == 23)// nissan
                {
                    CmboxSeri.Items.Add("Qashqai");
                    CmboxSeri.Items.Add("X-Trail");
                    CmboxSeri.Items.Add("Juke");
                    CmboxSeri.Items.Add("Navara");
                }
                if (CmboxMarka.SelectedIndex == 24)// opel
                {
                    CmboxSeri.Items.Add("Corsa");
                    CmboxSeri.Items.Add("Astra");
                    CmboxSeri.Items.Add("Insignia");
                    CmboxSeri.Items.Add("Crossland X");
                }
                if (CmboxMarka.SelectedIndex == 25)//peugeot
                {
                    CmboxSeri.Items.Add("508");
                    CmboxSeri.Items.Add("3008");
                }
                if (CmboxMarka.SelectedIndex == 26)//renault
                {
                    CmboxSeri.Items.Add("Symbol");
                    CmboxSeri.Items.Add("Fluence");
                    CmboxSeri.Items.Add("Clio");
                    CmboxSeri.Items.Add("Megane");
                    CmboxSeri.Items.Add("Talisman");
                    
                }
                if (CmboxMarka.SelectedIndex == 27)// seat
                {
                    CmboxSeri.Items.Add("ıbiza");
                    CmboxSeri.Items.Add("Leon FR");
                    CmboxSeri.Items.Add("Ateca");
                }
                if (CmboxMarka.SelectedIndex == 28)//skoda
                {
                    CmboxSeri.Items.Add("Fabia");
                    CmboxSeri.Items.Add("Rapid");
                    CmboxSeri.Items.Add("Kamiq");
                    CmboxSeri.Items.Add("Scala");
                    CmboxSeri.Items.Add("Octavia");
                    CmboxSeri.Items.Add("Superb");
                }
                if (CmboxMarka.SelectedIndex == 29)//tesla
                {
                    CmboxSeri.Items.Add("Model Y");
                }
                if (CmboxMarka.SelectedIndex == 30)//toyota
                {
                    CmboxSeri.Items.Add("Avensis");
                    CmboxSeri.Items.Add("Corolla");
                    CmboxSeri.Items.Add("Auris");
                    CmboxSeri.Items.Add("Yaris");
                }
                if (CmboxMarka.SelectedIndex == 31)//volswagen
                {
                    CmboxSeri.Items.Add("Jetta");
                    CmboxSeri.Items.Add("Polo");
                    CmboxSeri.Items.Add("Golf");
                    CmboxSeri.Items.Add("Passat");
                    CmboxSeri.Items.Add("CC");
                    CmboxSeri.Items.Add("Arteon");
                }
                if (CmboxMarka.SelectedIndex == 32)//volvo
                {
                    CmboxSeri.Items.Add("V40");
                    CmboxSeri.Items.Add("S60");
                    CmboxSeri.Items.Add("S90");
                }
                
            }
            catch 
            {
                
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAracListele aracListe= new FrmAracListele(); 
            aracListe.ShowDialog();
        }
    }
    public class CmboxItem
    {
        public string Text { get; set; }


        public CmboxItem(string text)
        {
            Text = text;

        }

        public override string ToString()
        {
            return Text;
        }
    }
}
