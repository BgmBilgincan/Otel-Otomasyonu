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
            this.listView1 = new System.Windows.Forms.ListView();
            this.MEkleButon = new System.Windows.Forms.Button();
            this.OdaIslemLAbel = new System.Windows.Forms.Label();
            this.MKaldırButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 184);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.MKaldırButon);
            this.Controls.Add(this.OdaIslemLAbel);
            this.Controls.Add(this.MEkleButon);
            this.Controls.Add(this.listView1);
            this.Name = "OdalarForm";
            this.Text = "Odalar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button MEkleButon;
        private System.Windows.Forms.Label OdaIslemLAbel;
        private System.Windows.Forms.Button MKaldırButon;
    }
}