namespace Adonet
{
    partial class AnaForm
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
            this.Liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyadKutu = new System.Windows.Forms.TextBox();
            this.TcKutu = new System.Windows.Forms.TextBox();
            this.TelefonKutu = new System.Windows.Forms.TextBox();
            this.EpostaKutu = new System.Windows.Forms.TextBox();
            this.KaydetButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Liste.Location = new System.Drawing.Point(12, 112);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(848, 388);
            this.Liste.TabIndex = 0;
            this.Liste.UseCompatibleStateImageBehavior = false;
            this.Liste.View = System.Windows.Forms.View.Details;
            this.Liste.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC Kimlik";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Eposta";
            this.columnHeader4.Width = 114;
            // 
            // AdSoyadKutu
            // 
            this.AdSoyadKutu.Location = new System.Drawing.Point(94, 38);
            this.AdSoyadKutu.Name = "AdSoyadKutu";
            this.AdSoyadKutu.Size = new System.Drawing.Size(100, 20);
            this.AdSoyadKutu.TabIndex = 1;
            // 
            // TcKutu
            // 
            this.TcKutu.Location = new System.Drawing.Point(223, 38);
            this.TcKutu.Name = "TcKutu";
            this.TcKutu.Size = new System.Drawing.Size(100, 20);
            this.TcKutu.TabIndex = 2;
            // 
            // TelefonKutu
            // 
            this.TelefonKutu.Location = new System.Drawing.Point(359, 38);
            this.TelefonKutu.Name = "TelefonKutu";
            this.TelefonKutu.Size = new System.Drawing.Size(100, 20);
            this.TelefonKutu.TabIndex = 3;
            this.TelefonKutu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EpostaKutu
            // 
            this.EpostaKutu.Location = new System.Drawing.Point(491, 38);
            this.EpostaKutu.Name = "EpostaKutu";
            this.EpostaKutu.Size = new System.Drawing.Size(100, 20);
            this.EpostaKutu.TabIndex = 4;
            this.EpostaKutu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // KaydetButon
            // 
            this.KaydetButon.Location = new System.Drawing.Point(639, 35);
            this.KaydetButon.Name = "KaydetButon";
            this.KaydetButon.Size = new System.Drawing.Size(75, 23);
            this.KaydetButon.TabIndex = 5;
            this.KaydetButon.Text = "Kaydet";
            this.KaydetButon.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.KaydetButon);
            this.Controls.Add(this.EpostaKutu);
            this.Controls.Add(this.TelefonKutu);
            this.Controls.Add(this.TcKutu);
            this.Controls.Add(this.AdSoyadKutu);
            this.Controls.Add(this.Liste);
            this.Name = "AnaForm";
            this.Text = "Ana Form";
            //this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Liste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox AdSoyadKutu;
        private System.Windows.Forms.TextBox TcKutu;
        private System.Windows.Forms.TextBox TelefonKutu;
        private System.Windows.Forms.TextBox EpostaKutu;
        private System.Windows.Forms.Button KaydetButon;
    }
}

