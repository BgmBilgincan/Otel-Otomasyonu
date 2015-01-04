namespace Otel_Otomasyonu
{
    partial class OtelPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtelPanelForm));
            this.OdalarButon = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TarihLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.MusteriButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OdalarButon
            // 
            this.OdalarButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OdalarButon.BackgroundImage")));
            this.OdalarButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OdalarButon.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdalarButon.ForeColor = System.Drawing.Color.DarkOrange;
            this.OdalarButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OdalarButon.Location = new System.Drawing.Point(62, 36);
            this.OdalarButon.Name = "OdalarButon";
            this.OdalarButon.Size = new System.Drawing.Size(151, 143);
            this.OdalarButon.TabIndex = 0;
            this.OdalarButon.Text = "Odalar";
            this.OdalarButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OdalarButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OdalarButon.UseVisualStyleBackColor = true;
            this.OdalarButon.Click += new System.EventHandler(this.OdalarButon_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TarihLabel.Location = new System.Drawing.Point(220, 236);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(85, 29);
            this.TarihLabel.TabIndex = 4;
            this.TarihLabel.Text = "label2";
            // 
            // SaatLabel
            // 
            this.SaatLabel.AutoSize = true;
            this.SaatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.SaatLabel.Location = new System.Drawing.Point(368, 234);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.Size = new System.Drawing.Size(85, 29);
            this.SaatLabel.TabIndex = 6;
            this.SaatLabel.Text = "label2";
            this.SaatLabel.Click += new System.EventHandler(this.SaatLabel_Click);
            // 
            // MusteriButon
            // 
            this.MusteriButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MusteriButon.BackgroundImage")));
            this.MusteriButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MusteriButon.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriButon.ForeColor = System.Drawing.Color.DarkOrange;
            this.MusteriButon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MusteriButon.Location = new System.Drawing.Point(284, 36);
            this.MusteriButon.Name = "MusteriButon";
            this.MusteriButon.Size = new System.Drawing.Size(151, 143);
            this.MusteriButon.TabIndex = 7;
            this.MusteriButon.Text = "Müşteriler";
            this.MusteriButon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MusteriButon.UseVisualStyleBackColor = true;
            this.MusteriButon.Click += new System.EventHandler(this.MusteriButon_Click);
            // 
            // OtelPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.Controls.Add(this.MusteriButon);
            this.Controls.Add(this.SaatLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.OdalarButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OtelPanelForm";
            this.Text = "Otel Paneli";
            this.Load += new System.EventHandler(this.OtelPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OdalarButon;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.Button MusteriButon;
    }
}

