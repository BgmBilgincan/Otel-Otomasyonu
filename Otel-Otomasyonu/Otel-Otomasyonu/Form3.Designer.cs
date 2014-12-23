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
            this.SuspendLayout();
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCLabel.Location = new System.Drawing.Point(12, 29);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(90, 18);
            this.TCLabel.TabIndex = 0;
            this.TCLabel.Text = "Tc Numara :";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdLabel.Location = new System.Drawing.Point(12, 72);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(37, 18);
            this.AdLabel.TabIndex = 1;
            this.AdLabel.Text = "Ad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet :";
            // 
            // TcKutu
            // 
            this.TcKutu.Location = new System.Drawing.Point(113, 27);
            this.TcKutu.Name = "TcKutu";
            this.TcKutu.Size = new System.Drawing.Size(120, 20);
            this.TcKutu.TabIndex = 5;
            this.TcKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TcKutu_KeyPress);
            // 
            // AdKutu
            // 
            this.AdKutu.Location = new System.Drawing.Point(113, 70);
            this.AdKutu.Name = "AdKutu";
            this.AdKutu.Size = new System.Drawing.Size(120, 20);
            this.AdKutu.TabIndex = 6;
            this.AdKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdKutu_KeyPress);
            // 
            // SoyadKutu
            // 
            this.SoyadKutu.Location = new System.Drawing.Point(113, 113);
            this.SoyadKutu.Name = "SoyadKutu";
            this.SoyadKutu.Size = new System.Drawing.Size(120, 20);
            this.SoyadKutu.TabIndex = 7;
            this.SoyadKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoyadKutu_KeyPress);
            // 
            // TelefonKutu
            // 
            this.TelefonKutu.Location = new System.Drawing.Point(113, 153);
            this.TelefonKutu.Name = "TelefonKutu";
            this.TelefonKutu.Size = new System.Drawing.Size(120, 20);
            this.TelefonKutu.TabIndex = 8;
            this.TelefonKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonKutu_KeyPress);
            // 
            // CinsiyetKutu
            // 
            this.CinsiyetKutu.Location = new System.Drawing.Point(113, 192);
            this.CinsiyetKutu.Name = "CinsiyetKutu";
            this.CinsiyetKutu.Size = new System.Drawing.Size(120, 20);
            this.CinsiyetKutu.TabIndex = 9;
            this.CinsiyetKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CinsiyetKutu_KeyPress);
            // 
            // KaydetButon
            // 
            this.KaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetButon.Location = new System.Drawing.Point(15, 242);
            this.KaydetButon.Name = "KaydetButon";
            this.KaydetButon.Size = new System.Drawing.Size(101, 27);
            this.KaydetButon.TabIndex = 10;
            this.KaydetButon.Text = "Kaydet";
            this.KaydetButon.UseVisualStyleBackColor = true;
            this.KaydetButon.Click += new System.EventHandler(this.KaydetButon_Click);
            // 
            // Cikisbuton
            // 
            this.Cikisbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikisbuton.Location = new System.Drawing.Point(132, 242);
            this.Cikisbuton.Name = "Cikisbuton";
            this.Cikisbuton.Size = new System.Drawing.Size(101, 27);
            this.Cikisbuton.TabIndex = 11;
            this.Cikisbuton.Text = "Çıkış";
            this.Cikisbuton.UseVisualStyleBackColor = true;
            this.Cikisbuton.Click += new System.EventHandler(this.Cikisbuton_Click);
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(254, 281);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}