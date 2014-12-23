namespace Otel_Otomasyonu
{
    partial class MusteriBilgiForm
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
            this.AramaKutu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // AramaKutu
            // 
            this.AramaKutu.Location = new System.Drawing.Point(183, 37);
            this.AramaKutu.Name = "AramaKutu";
            this.AramaKutu.Size = new System.Drawing.Size(155, 20);
            this.AramaKutu.TabIndex = 0;
            this.AramaKutu.TextChanged += new System.EventHandler(this.AramaKutu_TextChanged);
            this.AramaKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AramaKutu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama";
            // 
            // Liste
            // 
            this.Liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Liste.Location = new System.Drawing.Point(12, 74);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(620, 197);
            this.Liste.TabIndex = 6;
            this.Liste.UseCompatibleStateImageBehavior = false;
            this.Liste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik Numarası";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cinsiyet";
            // 
            // MusteriBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(644, 283);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AramaKutu);
            this.Name = "MusteriBilgiForm";
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.MüşteriBilgiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AramaKutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Liste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}