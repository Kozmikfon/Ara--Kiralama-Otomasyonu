namespace GaleriOtomasyonu
{
    partial class FrmCikis
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
            this.ProgressBCikis = new System.Windows.Forms.ProgressBar();
            this.TimerCikis = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressBCikis
            // 
            this.ProgressBCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBCikis.Location = new System.Drawing.Point(0, 0);
            this.ProgressBCikis.Name = "ProgressBCikis";
            this.ProgressBCikis.Size = new System.Drawing.Size(350, 47);
            this.ProgressBCikis.TabIndex = 0;
            // 
            // TimerCikis
            // 
            this.TimerCikis.Tick += new System.EventHandler(this.TimerCikis_Tick);
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 47);
            this.Controls.Add(this.ProgressBCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBCikis;
        private System.Windows.Forms.Timer TimerCikis;
    }
}