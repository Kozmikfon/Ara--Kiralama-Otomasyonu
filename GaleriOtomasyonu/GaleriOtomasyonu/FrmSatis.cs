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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GaleriOtomasyonu
{
    public partial class FrmSatis : Form
    {
        string cumle = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mahmu\\Desktop\\projeler\\galeriKisiselbilgi.mdb";
        public FrmSatis()
        {
            InitializeComponent();
        }
        AracIslemleri aracsatis = new AracIslemleri();

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriKisiselbilgiDataSet2.Kiralama' table. You can move, or remove it, as needed.
            this.kiralamaTableAdapter.Fill(this.galeriKisiselbilgiDataSet2.Kiralama);
            // TODO: This line of code loads data into the 'galeriKisiselbilgiDataSet1.Kiralama' table. You can move, or remove it, as needed.

            string sorgu = "select * from Kiralama";
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            dataGridView1.DataSource = aracsatis.Listele(adtr, sorgu);
            
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {

            if (TxtMail.Text == "")
            {
                MessageBox.Show("Mail adresi boş bırakılamaz");
            }
            else if (TxtMail.Text!= "mahmutbagl99@hotmail.com")
            {
                MessageBox.Show("Böyle bir mail bulunamamktadır");
            }
            else 
            {
                
                string mailboil = "<table widht='150%' style='border:Solid 1px Black'> ";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    mailboil += "<tr>";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        mailboil += "<td style='color:red; '>" + cell.Value + "</td>";
                    }
                    mailboil += "</tr>";
                }
                mailboil += "</table>";
                
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(TxtMail.Text);
                mesaj.From = new MailAddress("mahmutbagl99@hotmail.com", "mahmut258+");
                mesaj.Subject = ("Sİyah Hayalet kiralama");
                mesaj.IsBodyHtml = true;
                mesaj.Body = mailboil;
               
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new System.Net.NetworkCredential("mahmutbagl99@hotmail.com", "mahmut258+");
                smtp.Host = "smtp.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                mesaj.Dispose();
                FrmProgresbar prog = new FrmProgresbar();
                prog.Show();
                this.Hide();

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSozlesme sozlesme=new FrmSozlesme();
            sozlesme.ShowDialog();  
        }
    }
}





