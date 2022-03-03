using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible= false;
            QRCodeEncoder encoder = new QRCodeEncoder();
            pb1.Image = encoder.Encode("https://4lphasoftware.com");    // Metnimizi Encode metoduyla QR koda dönüştürüyoruz.
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder(); // QR Code kütüphanemizi yaratıyoruz.

            if (txtqr.Text != "")
            {
                pb1.Image = encoder.Encode(txtqr.Text);    // Metnimizi Encode metoduyla QR koda dönüştürüyoruz.
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Lütfen Kare Koda Dönüştürülecek Olan Veriyi Giriniz.", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_indir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Application.ExecutablePath;
            saveDialog.Title = "QR Kod Kaydet";
            saveDialog.Filter = "PNG Dosyaları(*.png)|*.png|BMP dosyaları(*.bmp)|*.bmp";
            saveDialog.DefaultExt = "*.png";
            saveDialog.FileName = txtqr.Text+".png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (pb1.Image != null)
                {
                    pb1.Image.Save(saveDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Lütfen İndirmek İçin Bir Kare Kod Oluşturun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_icerik_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeDecoder dnc = new QRCodeDecoder();
                if (pb1.Image != null)
                {
                    string a;
                    a = dnc.Decode(new QRCodeBitmapImage(pb1.Image as Bitmap));
                    DialogResult dügme = MessageBox.Show("Google 'da Aransın mı ? \n\n İÇERİK: " + a , "Kare Kod İçeriği",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (dügme==DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(a);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen *PNG Uzantılı Geçerli Bir Kare Kod Dosyası Seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen *PNG Uzantılı Geçerli Bir Kare Kod Dosyası Seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_okut_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Dosyaları(*.jpg)|*.jpg|PNG Dosyaları(*.png)|*.png";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "PNG Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                // dosya seçildi ise
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;

                label1.Visible = true;
                label1.Text = file.FileName;
                pb1.Image = Image.FromFile(file.FileName);
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    QRCodeDecoder dnc = new QRCodeDecoder();
                    txtqr.Text = dnc.Decode(new QRCodeBitmapImage(pb1.Image as Bitmap));
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen *PNG Uzantılı Geçerli Bir Kare Kod Dosyası Seçiniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtqr.Text = "";
            pb1.Image = null;
            label1.Text = "";
            label1.Visible=false;
        }
    }
}
