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
using System.Data.OleDb;

namespace GaleriOtomasyonu
{
    public partial class FrmPersonel : Form
    {
        
        AracIslemleri personel=new AracIslemleri();
        public FrmPersonel()
        {
            InitializeComponent();
        }
       
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            YenileListele();
            // TODO: Bu kod satırı 'galeriKisiselbilgiDataSet4.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.galeriKisiselbilgiDataSet4.Personel);
            // TODO: Bu kod satırı 'galeriKisiselbilgiDataSet3.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (MskedTxtTcAra.Text.Length < 11)
            {
                MessageBox.Show("Tc kimlik numarası 11 haneden düşük olamaz");
                MskedTxtTcAra.Clear();
            }
            string cumle = "Select * from Personel where Tc like '%" + MskedTxtTcAra.Text + "%'  ";// bu komut kullanıcının girdiği metin kutusundaki ifadeyi arar. 
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();


            dataGridView1.DataSource = personel.Listele(adtr2, cumle);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void YenileListele()
        {
            string cumle = "Select * from Personel";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = personel.Listele(adtr2, cumle);

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.ShowDialog();
        }
    }
}
