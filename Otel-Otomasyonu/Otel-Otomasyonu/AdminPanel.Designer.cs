namespace Otel_Otomasyonu
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.KullanıcıKutu = new System.Windows.Forms.TextBox();
            this.ŞifreKutu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButon = new System.Windows.Forms.Button();
            this.CikisButon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KullanıcıKutu
            // 
            this.KullanıcıKutu.Location = new System.Drawing.Point(295, 42);
            this.KullanıcıKutu.Name = "KullanıcıKutu";
            this.KullanıcıKutu.Size = new System.Drawing.Size(138, 20);
            this.KullanıcıKutu.TabIndex = 0;
            // 
            // ŞifreKutu
            // 
            this.ŞifreKutu.Location = new System.Drawing.Point(295, 94);
            this.ŞifreKutu.Name = "ŞifreKutu";
            this.ŞifreKutu.PasswordChar = '*';
            this.ŞifreKutu.Size = new System.Drawing.Size(138, 20);
            this.ŞifreKutu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(166, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(166, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // GirisButon
            // 
            this.GirisButon.BackColor = System.Drawing.Color.Snow;
            this.GirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisButon.BackgroundImage")));
            this.GirisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GirisButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GirisButon.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GirisButon.Location = new System.Drawing.Point(204, 148);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(84, 36);
            this.GirisButon.TabIndex = 4;
            this.GirisButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GirisButon.UseVisualStyleBackColor = true;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // CikisButon
            // 
            this.CikisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CikisButon.BackgroundImage")));
            this.CikisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CikisButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CikisButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CikisButon.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CikisButon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CikisButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CikisButon.Location = new System.Drawing.Point(311, 148);
            this.CikisButon.Name = "CikisButon";
            this.CikisButon.Size = new System.Drawing.Size(91, 36);
            this.CikisButon.TabIndex = 5;
            this.CikisButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CikisButon.UseVisualStyleBackColor = true;
            this.CikisButon.Click += new System.EventHandler(this.CikisButon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminPanel
            // 
            this.AcceptButton = this.GirisButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.CikisButon;
            this.ClientSize = new System.Drawing.Size(445, 216);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CikisButon);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ŞifreKutu);
            this.Controls.Add(this.KullanıcıKutu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullanıcıKutu;
        private System.Windows.Forms.TextBox ŞifreKutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.Button CikisButon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}