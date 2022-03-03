namespace QR_Code_Generator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.txtqr = new System.Windows.Forms.TextBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.btn_indir = new System.Windows.Forms.Button();
            this.btn_icerik = new System.Windows.Forms.Button();
            this.btn_okut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(358, 353);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // txtqr
            // 
            this.txtqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtqr.Location = new System.Drawing.Point(376, 32);
            this.txtqr.Multiline = true;
            this.txtqr.Name = "txtqr";
            this.txtqr.Size = new System.Drawing.Size(360, 31);
            this.txtqr.TabIndex = 1;
            // 
            // btn_olustur
            // 
            this.btn_olustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_olustur.Location = new System.Drawing.Point(409, 80);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(133, 41);
            this.btn_olustur.TabIndex = 2;
            this.btn_olustur.Text = "KARE KOD OLUŞTUR";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // btn_indir
            // 
            this.btn_indir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_indir.Location = new System.Drawing.Point(409, 140);
            this.btn_indir.Name = "btn_indir";
            this.btn_indir.Size = new System.Drawing.Size(133, 41);
            this.btn_indir.TabIndex = 3;
            this.btn_indir.Text = "KARE KODU İNDİR";
            this.btn_indir.UseVisualStyleBackColor = true;
            this.btn_indir.Click += new System.EventHandler(this.btn_indir_Click);
            // 
            // btn_icerik
            // 
            this.btn_icerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_icerik.Location = new System.Drawing.Point(409, 196);
            this.btn_icerik.Name = "btn_icerik";
            this.btn_icerik.Size = new System.Drawing.Size(133, 41);
            this.btn_icerik.TabIndex = 4;
            this.btn_icerik.Text = "KARE KOD İÇERİĞİ";
            this.btn_icerik.UseVisualStyleBackColor = true;
            this.btn_icerik.Click += new System.EventHandler(this.btn_icerik_Click);
            // 
            // btn_okut
            // 
            this.btn_okut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_okut.Location = new System.Drawing.Point(409, 254);
            this.btn_okut.Name = "btn_okut";
            this.btn_okut.Size = new System.Drawing.Size(133, 41);
            this.btn_okut.TabIndex = 5;
            this.btn_okut.Text = "KARE KOD OKUT";
            this.btn_okut.UseVisualStyleBackColor = true;
            this.btn_okut.Click += new System.EventHandler(this.btn_okut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(567, 80);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(133, 41);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.Text = "İÇERİĞİ TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_olustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 384);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_okut);
            this.Controls.Add(this.btn_icerik);
            this.Controls.Add(this.btn_indir);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.txtqr);
            this.Controls.Add(this.pb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 423);
            this.MinimumSize = new System.Drawing.Size(764, 423);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator -- 4LPHA Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txtqr;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.Button btn_indir;
        private System.Windows.Forms.Button btn_icerik;
        private System.Windows.Forms.Button btn_okut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temizle;
    }
}

