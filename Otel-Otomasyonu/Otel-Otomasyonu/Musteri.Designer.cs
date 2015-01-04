namespace Otel_Otomasyonu
{
    partial class MusteriEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkleForm));
            this.TCLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TcKutu = new System.Windows.Forms.TextBox();
            this.AdKutu = new System.Windows.Forms.TextBox();
            this.SoyadKutu = new System.Windows.Forms.TextBox();
            this.TelefonKutu = new System.Windows.Forms.TextBox();
            this.CinsiyetKutu = new System.Windows.Forms.TextBox();
            this.KaydetButon = new System.Windows.Forms.Button();
            this.Cikisbuton = new System.Windows.Forms.Button();
            this.EkleListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GTime = new System.Windows.Forms.DateTimePicker();
            this.CTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TCLabel.Location = new System.Drawing.Point(35, 27);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(116, 20);
            this.TCLabel.TabIndex = 0;
            this.TCLabel.Text = "Tc Kimlik No :";
            this.TCLabel.Click += new System.EventHandler(this.TCLabel_Click);
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.AdLabel.Location = new System.Drawing.Point(35, 60);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(46, 20);
            this.AdLabel.TabIndex = 1;
            this.AdLabel.Text = "Ad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TcKutu
            // 
            this.TcKutu.Location = new System.Drawing.Point(169, 29);
            this.TcKutu.Name = "TcKutu";
            this.TcKutu.Size = new System.Drawing.Size(120, 20);
            this.TcKutu.TabIndex = 5;
            this.TcKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TcKutu_KeyPress);
            // 
            // AdKutu
            // 
            this.AdKutu.Location = new System.Drawing.Point(169, 60);
            this.AdKutu.Name = "AdKutu";
            this.AdKutu.Size = new System.Drawing.Size(120, 20);
            this.AdKutu.TabIndex = 6;
            this.AdKutu.TextChanged += new System.EventHandler(this.AdKutu_TextChanged);
            this.AdKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdKutu_KeyPress);
            // 
            // SoyadKutu
            // 
            this.SoyadKutu.Location = new System.Drawing.Point(169, 92);
            this.SoyadKutu.Name = "SoyadKutu";
            this.SoyadKutu.Size = new System.Drawing.Size(120, 20);
            this.SoyadKutu.TabIndex = 7;
            this.SoyadKutu.TextChanged += new System.EventHandler(this.SoyadKutu_TextChanged);
            this.SoyadKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoyadKutu_KeyPress);
            // 
            // TelefonKutu
            // 
            this.TelefonKutu.Location = new System.Drawing.Point(169, 126);
            this.TelefonKutu.Name = "TelefonKutu";
            this.TelefonKutu.Size = new System.Drawing.Size(120, 20);
            this.TelefonKutu.TabIndex = 8;
            this.TelefonKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonKutu_KeyPress);
            // 
            // CinsiyetKutu
            // 
            this.CinsiyetKutu.Location = new System.Drawing.Point(169, 158);
            this.CinsiyetKutu.Name = "CinsiyetKutu";
            this.CinsiyetKutu.Size = new System.Drawing.Size(120, 20);
            this.CinsiyetKutu.TabIndex = 9;
            this.CinsiyetKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CinsiyetKutu_KeyPress);
            // 
            // KaydetButon
            // 
            this.KaydetButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KaydetButon.BackgroundImage")));
            this.KaydetButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KaydetButon.Location = new System.Drawing.Point(429, 156);
            this.KaydetButon.Name = "KaydetButon";
            this.KaydetButon.Size = new System.Drawing.Size(58, 42);
            this.KaydetButon.TabIndex = 10;
            this.KaydetButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KaydetButon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.KaydetButon.UseVisualStyleBackColor = true;
            this.KaydetButon.Click += new System.EventHandler(this.KaydetButon_Click);
            // 
            // Cikisbuton
            // 
            this.Cikisbuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cikisbuton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cikisbuton.BackgroundImage")));
            this.Cikisbuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cikisbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikisbuton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cikisbuton.Location = new System.Drawing.Point(521, 156);
            this.Cikisbuton.Name = "Cikisbuton";
            this.Cikisbuton.Size = new System.Drawing.Size(58, 42);
            this.Cikisbuton.TabIndex = 11;
            this.Cikisbuton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikisbuton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cikisbuton.UseVisualStyleBackColor = true;
            this.Cikisbuton.Click += new System.EventHandler(this.Cikisbuton_Click);
            // 
            // EkleListe
            // 
            this.EkleListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.EkleListe.Location = new System.Drawing.Point(12, 236);
            this.EkleListe.Name = "EkleListe";
            this.EkleListe.Size = new System.Drawing.Size(645, 222);
            this.EkleListe.TabIndex = 12;
            this.EkleListe.UseCompatibleStateImageBehavior = false;
            this.EkleListe.View = System.Windows.Forms.View.Details;
            this.EkleListe.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cinsiyet";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giriş Tarihi";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Çıkış Tarihi";
            this.columnHeader8.Width = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Çıkış Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(341, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giriş Tarihi :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GTime
            // 
            this.GTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.GTime.Location = new System.Drawing.Point(452, 61);
            this.GTime.Name = "GTime";
            this.GTime.Size = new System.Drawing.Size(200, 20);
            this.GTime.TabIndex = 17;
            // 
            // CTime
            // 
            this.CTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CTime.Location = new System.Drawing.Point(453, 92);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(200, 20);
            this.CTime.TabIndex = 18;
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(669, 470);
            this.Controls.Add(this.CTime);
            this.Controls.Add(this.GTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EkleListe);
            this.Controls.Add(this.Cikisbuton);
            this.Controls.Add(this.KaydetButon);
            this.Controls.Add(this.CinsiyetKutu);
            this.Controls.Add(this.TelefonKutu);
            this.Controls.Add(this.SoyadKutu);
            this.Controls.Add(this.AdKutu);
            this.Controls.Add(this.TcKutu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.TCLabel);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "MusteriEkleForm";
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.MusteriEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TCLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TcKutu;
        private System.Windows.Forms.TextBox AdKutu;
        private System.Windows.Forms.TextBox SoyadKutu;
        private System.Windows.Forms.TextBox TelefonKutu;
        private System.Windows.Forms.TextBox CinsiyetKutu;
        private System.Windows.Forms.Button KaydetButon;
        private System.Windows.Forms.Button Cikisbuton;
        private System.Windows.Forms.ListView EkleListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker GTime;
        private System.Windows.Forms.DateTimePicker CTime;
    }
}