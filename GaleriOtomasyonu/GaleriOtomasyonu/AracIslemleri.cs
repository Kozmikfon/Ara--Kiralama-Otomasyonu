using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    internal class AracIslemleri
    {
        OleDbConnection baglanti=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\galeriKisiselbilgi.mdb");
      

        public void EkleSilGuncelle(OleDbCommand komut, string sorgu)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.Connection=baglanti;
            komut.CommandText=sorgu;
            komut.ExecuteNonQuery();
            
            baglanti.Close();
        }
        
        

        public DataTable Listele(OleDbDataAdapter adtr, string sorgu)
        {
           
            
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            adtr = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            
            baglanti.Close();
            return tablo;
        }
        public void BosAraclar(ComboBox combo,string sorgu)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu,baglanti);
            OleDbDataReader read=komut.ExecuteReader(); 
            while (read.Read()) 
            {
                combo.Items.Add(read["Plaka"].ToString());
            }
            baglanti.Close();

        }
        public void TcAra(MaskedTextBox TcAra, TextBox Tc, TextBox Ad,TextBox Soyad , TextBox mail, TextBox ehliyetno, TextBox ehliyetyer, string sorgu)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Tc.Text = read["Tc"].ToString();
                Ad.Text = read["Ad"].ToString();
                Soyad.Text = read["Soyad"].ToString();
                mail.Text = read["Mail"].ToString();
                ehliyetno.Text = read["EhliyetNo"].ToString();
                ehliyetyer.Text = read["E_Yer"].ToString();
            }
            baglanti.Close();
        }
        public void CombodanGetir(ComboBox araclar, ComboBox marka, ComboBox seri, TextBox yil, ComboBox renk,TextBox kapora,TextBox tramer, DateTimePicker muayene, string sorgu)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["Marka"].ToString();
                seri.Text = read["Seri"].ToString();
                yil.Text = read["ModelYili"].ToString();
                renk.Text = read["Renk"].ToString();
                kapora.Text = read["KaporaMiktari"].ToString();
                tramer.Text = read["HasarKaydı"].ToString();
                muayene.Text = read["Muayene"].ToString();
            }
            baglanti.Close();

        }
        public void UcretHesapla(ComboBox CmboxKiraSekli, TextBox Ucret,  string sorgu)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if(CmboxKiraSekli.SelectedIndex == 0) Ucret.Text = (int.Parse(read["KiraUcreti"].ToString()) * 1).ToString();
                if(CmboxKiraSekli.SelectedIndex == 1) Ucret.Text = (int.Parse(read["KiraUcreti"].ToString())*0.80).ToString();
                if(CmboxKiraSekli.SelectedIndex == 2) Ucret.Text = (int.Parse(read["KiraUcreti"].ToString()) * 0.70).ToString();
            }
            baglanti.Close();
        }
        


    }
    
}
