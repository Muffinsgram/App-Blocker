namespace CHaos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnKapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnTekrar = new Guna.UI2.WinForms.Guna2Button();
            this.prgLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Animated = true;
            this.btnKapat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKapat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKapat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKapat.HoverState.IconColor = System.Drawing.Color.Red;
            this.btnKapat.IconColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(565, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(45, 29);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Visible = false;
            // 
            // btnTekrar
            // 
            this.btnTekrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTekrar.Animated = true;
            this.btnTekrar.BackColor = System.Drawing.Color.Transparent;
            this.btnTekrar.BorderRadius = 11;
            this.btnTekrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTekrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTekrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTekrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTekrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTekrar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrar.ForeColor = System.Drawing.Color.White;
            this.btnTekrar.Location = new System.Drawing.Point(204, 248);
            this.btnTekrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(180, 45);
            this.btnTekrar.TabIndex = 12;
            this.btnTekrar.Text = "Tekrar Dene!";
            this.btnTekrar.UseTransparentBackground = true;
            this.btnTekrar.Visible = false;
            // 
            // prgLoading
            // 
            this.prgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgLoading.BackColor = System.Drawing.Color.Transparent;
            this.prgLoading.BorderRadius = 5;
            this.prgLoading.Location = new System.Drawing.Point(96, 262);
            this.prgLoading.Margin = new System.Windows.Forms.Padding(0);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.ProgressColor = System.Drawing.Color.Cyan;
            this.prgLoading.ProgressColor2 = System.Drawing.Color.Lime;
            this.prgLoading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prgLoading.Size = new System.Drawing.Size(400, 30);
            this.prgLoading.TabIndex = 11;
            this.prgLoading.Text = "guna2ProgressBar1";
            this.prgLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(146, 24);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(-4, 294);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(600, 50);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Podo";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btnKapat;
        private Guna.UI2.WinForms.Guna2Button btnTekrar;
        private Guna.UI2.WinForms.Guna2ProgressBar prgLoading;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}

