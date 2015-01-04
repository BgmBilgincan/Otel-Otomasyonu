namespace SınıfListview
{
    partial class Form1
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
            this.SinifCombobox = new System.Windows.Forms.ComboBox();
            this.AdSoyadKutu = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.liste1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyadLabel = new System.Windows.Forms.Label();
            this.TemizleButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinifCombobox
            // 
            this.SinifCombobox.FormattingEnabled = true;
            this.SinifCombobox.Items.AddRange(new object[] {
            "101",
            "202",
            "303",
            "404"});
            this.SinifCombobox.Location = new System.Drawing.Point(55, 25);
            this.SinifCombobox.Name = "SinifCombobox";
            this.SinifCombobox.Size = new System.Drawing.Size(199, 21);
            this.SinifCombobox.TabIndex = 0;
            this.SinifCombobox.Text = "Sınıflar";
            // 
            // AdSoyadKutu
            // 
            this.AdSoyadKutu.Location = new System.Drawing.Point(101, 74);
            this.AdSoyadKutu.Name = "AdSoyadKutu";
            this.AdSoyadKutu.Size = new System.Drawing.Size(100, 20);
            this.AdSoyadKutu.TabIndex = 1;
            this.AdSoyadKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdSoyadKutu_KeyPress);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(233, 66);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 34);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // liste1
            // 
            this.liste1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.liste1.Location = new System.Drawing.Point(12, 152);
            this.liste1.Name = "liste1";
            this.liste1.Size = new System.Drawing.Size(334, 135);
            this.liste1.TabIndex = 3;
            this.liste1.UseCompatibleStateImageBehavior = false;
            this.liste1.View = System.Windows.Forms.View.Details;
            this.liste1.SelectedIndexChanged += new System.EventHandler(this.liste1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AdSoyad";
            this.columnHeader2.Width = 79;
            // 
            // AdSoyadLabel
            // 
            this.AdSoyadLabel.AutoSize = true;
            this.AdSoyadLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyadLabel.Location = new System.Drawing.Point(12, 75);
            this.AdSoyadLabel.Name = "AdSoyadLabel";
            this.AdSoyadLabel.Size = new System.Drawing.Size(83, 19);
            this.AdSoyadLabel.TabIndex = 4;
            this.AdSoyadLabel.Text = "Ad Soyad :";
            // 
            // TemizleButon
            // 
            this.TemizleButon.Location = new System.Drawing.Point(233, 106);
            this.TemizleButon.Name = "TemizleButon";
            this.TemizleButon.Size = new System.Drawing.Size(75, 34);
            this.TemizleButon.TabIndex = 5;
            this.TemizleButon.Text = "Clear";
            this.TemizleButon.UseVisualStyleBackColor = true;
            this.TemizleButon.Click += new System.EventHandler(this.TemizleButon_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 299);
            this.Controls.Add(this.TemizleButon);
            this.Controls.Add(this.AdSoyadLabel);
            this.Controls.Add(this.liste1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.AdSoyadKutu);
            this.Controls.Add(this.SinifCombobox);
            this.Name = "Form1";
            this.Text = "Sınıf Listview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SinifCombobox;
        private System.Windows.Forms.TextBox AdSoyadKutu;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListView liste1;
        private System.Windows.Forms.Label AdSoyadLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button TemizleButon;
    }
}

