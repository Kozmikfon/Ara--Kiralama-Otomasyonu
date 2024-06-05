namespace GaleriOtomasyonu
{
    partial class FrmAracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmboxAraclar = new System.Windows.Forms.ComboBox();
            this.MsktexModel = new System.Windows.Forms.MaskedTextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CmboxYakit = new System.Windows.Forms.ComboBox();
            this.CmboxSeri = new System.Windows.Forms.ComboBox();
            this.CmboxMarka = new System.Windows.Forms.ComboBox();
            this.TxtKira = new System.Windows.Forms.TextBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTramer = new System.Windows.Forms.TextBox();
            this.DateTimPMuayene = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CmboxVites = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnResimDegis = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtKapora = new System.Windows.Forms.TextBox();
            this.BtnAracTeslim = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CmboxAraclar
            // 
            this.CmboxAraclar.FormattingEnabled = true;
            this.CmboxAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.CmboxAraclar.Location = new System.Drawing.Point(900, 17);
            this.CmboxAraclar.Name = "CmboxAraclar";
            this.CmboxAraclar.Size = new System.Drawing.Size(142, 28);
            this.CmboxAraclar.TabIndex = 1;
            this.CmboxAraclar.SelectedIndexChanged += new System.EventHandler(this.CmboxAraclar_SelectedIndexChanged);
            // 
            // MsktexModel
            // 
            this.MsktexModel.Location = new System.Drawing.Point(134, 147);
            this.MsktexModel.Mask = "0000";
            this.MsktexModel.Name = "MsktexModel";
            this.MsktexModel.Size = new System.Drawing.Size(121, 26);
            this.MsktexModel.TabIndex = 37;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.jpeg");
            this.ımageList1.Images.SetKeyName(1, "değiştir.png");
            this.ımageList1.Images.SetKeyName(2, "cıkış.png");
            this.ımageList1.Images.SetKeyName(3, "png-transparent-firefox-computer-icons-computer-software-patch-update-button-comp" +
        "uter-network-trademark-computer-wallpaper-thumbnail.png");
            // 
            // CmboxYakit
            // 
            this.CmboxYakit.FormattingEnabled = true;
            this.CmboxYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzinli",
            "Benzin/LPG",
            "Elektrikli",
            "LPG"});
            this.CmboxYakit.Location = new System.Drawing.Point(134, 273);
            this.CmboxYakit.Name = "CmboxYakit";
            this.CmboxYakit.Size = new System.Drawing.Size(121, 28);
            this.CmboxYakit.TabIndex = 32;
            // 
            // CmboxSeri
            // 
            this.CmboxSeri.FormattingEnabled = true;
            this.CmboxSeri.Location = new System.Drawing.Point(134, 103);
            this.CmboxSeri.Name = "CmboxSeri";
            this.CmboxSeri.Size = new System.Drawing.Size(121, 28);
            this.CmboxSeri.TabIndex = 31;
            // 
            // CmboxMarka
            // 
            this.CmboxMarka.FormattingEnabled = true;
            this.CmboxMarka.Items.AddRange(new object[] {
            "AUDI",
            "BMW",
            "MERCEDES",
            "RENAULT",
            "OPEL",
            "FIAT",
            "FORD"});
            this.CmboxMarka.Location = new System.Drawing.Point(134, 59);
            this.CmboxMarka.Name = "CmboxMarka";
            this.CmboxMarka.Size = new System.Drawing.Size(121, 28);
            this.CmboxMarka.TabIndex = 30;
            this.CmboxMarka.SelectedIndexChanged += new System.EventHandler(this.CmboxMarka_SelectedIndexChanged);
            // 
            // TxtKira
            // 
            this.TxtKira.Location = new System.Drawing.Point(134, 317);
            this.TxtKira.Name = "TxtKira";
            this.TxtKira.Size = new System.Drawing.Size(121, 26);
            this.TxtKira.TabIndex = 29;
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(134, 231);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(121, 26);
            this.TxtRenk.TabIndex = 28;
            // 
            // TxtKm
            // 
            this.TxtKm.Location = new System.Drawing.Point(134, 189);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(121, 26);
            this.TxtKm.TabIndex = 27;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(134, 17);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(121, 26);
            this.TxtPlaka.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Model Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plaka";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tramer Kaydı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Muayene Tarihi";
            // 
            // TxtTramer
            // 
            this.TxtTramer.Location = new System.Drawing.Point(134, 441);
            this.TxtTramer.Name = "TxtTramer";
            this.TxtTramer.Size = new System.Drawing.Size(119, 26);
            this.TxtTramer.TabIndex = 42;
            // 
            // DateTimPMuayene
            // 
            this.DateTimPMuayene.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimPMuayene.Location = new System.Drawing.Point(134, 483);
            this.DateTimPMuayene.Name = "DateTimPMuayene";
            this.DateTimPMuayene.Size = new System.Drawing.Size(121, 26);
            this.DateTimPMuayene.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(13, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Vites Türü";
            // 
            // CmboxVites
            // 
            this.CmboxVites.FormattingEnabled = true;
            this.CmboxVites.Items.AddRange(new object[] {
            "Otomatik Vites",
            "Manuel Vites",
            "Yarı Otomatik Vites"});
            this.CmboxVites.Location = new System.Drawing.Point(134, 398);
            this.CmboxVites.Name = "CmboxVites";
            this.CmboxVites.Size = new System.Drawing.Size(121, 28);
            this.CmboxVites.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 535);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Transparent;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSil.ImageIndex = 0;
            this.BtnSil.ImageList = this.ımageList1;
            this.BtnSil.Location = new System.Drawing.Point(721, 445);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(74, 37);
            this.BtnSil.TabIndex = 38;
            this.BtnSil.Text = "Sil";
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.BackColor = System.Drawing.Color.Transparent;
            this.Btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnİptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnİptal.ImageIndex = 2;
            this.Btnİptal.ImageList = this.ımageList1;
            this.Btnİptal.Location = new System.Drawing.Point(596, 445);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(92, 41);
            this.Btnİptal.TabIndex = 36;
            this.Btnİptal.Text = "İptal";
            this.Btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnİptal.UseVisualStyleBackColor = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuncelle.ImageIndex = 3;
            this.BtnGuncelle.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(464, 445);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(114, 41);
            this.BtnGuncelle.TabIndex = 35;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnResimDegis
            // 
            this.BtnResimDegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResimDegis.ImageIndex = 1;
            this.BtnResimDegis.ImageList = this.ımageList1;
            this.BtnResimDegis.Location = new System.Drawing.Point(285, 590);
            this.BtnResimDegis.Name = "BtnResimDegis";
            this.BtnResimDegis.Size = new System.Drawing.Size(154, 44);
            this.BtnResimDegis.TabIndex = 34;
            this.BtnResimDegis.Text = "Resim Değiştir";
            this.BtnResimDegis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnResimDegis.UseVisualStyleBackColor = true;
            this.BtnResimDegis.Click += new System.EventHandler(this.BtnResimDegis_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(13, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Kapora Miktari";
            // 
            // TxtKapora
            // 
            this.TxtKapora.Location = new System.Drawing.Point(134, 360);
            this.TxtKapora.Name = "TxtKapora";
            this.TxtKapora.Size = new System.Drawing.Size(121, 26);
            this.TxtKapora.TabIndex = 50;
            // 
            // BtnAracTeslim
            // 
            this.BtnAracTeslim.BackColor = System.Drawing.Color.Transparent;
            this.BtnAracTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAracTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracTeslim.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnAracTeslim.Location = new System.Drawing.Point(890, 551);
            this.BtnAracTeslim.Name = "BtnAracTeslim";
            this.BtnAracTeslim.Size = new System.Drawing.Size(142, 37);
            this.BtnAracTeslim.TabIndex = 48;
            this.BtnAracTeslim.Text = "Araç teslim al";
            this.BtnAracTeslim.UseVisualStyleBackColor = false;
            this.BtnAracTeslim.Click += new System.EventHandler(this.BtnAracTeslim_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.Transparent;
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGeri.Location = new System.Drawing.Point(12, 701);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(76, 32);
            this.BtnGeri.TabIndex = 51;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // FrmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::GaleriOtomasyonu.Properties.Resources.Automotive__Poster__Landscape__;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 745);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.TxtKapora);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAracTeslim);
            this.Controls.Add(this.CmboxVites);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTimPMuayene);
            this.Controls.Add(this.TxtTramer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.MsktexModel);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnResimDegis);
            this.Controls.Add(this.CmboxYakit);
            this.Controls.Add(this.CmboxSeri);
            this.Controls.Add(this.CmboxMarka);
            this.Controls.Add(this.TxtKira);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.TxtKm);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmboxAraclar);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmboxAraclar;
        private System.Windows.Forms.MaskedTextBox MsktexModel;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnResimDegis;
        private System.Windows.Forms.ComboBox CmboxYakit;
        private System.Windows.Forms.ComboBox CmboxSeri;
        private System.Windows.Forms.ComboBox CmboxMarka;
        private System.Windows.Forms.TextBox TxtKira;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTramer;
        private System.Windows.Forms.DateTimePicker DateTimPMuayene;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmboxVites;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtKapora;
        private System.Windows.Forms.Button BtnAracTeslim;
        private System.Windows.Forms.Button BtnGeri;
    }
}