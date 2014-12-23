namespace Otel_Otomasyonu
{
    partial class OdalarForm
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
            this.OdalarListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MEkleButon = new System.Windows.Forms.Button();
            this.OdaIslemLAbel = new System.Windows.Forms.Label();
            this.MKaldırButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OdalarListe
            // 
            this.OdalarListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OdalarListe.Location = new System.Drawing.Point(12, 93);
            this.OdalarListe.Name = "OdalarListe";
            this.OdalarListe.Size = new System.Drawing.Size(500, 184);
            this.OdalarListe.TabIndex = 0;
            this.OdalarListe.UseCompatibleStateImageBehavior = false;
            this.OdalarListe.View = System.Windows.Forms.View.Details;
            this.OdalarListe.SelectedIndexChanged += new System.EventHandler(this.OdalarListe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda İsmi";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Limit";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Durum";
            this.columnHeader3.Width = 83;
            // 
            // MEkleButon
            // 
            this.MEkleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MEkleButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MEkleButon.Location = new System.Drawing.Point(155, 27);
            this.MEkleButon.Name = "MEkleButon";
            this.MEkleButon.Size = new System.Drawing.Size(99, 32);
            this.MEkleButon.TabIndex = 1;
            this.MEkleButon.Text = "Müşteri Ekle";
            this.MEkleButon.UseVisualStyleBackColor = true;
            this.MEkleButon.Click += new System.EventHandler(this.MEkleButon_Click);
            // 
            // OdaIslemLAbel
            // 
            this.OdaIslemLAbel.AutoSize = true;
            this.OdaIslemLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaIslemLAbel.Location = new System.Drawing.Point(25, 33);
            this.OdaIslemLAbel.Name = "OdaIslemLAbel";
            this.OdaIslemLAbel.Size = new System.Drawing.Size(107, 18);
            this.OdaIslemLAbel.TabIndex = 2;
            this.OdaIslemLAbel.Text = "Oda İşlemleri";
            // 
            // MKaldırButon
            // 
            this.MKaldırButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MKaldırButon.Location = new System.Drawing.Point(272, 27);
            this.MKaldırButon.Name = "MKaldırButon";
            this.MKaldırButon.Size = new System.Drawing.Size(99, 32);
            this.MKaldırButon.TabIndex = 3;
            this.MKaldırButon.Text = "Müşteri Kaldır";
            this.MKaldırButon.UseVisualStyleBackColor = true;
            this.MKaldırButon.Click += new System.EventHandler(this.MKaldırButon_Click);
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.MKaldırButon);
            this.Controls.Add(this.OdaIslemLAbel);
            this.Controls.Add(this.MEkleButon);
            this.Controls.Add(this.OdalarListe);
            this.Name = "OdalarForm";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.OdalarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OdalarListe;
        private System.Windows.Forms.Button MEkleButon;
        private System.Windows.Forms.Label OdaIslemLAbel;
        private System.Windows.Forms.Button MKaldırButon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}