using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CHaos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        private List<string> olayGecmisi = new List<string>();
        LogForm logEkrani;


        private void btnUygEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Çalıştırılabilir Dosyalar (*.exe)|*.exe";
            ofd.Title = "Engellenecek Uygulamayı Seçin";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = ofd.FileName;

                
                foreach (Control ctrl in uygPanel.Controls)
                {
                   
                    if (ctrl is Guna.UI2.WinForms.Guna2CheckBox mevcutCb && mevcutCb.Tag != null)
                    {
                       
                        if (mevcutCb.Tag.ToString() == secilenDosyaYolu)
                        {
                            MessageBox.Show("Bu uygulama zaten listeye eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }
                    }
                }

                Guna.UI2.WinForms.Guna2CheckBox cb = new Guna.UI2.WinForms.Guna2CheckBox();

               
                cb.Text = "  " + System.IO.Path.GetFileName(secilenDosyaYolu);
                cb.Tag = secilenDosyaYolu;

                
                try
                {
                    Icon appIcon = System.Drawing.Icon.ExtractAssociatedIcon(secilenDosyaYolu);
                    if (appIcon != null)
                    {
                       
                        Bitmap orjinalIkon = new Bitmap(appIcon.ToBitmap(), new Size(24, 24));

                       
                        Bitmap boslukluIkon = new Bitmap(34, 24);

                        using (Graphics g = Graphics.FromImage(boslukluIkon))
                        {
                            
                            g.DrawImage(orjinalIkon, new Point(10, 0));
                        }

                        cb.Image = boslukluIkon; 

                        cb.TextImageRelation = TextImageRelation.ImageBeforeText;
                        cb.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
                catch
                {
                   
                }

                
                cb.AutoSize = true;
                cb.Margin = new Padding(8);
                cb.Cursor = Cursors.Hand;

                cb.Animated = true;
                cb.Font = new Font("Poppins", 13F, FontStyle.Regular);
                cb.ForeColor = System.Drawing.Color.White;

               
                cb.UncheckedState.BorderRadius = 4;
                cb.UncheckedState.BorderThickness = 2;
                cb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
                cb.UncheckedState.FillColor = System.Drawing.Color.Transparent;

              
                cb.CheckedState.BorderRadius = 4;
                cb.CheckedState.BorderThickness = 0;
                cb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                cb.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);

                uygPanel.Controls.Add(cb);
            }
        }

        

       


        private void btnUygKaldir_Click(object sender, EventArgs e)
        {
       
            for (int i = uygPanel.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = uygPanel.Controls[i];

               
                if (ctrl is Guna.UI2.WinForms.Guna2CheckBox cb && cb.Checked)
                {
                    uygPanel.Controls.Remove(ctrl); 
                    cb.Dispose(); 
                }
            }
        }

        private void btnUygKaldir_MouseEnter(object sender, EventArgs e)
        {
            lblStatusUyg.Visible = true;
        }

        private void btnUygKaldir_MouseLeave(object sender, EventArgs e)
        {
            lblStatusUyg.Visible = false;
        }

        private void DurumGuncelle(string mesaj, System.Drawing.Color renk)
        {
            lblStatus.Text = mesaj;
            lblStatus.ForeColor = renk;

            olayGecmisi.Add($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {mesaj}");

            string logMesaji = $"[{DateTime.Now:HH:mm:ss}] - {mesaj}";
            olayGecmisi.Add(logMesaji);

            if (logEkrani != null && !logEkrani.IsDisposed)
            {
                logEkrani.LogEkle(logMesaji);
            }

        }


        private void btnEngellebaslat_Click(object sender, EventArgs e)
        {
            if (timerEngelleme.Enabled)
            {
                btnUygEkle.Enabled = true;
                btnUygKaldir.Enabled = true;
                uygPanel.Enabled = true;
                kptBtn.Visible = true;
                btnPdfAktar.Enabled = true;
                lblKpat.Visible = false;

                timerEngelleme.Stop();
                btnEngellemeBaslat.Text = "Engellemeyi Başlat";
                DurumGuncelle("Program Durduruldu.", System.Drawing.Color.LightGray);
            }
            else
            {
                
                bool seciliUygulamaVarMi = false;

                foreach (Control ctrl in uygPanel.Controls)
                {
                    if (ctrl is Guna.UI2.WinForms.Guna2CheckBox cb && cb.Checked)
                    {
                        seciliUygulamaVarMi = true;
                        break; 
                    }
                }

               
                if (!seciliUygulamaVarMi)
                {
                    DurumGuncelle("Lütfen engellemek için en az 1 uygulama seç!", System.Drawing.Color.Orange);
                    return;
                }

                btnUygEkle.Enabled = false;
                btnUygKaldir.Enabled = false;
                uygPanel.Enabled = false;
                kptBtn.Visible = false;
                btnPdfAktar.Enabled= false;
                lblKpat.Visible = true;

                timerEngelleme.Start();
                btnEngellemeBaslat.Text = "Engellemeyi Durdur";
                DurumGuncelle("Program Çalışıyor...", System.Drawing.Color.LimeGreen);
            }
        }

        private void timerEngelleme_Tick(object sender, EventArgs e)
        {
            foreach (Control ctrl in uygPanel.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2CheckBox cb && cb.Tag != null && cb.Checked)
                {
                    string exeAdi = System.IO.Path.GetFileNameWithoutExtension(cb.Tag.ToString());
                    Process[] calisanUygulamalar = Process.GetProcessesByName(exeAdi);

                    if (calisanUygulamalar.Length > 0)
                    {
                        bool enAzBirTanesiKapatildi = false;

                        foreach (Process islem in calisanUygulamalar)
                        {
                            try
                            {
                                
                                if (!islem.HasExited)
                                {
                                    islem.Kill();
                                    enAzBirTanesiKapatildi = true; 
                                }
                            }
                            catch
                            {
                                // CAPO BAŞKAN FİX 
                            }
                        }
                        if (enAzBirTanesiKapatildi)
                        {
                            DurumGuncelle($"[{DateTime.Now.ToShortTimeString()}] {exeAdi}.exe yakalandı ve kapatıldı!", System.Drawing.Color.Tomato);
                        }
                    }
                }
            }
        }

        /*
         
            PDF SİSTEMİNİN 
   

         */
        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
            if (olayGecmisi.Count == 0)
            {
                DurumGuncelle("Dışarı aktarılacak bir olay geçmişi yok!", System.Drawing.Color.Orange);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.FileName = "Log_" + DateTime.Now.ToString("ddMMyyyy_HHmm");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        using (PdfWriter writer = new PdfWriter(fs))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                Document document = new Document(pdf);


                                PdfFont turkishFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, "CP1254");

                               
                                Paragraph header = new Paragraph("LOG RAPORU")
                                    .SetFont(turkishFont)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(16)
                                    .SetFontColor(ColorConstants.BLUE);
                                document.Add(header);

                               
                                document.Add(new Paragraph($"Log Tarihi: {DateTime.Now}")
                                    .SetFont(turkishFont)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(10));

                                
                                document.Add(new Paragraph("---------------------------------------------------------")
                                    .SetTextAlignment(TextAlignment.CENTER));
                                document.Add(new Paragraph("\n"));

                                
                                foreach (var log in olayGecmisi)
                                {
                                    document.Add(new Paragraph(log)
                                        .SetFont(turkishFont)
                                        .SetFontSize(11));
                                }

                                document.Close();
                            }
                        }
                    }
                    DurumGuncelle("Rapor başarıyla PDF olarak kaydedildi!", System.Drawing.Color.LimeGreen);
                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    
                    string detay = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    DurumGuncelle("PDF Hatası: " + detay, System.Drawing.Color.Red);
                    MessageBox.Show(ex.ToString(), "Hata Detayı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogm_Click(object sender, EventArgs e)
        {
            if (logEkrani == null || logEkrani.IsDisposed)
            {
                logEkrani = new LogForm();
            }

            logEkrani.Show(); 
            logEkrani.BringToFront(); 
        }
    }
}

