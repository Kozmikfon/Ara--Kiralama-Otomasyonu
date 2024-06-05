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
    public partial class FrmAracListele : Form
    {
        private string selectedAraba;
        private string selectedSeri;
        AracIslemleri aracislem=new AracIslemleri();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\galeriKisiselbilgi.mdb");
        public FrmAracListele()
        {
            InitializeComponent();
            
        }
        
        private void LoadDataToDataGridView()
        {
            // Seçilen araba ve seriye göre verileri çek
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            
            TxtPlaka.Text = satir.Cells["Plaka"].Value.ToString();
            CmboxMarka.Text = satir.Cells["Marka"].Value.ToString();
            CmboxSeri.Text = satir.Cells["Seri"].Value.ToString();
            MsktexModel.Text = satir.Cells["ModelYili"].Value.ToString();
            TxtRenk.Text = satir.Cells["Renk"].Value.ToString();
            TxtKm.Text = satir.Cells["Km"].Value.ToString();            
            CmboxYakit.Text = satir.Cells["Yakit"].Value.ToString();
            TxtKira.Text = satir.Cells["KiraUcreti"].Value.ToString();           
            pictureBox1.ImageLocation = satir.Cells["Resim"].Value.ToString();
            CmboxVites.Text = satir.Cells["VitesTuru"].Value.ToString();
            DateTimPMuayene.Text = satir.Cells["Muayene"].Value.ToString();
            TxtTramer.Text = satir.Cells["HasarKaydı"].Value.ToString();

        }

        private void FrmAracListele_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            CmboxAraclar.SelectedIndex= 0;
            
        }

        private void YenileAraclarListesi()
        {
            string cumle = "Select * From AracBilgiler";
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            dataGridView1.DataSource =aracislem.Listele(adtr, cumle);
        }

        private void BtnResimDegis_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update AracBilgiler set Marka='"+CmboxMarka.Text+"', Seri='"+CmboxSeri.Text+"', ModelYili='"+MsktexModel.Text+"',  Renk='"+TxtRenk.Text+"' ,Km='"+TxtKm.Text+"',  Yakit='"+CmboxYakit.Text+"', KiraUcreti='"+TxtKira.Text+"',  Resim='"+pictureBox1.ImageLocation+"',Tarih='"+DateTime.Now.ToString()+"', KaporaMiktari='"+TxtKapora.Text+"', VitesTuru='"+CmboxVites.Text+"',Muayene='"+DateTimPMuayene.Text+"' , HasarKaydı='"+TxtTramer.Text+"' where Plaka='"+TxtPlaka.Text+"'";
            OleDbCommand komut=new OleDbCommand();
            komut.Parameters.AddWithValue("@Plaka", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", CmboxMarka.Text);
            komut.Parameters.AddWithValue("@Seri", CmboxSeri.Text);
            komut.Parameters.AddWithValue("@ModelYili", MsktexModel.Text);
            komut.Parameters.AddWithValue("@Renk", TxtRenk.Text);
            komut.Parameters.AddWithValue("@Km", TxtKm.Text);           
            komut.Parameters.AddWithValue("@Yakit", CmboxYakit.Text);
            komut.Parameters.AddWithValue("@KiraUcreti",TxtKira.Text);            
            komut.Parameters.AddWithValue("@Resim", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@KaporaMiktari",TxtKapora.Text);
            komut.Parameters.AddWithValue("@VitesTuru",CmboxVites.Text);
            komut.Parameters.AddWithValue("@Muayene", DateTimPMuayene.Text);
            komut.Parameters.AddWithValue("@HasarKaydı",TxtTramer.Text);
            
            aracislem.EkleSilGuncelle(komut,cumle);
            CmboxSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraclarListesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "Delete From AracBilgiler where Plaka='" + satir.Cells["Plaka"].Value.ToString() +"'";
            OleDbCommand komut = new OleDbCommand();
            aracislem.EkleSilGuncelle(komut,cumle);
            CmboxSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
            
            YenileAraclarListesi();
        }

        private void CmboxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmboxSeri.Items.Clear();
                if (CmboxMarka.SelectedIndex == 0)
                {
                    CmboxSeri.Items.Add("A4");
                    CmboxSeri.Items.Add("A5");
                    CmboxSeri.Items.Add("A6");
                    CmboxSeri.Items.Add("A7");
                }
                else if (CmboxMarka.SelectedIndex == 1)
                {
                    CmboxSeri.Items.Add("M3");
                    CmboxSeri.Items.Add("M4");
                    CmboxSeri.Items.Add("M5");
                    CmboxSeri.Items.Add("M8");
                }
                else if (CmboxMarka.SelectedIndex == 2)
                {
                    CmboxSeri.Items.Add("C180");
                    CmboxSeri.Items.Add("C200");
                    CmboxSeri.Items.Add("E180");
                    CmboxSeri.Items.Add("E200");
                }
            }
            catch
            {
            }
        }
        private void CmboxAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                if (CmboxAraclar.SelectedIndex==0)
                {
                    YenileAraclarListesi();
                }
                if (CmboxAraclar.SelectedIndex == 1)
                {
                    string cumle = "Select * From AracBilgiler where Durumu='BOŞ' ";
                    OleDbDataAdapter adtr = new OleDbDataAdapter();
                    dataGridView1.DataSource = aracislem.Listele(adtr, cumle);
                }
                if (CmboxAraclar.SelectedIndex == 2)
                {
                    string cumle = "Select * From AracBilgiler where Durumu='DOLU' ";
                    OleDbDataAdapter adtr = new OleDbDataAdapter();
                    dataGridView1.DataSource = aracislem.Listele(adtr, cumle);
                }
            }
            catch
            {            
            }
        }

        private void BtnAracTeslim_Click(object sender, EventArgs e)
        {
            FrmSozlesme sozlesme = new FrmSozlesme();
            sozlesme.ShowDialog();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.ShowDialog();
        }
    }
}
