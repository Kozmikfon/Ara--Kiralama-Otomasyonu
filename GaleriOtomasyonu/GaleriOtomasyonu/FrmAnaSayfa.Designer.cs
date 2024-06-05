namespace GaleriOtomasyonu
{
    partial class FrmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CmboxMarka = new System.Windows.Forms.ComboBox();
            this.CmboxSeri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAracList = new System.Windows.Forms.Button();
            this.BtnSatıs = new System.Windows.Forms.Button();
            this.BtnMusteriGiris = new System.Windows.Forms.Button();
            this.BtnYonetici = new System.Windows.Forms.Button();
            this.BtnMusteriLis = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnSozlesme = new System.Windows.Forms.Button();
            this.BtnAracKayit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "müşteriLİST.jpg");
            this.ımageList1.Images.SetKeyName(1, "cıkış.png");
            this.ımageList1.Images.SetKeyName(2, "sözleşme.png");
            this.ımageList1.Images.SetKeyName(3, "araçişlem.png");
            this.ımageList1.Images.SetKeyName(4, "kullanıcıGirişi.jpeg");
            this.ımageList1.Images.SetKeyName(5, "müşteriKaydı.png");
            this.ımageList1.Images.SetKeyName(6, "araçsatışKira.png");
            this.ımageList1.Images.SetKeyName(7, "araçlistele.png");
            // 
            // CmboxMarka
            // 
            this.CmboxMarka.BackColor = System.Drawing.Color.AliceBlue;
            this.CmboxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmboxMarka.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CmboxMarka.FormattingEnabled = true;
            this.CmboxMarka.Location = new System.Drawing.Point(62, 318);
            this.CmboxMarka.Name = "CmboxMarka";
            this.CmboxMarka.Size = new System.Drawing.Size(121, 24);
            this.CmboxMarka.TabIndex = 1;
            this.CmboxMarka.Text = "Marka Seçiniz";
            this.CmboxMarka.SelectedIndexChanged += new System.EventHandler(this.CmboxMarka_SelectedIndexChanged);
            // 
            // CmboxSeri
            // 
            this.CmboxSeri.BackColor = System.Drawing.Color.Snow;
            this.CmboxSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmboxSeri.FormattingEnabled = true;
            this.CmboxSeri.Location = new System.Drawing.Point(210, 318);
            this.CmboxSeri.Name = "CmboxSeri";
            this.CmboxSeri.Size = new System.Drawing.Size(121, 24);
            this.CmboxSeri.TabIndex = 2;
            this.CmboxSeri.Text = "Model Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sizin için doğru aracı bulun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(206, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menü";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnAracList
            // 
            this.BtnAracList.BackColor = System.Drawing.Color.Transparent;
            this.BtnAracList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAracList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracList.ForeColor = System.Drawing.Color.Black;
            this.BtnAracList.Location = new System.Drawing.Point(241, 405);
            this.BtnAracList.Name = "BtnAracList";
            this.BtnAracList.Size = new System.Drawing.Size(219, 42);
            this.BtnAracList.TabIndex = 15;
            this.BtnAracList.Text = "Araç Listeleme";
            this.BtnAracList.UseVisualStyleBackColor = false;
            this.BtnAracList.Click += new System.EventHandler(this.BtnAracList_Click);
            // 
            // BtnSatıs
            // 
            this.BtnSatıs.BackColor = System.Drawing.Color.Transparent;
            this.BtnSatıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatıs.ForeColor = System.Drawing.Color.Black;
            this.BtnSatıs.Location = new System.Drawing.Point(241, 509);
            this.BtnSatıs.Name = "BtnSatıs";
            this.BtnSatıs.Size = new System.Drawing.Size(219, 40);
            this.BtnSatıs.TabIndex = 15;
            this.BtnSatıs.Text = "Kiralanan Araçlar";
            this.BtnSatıs.UseVisualStyleBackColor = false;
            this.BtnSatıs.Click += new System.EventHandler(this.BtnSatıs_Click);
            // 
            // BtnMusteriGiris
            // 
            this.BtnMusteriGiris.BackColor = System.Drawing.Color.Transparent;
            this.BtnMusteriGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriGiris.ForeColor = System.Drawing.Color.Black;
            this.BtnMusteriGiris.Location = new System.Drawing.Point(12, 405);
            this.BtnMusteriGiris.Name = "BtnMusteriGiris";
            this.BtnMusteriGiris.Size = new System.Drawing.Size(214, 42);
            this.BtnMusteriGiris.TabIndex = 17;
            this.BtnMusteriGiris.Text = "Personel Girişi";
            this.BtnMusteriGiris.UseVisualStyleBackColor = false;
            this.BtnMusteriGiris.Click += new System.EventHandler(this.BtnMusteriGiris_Click);
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.BackColor = System.Drawing.Color.Transparent;
            this.BtnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetici.ForeColor = System.Drawing.Color.Black;
            this.BtnYonetici.Location = new System.Drawing.Point(12, 452);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Size = new System.Drawing.Size(214, 46);
            this.BtnYonetici.TabIndex = 18;
            this.BtnYonetici.Text = "Yönetici İşlemleri";
            this.BtnYonetici.UseVisualStyleBackColor = false;
            this.BtnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // BtnMusteriLis
            // 
            this.BtnMusteriLis.BackColor = System.Drawing.Color.Transparent;
            this.BtnMusteriLis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusteriLis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriLis.ForeColor = System.Drawing.Color.Black;
            this.BtnMusteriLis.Location = new System.Drawing.Point(12, 504);
            this.BtnMusteriLis.Name = "BtnMusteriLis";
            this.BtnMusteriLis.Size = new System.Drawing.Size(214, 45);
            this.BtnMusteriLis.TabIndex = 19;
            this.BtnMusteriLis.Text = "Müşteri Lİsteleme";
            this.BtnMusteriLis.UseVisualStyleBackColor = false;
            this.BtnMusteriLis.Click += new System.EventHandler(this.BtnMusteriLis_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Transparent;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.Black;
            this.BtnCikis.Location = new System.Drawing.Point(241, 555);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(219, 41);
            this.BtnCikis.TabIndex = 20;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnSozlesme
            // 
            this.BtnSozlesme.BackColor = System.Drawing.Color.Transparent;
            this.BtnSozlesme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSozlesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSozlesme.ForeColor = System.Drawing.Color.Black;
            this.BtnSozlesme.Location = new System.Drawing.Point(241, 453);
            this.BtnSozlesme.Name = "BtnSozlesme";
            this.BtnSozlesme.Size = new System.Drawing.Size(219, 45);
            this.BtnSozlesme.TabIndex = 21;
            this.BtnSozlesme.Text = "Sözleşme ve Faturalar";
            this.BtnSozlesme.UseVisualStyleBackColor = false;
            this.BtnSozlesme.Click += new System.EventHandler(this.BtnSozlesme_Click);
            // 
            // BtnAracKayit
            // 
            this.BtnAracKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAracKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracKayit.Location = new System.Drawing.Point(12, 556);
            this.BtnAracKayit.Name = "BtnAracKayit";
            this.BtnAracKayit.Size = new System.Drawing.Size(214, 40);
            this.BtnAracKayit.TabIndex = 22;
            this.BtnAracKayit.Text = "Araç-Kayıt Güncelleme";
            this.BtnAracKayit.UseVisualStyleBackColor = true;
            this.BtnAracKayit.Click += new System.EventHandler(this.BtnAracKayit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GaleriOtomasyonu.Properties.Resources.Brown_Modern_Car_for_Sale_Instagram_Post__5_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BtnAracKayit);
            this.panel1.Controls.Add(this.BtnSozlesme);
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.BtnMusteriLis);
            this.panel1.Controls.Add(this.BtnYonetici);
            this.panel1.Controls.Add(this.BtnMusteriGiris);
            this.panel1.Controls.Add(this.BtnSatıs);
            this.panel1.Controls.Add(this.BtnAracList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmboxSeri);
            this.panel1.Controls.Add(this.CmboxMarka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 608);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::GaleriOtomasyonu.Properties.Resources.Brown_Modern_Car_for_Sale_Instagram_Post__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 608);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ComboBox CmboxMarka;
        private System.Windows.Forms.ComboBox CmboxSeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAracList;
        private System.Windows.Forms.Button BtnSatıs;
        private System.Windows.Forms.Button BtnMusteriGiris;
        private System.Windows.Forms.Button BtnYonetici;
        private System.Windows.Forms.Button BtnMusteriLis;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnSozlesme;
        private System.Windows.Forms.Button BtnAracKayit;
        private System.Windows.Forms.Panel panel1;
    }
}

