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
    public partial class FrmCikis : Form
    {
        public FrmCikis()
        {
            InitializeComponent();
        }

        private void FrmCikis_Load(object sender, EventArgs e)
        {
            ProgressBCikis.Value = 0;
            TimerCikis.Start();

        }

        private void TimerCikis_Tick(object sender, EventArgs e)
        {
            if (ProgressBCikis.Value==100)
            {
                TimerCikis.Stop();
                MessageBox.Show("Bizi tercih etiğiniz için teşekkürler, İyi günler Dileriz ☺");
                Application.Exit();   
            }
            else if (ProgressBCikis.Value<100)
            {
                ProgressBCikis.Increment(25);
            }
        }
    }
}
