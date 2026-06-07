namespace CHaos
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.solpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPdfAktar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogm = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnglm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.navbar = new Guna.UI2.WinForms.Guna2Panel();
            this.kptBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlEngel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatusUyg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uygPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUygKaldir = new Guna.UI2.WinForms.Guna2Button();
            this.btnUygEkle = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEngellemeBaslat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerEngelleme = new System.Windows.Forms.Timer(this.components);
            this.lblKpat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.solpanel.SuspendLayout();
            this.navbar.SuspendLayout();
            this.pnlEngel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // solpanel
            // 
            this.solpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.solpanel.Controls.Add(this.btnPdfAktar);
            this.solpanel.Controls.Add(this.btnLogm);
            this.solpanel.Controls.Add(this.btnEnglm);
            this.solpanel.Location = new System.Drawing.Point(-20, 33);
            this.solpanel.Margin = new System.Windows.Forms.Padding(0);
            this.solpanel.Name = "solpanel";
            this.solpanel.Size = new System.Drawing.Size(280, 670);
            this.solpanel.TabIndex = 0;
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPdfAktar.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.btnPdfAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfAktar.Image")));
            this.btnPdfAktar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPdfAktar.ImageRotate = 0F;
            this.btnPdfAktar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPdfAktar.Location = new System.Drawing.Point(109, 365);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPdfAktar.Size = new System.Drawing.Size(40, 40);
            this.btnPdfAktar.TabIndex = 2;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // btnLogm
            // 
            this.btnLogm.Animated = true;
            this.btnLogm.BorderRadius = 12;
            this.btnLogm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogm.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogm.ForeColor = System.Drawing.Color.White;
            this.btnLogm.Image = ((System.Drawing.Image)(resources.GetObject("btnLogm.Image")));
            this.btnLogm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogm.ImageSize = new System.Drawing.Size(60, 60);
            this.btnLogm.Location = new System.Drawing.Point(-10, 286);
            this.btnLogm.Name = "btnLogm";
            this.btnLogm.Size = new System.Drawing.Size(277, 67);
            this.btnLogm.TabIndex = 3;
            this.btnLogm.Text = "Log";
            this.btnLogm.Click += new System.EventHandler(this.btnLogm_Click);
            // 
            // btnEnglm
            // 
            this.btnEnglm.Animated = true;
            this.btnEnglm.BorderRadius = 12;
            this.btnEnglm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnglm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnglm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnglm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnglm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnglm.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnglm.ForeColor = System.Drawing.Color.White;
            this.btnEnglm.Image = ((System.Drawing.Image)(resources.GetObject("btnEnglm.Image")));
            this.btnEnglm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEnglm.ImageSize = new System.Drawing.Size(60, 60);
            this.btnEnglm.Location = new System.Drawing.Point(-10, 200);
            this.btnEnglm.Name = "btnEnglm";
            this.btnEnglm.Size = new System.Drawing.Size(277, 67);
            this.btnEnglm.TabIndex = 2;
            this.btnEnglm.Text = "Engelleyici";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.solpanel;
            // 
            // navbar
            // 
            this.navbar.Controls.Add(this.lblKpat);
            this.navbar.Controls.Add(this.kptBtn);
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Margin = new System.Windows.Forms.Padding(0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1300, 30);
            this.navbar.TabIndex = 1;
            // 
            // kptBtn
            // 
            this.kptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kptBtn.Animated = true;
            this.kptBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kptBtn.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.kptBtn.IconColor = System.Drawing.Color.White;
            this.kptBtn.Location = new System.Drawing.Point(1245, 0);
            this.kptBtn.Margin = new System.Windows.Forms.Padding(0);
            this.kptBtn.Name = "kptBtn";
            this.kptBtn.Size = new System.Drawing.Size(55, 30);
            this.kptBtn.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.navbar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlEngel
            // 
            this.pnlEngel.Controls.Add(this.lblStatusUyg);
            this.pnlEngel.Controls.Add(this.uygPanel);
            this.pnlEngel.Controls.Add(this.btnUygKaldir);
            this.pnlEngel.Controls.Add(this.btnUygEkle);
            this.pnlEngel.Controls.Add(this.lblStatus);
            this.pnlEngel.Controls.Add(this.btnEngellemeBaslat);
            this.pnlEngel.Location = new System.Drawing.Point(263, 33);
            this.pnlEngel.Name = "pnlEngel";
            this.pnlEngel.Size = new System.Drawing.Size(1037, 670);
            this.pnlEngel.TabIndex = 2;
            // 
            // lblStatusUyg
            // 
            this.lblStatusUyg.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusUyg.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusUyg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusUyg.Location = new System.Drawing.Point(149, 436);
            this.lblStatusUyg.Name = "lblStatusUyg";
            this.lblStatusUyg.Size = new System.Drawing.Size(366, 36);
            this.lblStatusUyg.TabIndex = 6;
            this.lblStatusUyg.Text = "[!] Seçili uygulamalar kaldırılacaktır";
            this.lblStatusUyg.Visible = false;
            // 
            // uygPanel
            // 
            this.uygPanel.AutoScroll = true;
            this.uygPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uygPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uygPanel.Location = new System.Drawing.Point(117, 21);
            this.uygPanel.Name = "uygPanel";
            this.uygPanel.Size = new System.Drawing.Size(790, 390);
            this.uygPanel.TabIndex = 5;
            // 
            // btnUygKaldir
            // 
            this.btnUygKaldir.BorderRadius = 12;
            this.btnUygKaldir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUygKaldir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUygKaldir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUygKaldir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUygKaldir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUygKaldir.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.btnUygKaldir.ForeColor = System.Drawing.Color.White;
            this.btnUygKaldir.Location = new System.Drawing.Point(540, 433);
            this.btnUygKaldir.Name = "btnUygKaldir";
            this.btnUygKaldir.Size = new System.Drawing.Size(180, 45);
            this.btnUygKaldir.TabIndex = 4;
            this.btnUygKaldir.Text = "Uygulama Kaldır";
            this.btnUygKaldir.Click += new System.EventHandler(this.btnUygKaldir_Click);
            this.btnUygKaldir.MouseEnter += new System.EventHandler(this.btnUygKaldir_MouseEnter);
            this.btnUygKaldir.MouseLeave += new System.EventHandler(this.btnUygKaldir_MouseLeave);
            // 
            // btnUygEkle
            // 
            this.btnUygEkle.Animated = true;
            this.btnUygEkle.BorderRadius = 12;
            this.btnUygEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUygEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUygEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUygEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUygEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUygEkle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygEkle.ForeColor = System.Drawing.Color.White;
            this.btnUygEkle.Location = new System.Drawing.Point(726, 433);
            this.btnUygEkle.Name = "btnUygEkle";
            this.btnUygEkle.Size = new System.Drawing.Size(180, 45);
            this.btnUygEkle.TabIndex = 3;
            this.btnUygEkle.Text = "Uygulama Ekle";
            this.btnUygEkle.Click += new System.EventHandler(this.btnUygEkle_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(3, 610);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(751, 57);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = null;
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEngellemeBaslat
            // 
            this.btnEngellemeBaslat.Animated = true;
            this.btnEngellemeBaslat.BorderRadius = 12;
            this.btnEngellemeBaslat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEngellemeBaslat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEngellemeBaslat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEngellemeBaslat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEngellemeBaslat.FillColor = System.Drawing.Color.SpringGreen;
            this.btnEngellemeBaslat.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEngellemeBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnEngellemeBaslat.Location = new System.Drawing.Point(774, 610);
            this.btnEngellemeBaslat.Name = "btnEngellemeBaslat";
            this.btnEngellemeBaslat.Size = new System.Drawing.Size(251, 45);
            this.btnEngellemeBaslat.TabIndex = 0;
            this.btnEngellemeBaslat.Text = "Engellemeyi Başlat!";
            this.btnEngellemeBaslat.Click += new System.EventHandler(this.btnEngellebaslat_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.uygPanel;
            // 
            // timerEngelleme
            // 
            this.timerEngelleme.Tick += new System.EventHandler(this.timerEngelleme_Tick);
            // 
            // lblKpat
            // 
            this.lblKpat.AutoSize = false;
            this.lblKpat.BackColor = System.Drawing.Color.Transparent;
            this.lblKpat.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKpat.ForeColor = System.Drawing.Color.Red;
            this.lblKpat.Location = new System.Drawing.Point(846, 3);
            this.lblKpat.Name = "lblKpat";
            this.lblKpat.Size = new System.Drawing.Size(451, 27);
            this.lblKpat.TabIndex = 3;
            this.lblKpat.Text = "[!] Uygulama durdurulmadan program kapatılamaz";
            this.lblKpat.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlEngel);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.solpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.solpanel.ResumeLayout(false);
            this.navbar.ResumeLayout(false);
            this.pnlEngel.ResumeLayout(false);
            this.pnlEngel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel solpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel navbar;
        private Guna.UI2.WinForms.Guna2ControlBox kptBtn;
        private Guna.UI2.WinForms.Guna2Button btnLogm;
        private Guna.UI2.WinForms.Guna2Button btnEnglm;
        private Guna.UI2.WinForms.Guna2ImageButton btnPdfAktar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnlEngel;
        private Guna.UI2.WinForms.Guna2Button btnEngellemeBaslat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnUygKaldir;
        private Guna.UI2.WinForms.Guna2Button btnUygEkle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel uygPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusUyg;
        private System.Windows.Forms.Timer timerEngelleme;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKpat;
    }
}