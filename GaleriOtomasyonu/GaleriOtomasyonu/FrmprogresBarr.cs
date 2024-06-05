using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class FrmprogresBarr : Form
    {
        public FrmprogresBarr()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private int countdownValue = 4;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geri sayımı güncelle
            countdownValue--;

            // Label'ı güncelle
            lblsayı.Text = countdownValue.ToString();

            // ProgressBar'ı ilerlet
            progressBar1.PerformStep();

            // Geri sayım bittiğinde Timer'ı durdur
            if (countdownValue == 0)
            {
                timer1.Stop();

                FrmSozlesme yeni = new FrmSozlesme();
                this.Hide();
                yeni.Show();

            }
        }

        private void FrmprogresBarr_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblsayı.Text = "0";
        }
    }
}
