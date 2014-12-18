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
            this.OdalarButon = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.StLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.MusteriButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OdalarButon
            // 
            this.OdalarButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdalarButon.Location = new System.Drawing.Point(50, 46);
            this.OdalarButon.Name = "OdalarButon";
            this.OdalarButon.Size = new System.Drawing.Size(95, 42);
            this.OdalarButon.TabIndex = 0;
            this.OdalarButon.Text = "Odalar";
            this.OdalarButon.UseVisualStyleBackColor = true;
            this.OdalarButon.Click += new System.EventHandler(this.OdalarButon_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TLabel.Location = new System.Drawing.Point(12, 157);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(63, 24);
            this.TLabel.TabIndex = 3;
            this.TLabel.Text = "Tarih :";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihLabel.Location = new System.Drawing.Point(67, 157);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(60, 24);
            this.TarihLabel.TabIndex = 4;
            this.TarihLabel.Text = "label2";
            // 
            // StLabel
            // 
            this.StLabel.AutoSize = true;
            this.StLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StLabel.Location = new System.Drawing.Point(177, 157);
            this.StLabel.Name = "StLabel";
            this.StLabel.Size = new System.Drawing.Size(56, 24);
            this.StLabel.TabIndex = 5;
            this.StLabel.Text = "Saat :";
            // 
            // SaatLabel
            // 
            this.SaatLabel.AutoSize = true;
            this.SaatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatLabel.Location = new System.Drawing.Point(229, 157);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.Size = new System.Drawing.Size(60, 24);
            this.SaatLabel.TabIndex = 6;
            this.SaatLabel.Text = "label2";
            // 
            // MusteriButon
            // 
            this.MusteriButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriButon.Location = new System.Drawing.Point(172, 46);
            this.MusteriButon.Name = "MusteriButon";
            this.MusteriButon.Size = new System.Drawing.Size(95, 42);
            this.MusteriButon.TabIndex = 7;
            this.MusteriButon.Text = "Müşteri";
            this.MusteriButon.UseVisualStyleBackColor = true;
            this.MusteriButon.Click += new System.EventHandler(this.MusteriButon_Click);
            // 
            // OtelPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(311, 203);
            this.Controls.Add(this.MusteriButon);
            this.Controls.Add(this.SaatLabel);
            this.Controls.Add(this.StLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.TLabel);
            this.Controls.Add(this.OdalarButon);
            this.Name = "OtelPanelForm";
            this.Text = "Otel Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OdalarButon;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label StLabel;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.Button MusteriButon;
    }
}

