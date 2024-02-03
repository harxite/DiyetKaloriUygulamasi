namespace DietApp.UI
{
    partial class AdminEkrani
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
            lvKullanicilar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lvBesinler = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnAktifPasif = new Button();
            label5 = new Label();
            btnOnayla = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            lblAktifSayisi = new Label();
            lblPasifSayisi = new Label();
            lblToplamKullanici = new Label();
            lblToplamBesin = new Label();
            SuspendLayout();
            // 
            // lvKullanicilar
            // 
            lvKullanicilar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvKullanicilar.FullRowSelect = true;
            lvKullanicilar.GridLines = true;
            lvKullanicilar.Location = new Point(12, 81);
            lvKullanicilar.Name = "lvKullanicilar";
            lvKullanicilar.Size = new Size(406, 410);
            lvKullanicilar.TabIndex = 0;
            lvKullanicilar.UseCompatibleStateImageBehavior = false;
            lvKullanicilar.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Durum";
            columnHeader4.Width = 80;
            // 
            // lvBesinler
            // 
            lvBesinler.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader11 });
            lvBesinler.FullRowSelect = true;
            lvBesinler.GridLines = true;
            lvBesinler.Location = new Point(435, 81);
            lvBesinler.Name = "lvBesinler";
            lvBesinler.Size = new Size(450, 410);
            lvBesinler.TabIndex = 0;
            lvBesinler.UseCompatibleStateImageBehavior = false;
            lvBesinler.View = View.Details;
            lvBesinler.DoubleClick += lvBesinler_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Besin Adi";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kalori";
            columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Karbonhidrat";
            columnHeader7.Width = 55;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Protein";
            columnHeader8.Width = 55;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Yag";
            columnHeader9.Width = 55;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fotograf";
            columnHeader11.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "KULLANICILAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(443, 44);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "ONAY BEKLEYEN BESINLER";
            // 
            // btnAktifPasif
            // 
            btnAktifPasif.Location = new Point(12, 504);
            btnAktifPasif.Name = "btnAktifPasif";
            btnAktifPasif.Size = new Size(149, 59);
            btnAktifPasif.TabIndex = 2;
            btnAktifPasif.Text = "Aktif/Pasif";
            btnAktifPasif.UseVisualStyleBackColor = true;
            btnAktifPasif.Click += btnAktifPasif_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 523);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Pasif :";
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(443, 504);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(149, 59);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 523);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Toplam :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 504);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Aktif :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 543);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 3;
            label6.Text = "Toplam :";
            // 
            // lblAktifSayisi
            // 
            lblAktifSayisi.AutoSize = true;
            lblAktifSayisi.Location = new Point(264, 504);
            lblAktifSayisi.Name = "lblAktifSayisi";
            lblAktifSayisi.Size = new Size(17, 20);
            lblAktifSayisi.TabIndex = 3;
            lblAktifSayisi.Text = "0";
            // 
            // lblPasifSayisi
            // 
            lblPasifSayisi.AutoSize = true;
            lblPasifSayisi.Location = new Point(264, 524);
            lblPasifSayisi.Name = "lblPasifSayisi";
            lblPasifSayisi.Size = new Size(17, 20);
            lblPasifSayisi.TabIndex = 3;
            lblPasifSayisi.Text = "0";
            // 
            // lblToplamKullanici
            // 
            lblToplamKullanici.AutoSize = true;
            lblToplamKullanici.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKullanici.Location = new Point(287, 543);
            lblToplamKullanici.Name = "lblToplamKullanici";
            lblToplamKullanici.Size = new Size(18, 20);
            lblToplamKullanici.TabIndex = 3;
            lblToplamKullanici.Text = "0";
            // 
            // lblToplamBesin
            // 
            lblToplamBesin.AutoSize = true;
            lblToplamBesin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamBesin.Location = new Point(751, 524);
            lblToplamBesin.Name = "lblToplamBesin";
            lblToplamBesin.Size = new Size(18, 20);
            lblToplamBesin.TabIndex = 3;
            lblToplamBesin.Text = "0";
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 591);
            Controls.Add(label6);
            Controls.Add(lblToplamBesin);
            Controls.Add(lblToplamKullanici);
            Controls.Add(lblPasifSayisi);
            Controls.Add(lblAktifSayisi);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnOnayla);
            Controls.Add(btnAktifPasif);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvBesinler);
            Controls.Add(lvKullanicilar);
            Name = "AdminEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvKullanicilar;
        private ListView lvBesinler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader11;
        private Label label1;
        private Label label2;
        private Button btnAktifPasif;
        private Label label5;
        private Button btnOnayla;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label lblAktifSayisi;
        private Label lblPasifSayisi;
        private Label lblToplamKullanici;
        private Label lblToplamBesin;
    }
}