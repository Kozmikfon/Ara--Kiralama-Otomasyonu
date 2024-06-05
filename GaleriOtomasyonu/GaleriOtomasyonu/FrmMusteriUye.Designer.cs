namespace GaleriOtomasyonu
{
    partial class FrmMusteriUye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUye = new System.Windows.Forms.Button();
            this.MskdTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePDogum = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSoyisim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnUye);
            this.panel1.Controls.Add(this.MskdTxtTc);
            this.panel1.Controls.Add(this.dateTimePDogum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtMail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtSifre);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtSoyisim);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtIsim);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 466);
            this.panel1.TabIndex = 5;
            // 
            // BtnUye
            // 
            this.BtnUye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnUye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUye.Location = new System.Drawing.Point(84, 377);
            this.BtnUye.Name = "BtnUye";
            this.BtnUye.Size = new System.Drawing.Size(145, 34);
            this.BtnUye.TabIndex = 8;
            this.BtnUye.Text = "Üyelik Oluştur";
            this.BtnUye.UseVisualStyleBackColor = false;
            this.BtnUye.Click += new System.EventHandler(this.BtnUye_Click);
            // 
            // MskdTxtTc
            // 
            this.MskdTxtTc.Location = new System.Drawing.Point(170, 38);
            this.MskdTxtTc.Mask = "00000000000";
            this.MskdTxtTc.Name = "MskdTxtTc";
            this.MskdTxtTc.Size = new System.Drawing.Size(153, 26);
            this.MskdTxtTc.TabIndex = 7;
            this.MskdTxtTc.ValidatingType = typeof(int);
            // 
            // dateTimePDogum
            // 
            this.dateTimePDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePDogum.Location = new System.Drawing.Point(170, 197);
            this.dateTimePDogum.Name = "dateTimePDogum";
            this.dateTimePDogum.Size = new System.Drawing.Size(153, 26);
            this.dateTimePDogum.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "İsim:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(170, 250);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(153, 26);
            this.TxtMail.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soy İsim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "E-Posta Adresi:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(170, 300);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(153, 26);
            this.TxtSifre.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Yeni şifre oluşturun:";
            // 
            // TxtSoyisim
            // 
            this.TxtSoyisim.Location = new System.Drawing.Point(170, 149);
            this.TxtSoyisim.Name = "TxtSoyisim";
            this.TxtSoyisim.Size = new System.Drawing.Size(153, 26);
            this.TxtSoyisim.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(12, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "T.C kimik numarası:";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(170, 97);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(153, 26);
            this.TxtIsim.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(12, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Doğum Tarihi:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMusteriUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::GaleriOtomasyonu.Properties.Resources.Mavi_Turuncu_Modern_Minimalist_Müşteri_Hizmetleri_İş_İlanı_Instagram_Gönderisi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMusteriUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Üye Ekranı";
            this.Load += new System.EventHandler(this.FrmMusteriUye_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSoyisim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePDogum;
        private System.Windows.Forms.MaskedTextBox MskdTxtTc;
        private System.Windows.Forms.Button BtnUye;
        private System.Windows.Forms.Button button1;
    }
}