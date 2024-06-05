using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GaleriOtomasyonu
{
    public partial class FrmProgresbar : Form
    {
        public FrmProgresbar()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private int countdownValue = 4;

        private void FrmProgresbar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblsayı.Text = "0";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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

                FrmSatis yeni = new FrmSatis();
                this.Hide();
                yeni.Show();

            }
        }
    }
}
