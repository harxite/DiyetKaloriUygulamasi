namespace DietApp.UI
{
    partial class OgunOlusturmaEkrani
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
            components = new System.ComponentModel.Container();
            besinBindingSource = new BindingSource(components);
            btnOgunOlustur = new Button();
            btnBesinEkle = new Button();
            label1 = new Label();
            btnBesinDuzenleSil = new Button();
            btnBesinlereBesinEkle = new Button();
            lstSeciliBesinler = new ListView();
            clmAd = new ColumnHeader();
            clmKalori = new ColumnHeader();
            clmProtein = new ColumnHeader();
            clmYagMiktari = new ColumnHeader();
            clmKarbonhidrat = new ColumnHeader();
            lblOgunAdi = new Label();
            btnBesinBul = new Button();
            txtArama = new TextBox();
            lstvKulaniciBesinleri = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lstvBesinler = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            lblOgunAdi2 = new Label();
            ((System.ComponentModel.ISupportInitialize)besinBindingSource).BeginInit();
            SuspendLayout();
            // 
            // besinBindingSource
            // 
            besinBindingSource.DataSource = typeof(AppDiet.Domain.Entities.Besin);
            // 
            // btnOgunOlustur
            // 
            btnOgunOlustur.Location = new Point(403, 569);
            btnOgunOlustur.Margin = new Padding(3, 4, 3, 4);
            btnOgunOlustur.Name = "btnOgunOlustur";
            btnOgunOlustur.Size = new Size(126, 31);
            btnOgunOlustur.TabIndex = 2;
            btnOgunOlustur.Text = "ÖĞÜN OLUŞTUR";
            btnOgunOlustur.UseVisualStyleBackColor = true;
            btnOgunOlustur.Click += btnOgunOlustur_Click;
            // 
            // btnBesinEkle
            // 
            btnBesinEkle.Location = new Point(418, 228);
            btnBesinEkle.Margin = new Padding(3, 4, 3, 4);
            btnBesinEkle.Name = "btnBesinEkle";
            btnBesinEkle.Size = new Size(111, 31);
            btnBesinEkle.TabIndex = 4;
            btnBesinEkle.Text = "BESİN EKLE";
            btnBesinEkle.UseVisualStyleBackColor = true;
            btnBesinEkle.Click += btnBesinEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 243);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 6;
            label1.Text = "EKLENEN BESİNLER";
            // 
            // btnBesinDuzenleSil
            // 
            btnBesinDuzenleSil.Location = new Point(130, 373);
            btnBesinDuzenleSil.Margin = new Padding(3, 4, 3, 4);
            btnBesinDuzenleSil.Name = "btnBesinDuzenleSil";
            btnBesinDuzenleSil.Size = new Size(110, 31);
            btnBesinDuzenleSil.TabIndex = 10;
            btnBesinDuzenleSil.Text = "DÜZENLE/SİL";
            btnBesinDuzenleSil.UseVisualStyleBackColor = true;
            btnBesinDuzenleSil.Click += btnBesinDuzenleSil_Click;
            // 
            // btnBesinlereBesinEkle
            // 
            btnBesinlereBesinEkle.Location = new Point(14, 373);
            btnBesinlereBesinEkle.Margin = new Padding(3, 4, 3, 4);
            btnBesinlereBesinEkle.Name = "btnBesinlereBesinEkle";
            btnBesinlereBesinEkle.Size = new Size(110, 31);
            btnBesinlereBesinEkle.TabIndex = 12;
            btnBesinlereBesinEkle.Text = "EKLE";
            btnBesinlereBesinEkle.UseVisualStyleBackColor = true;
            btnBesinlereBesinEkle.Click += btnBesinlereBesinEkle_Click;
            // 
            // lstSeciliBesinler
            // 
            lstSeciliBesinler.Columns.AddRange(new ColumnHeader[] { clmAd, clmKalori, clmProtein, clmYagMiktari, clmKarbonhidrat });
            lstSeciliBesinler.GridLines = true;
            lstSeciliBesinler.Location = new Point(14, 432);
            lstSeciliBesinler.Margin = new Padding(3, 4, 3, 4);
            lstSeciliBesinler.Name = "lstSeciliBesinler";
            lstSeciliBesinler.Size = new Size(515, 128);
            lstSeciliBesinler.TabIndex = 13;
            lstSeciliBesinler.UseCompatibleStateImageBehavior = false;
            lstSeciliBesinler.View = View.Details;
            // 
            // clmAd
            // 
            clmAd.Text = "AD";
            // 
            // clmKalori
            // 
            clmKalori.Text = "Kalori";
            // 
            // clmProtein
            // 
            clmProtein.Text = "Protein";
            // 
            // clmYagMiktari
            // 
            clmYagMiktari.Text = "Yağ Miktarı";
            clmYagMiktari.Width = 100;
            // 
            // clmKarbonhidrat
            // 
            clmKarbonhidrat.Text = "Karbonhidrat Miktarı";
            clmKarbonhidrat.Width = 150;
            // 
            // lblOgunAdi
            // 
            lblOgunAdi.AutoSize = true;
            lblOgunAdi.Location = new Point(15, 408);
            lblOgunAdi.Name = "lblOgunAdi";
            lblOgunAdi.Size = new Size(61, 20);
            lblOgunAdi.TabIndex = 14;
            lblOgunAdi.Text = "Besinler";
            // 
            // btnBesinBul
            // 
            btnBesinBul.Location = new Point(15, 55);
            btnBesinBul.Margin = new Padding(3, 4, 3, 4);
            btnBesinBul.Name = "btnBesinBul";
            btnBesinBul.Size = new Size(109, 31);
            btnBesinBul.TabIndex = 16;
            btnBesinBul.Text = "BESİN BUL";
            btnBesinBul.UseVisualStyleBackColor = true;
            btnBesinBul.Click += btnBesinBul_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(15, 16);
            txtArama.Margin = new Padding(3, 4, 3, 4);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(218, 27);
            txtArama.TabIndex = 15;
            // 
            // lstvKulaniciBesinleri
            // 
            lstvKulaniciBesinleri.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstvKulaniciBesinleri.GridLines = true;
            lstvKulaniciBesinleri.Location = new Point(14, 267);
            lstvKulaniciBesinleri.Margin = new Padding(3, 4, 3, 4);
            lstvKulaniciBesinleri.Name = "lstvKulaniciBesinleri";
            lstvKulaniciBesinleri.Size = new Size(515, 97);
            lstvKulaniciBesinleri.TabIndex = 19;
            lstvKulaniciBesinleri.UseCompatibleStateImageBehavior = false;
            lstvKulaniciBesinleri.View = View.Details;
            lstvKulaniciBesinleri.SelectedIndexChanged += lstvKulaniciBesinleri_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "AD";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kalori";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Protein";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Yağ Miktarı";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Karbonhidrat Miktarı";
            columnHeader5.Width = 150;
            // 
            // lstvBesinler
            // 
            lstvBesinler.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lstvBesinler.GridLines = true;
            lstvBesinler.Location = new Point(16, 91);
            lstvBesinler.Margin = new Padding(3, 4, 3, 4);
            lstvBesinler.Name = "lstvBesinler";
            lstvBesinler.Size = new Size(515, 128);
            lstvBesinler.TabIndex = 20;
            lstvBesinler.UseCompatibleStateImageBehavior = false;
            lstvBesinler.View = View.Details;
            lstvBesinler.SelectedIndexChanged += lstvBesinler_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "AD";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kalori";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Protein";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Yağ Miktarı";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Karbonhidrat Miktarı";
            columnHeader10.Width = 150;
            // 
            // lblOgunAdi2
            // 
            lblOgunAdi2.AutoSize = true;
            lblOgunAdi2.Location = new Point(345, 16);
            lblOgunAdi2.Name = "lblOgunAdi2";
            lblOgunAdi2.Size = new Size(0, 20);
            lblOgunAdi2.TabIndex = 21;
            // 
            // OgunOlusturmaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(545, 655);
            Controls.Add(lblOgunAdi2);
            Controls.Add(lstvBesinler);
            Controls.Add(lstvKulaniciBesinleri);
            Controls.Add(btnBesinBul);
            Controls.Add(txtArama);
            Controls.Add(lblOgunAdi);
            Controls.Add(lstSeciliBesinler);
            Controls.Add(btnBesinlereBesinEkle);
            Controls.Add(btnBesinDuzenleSil);
            Controls.Add(label1);
            Controls.Add(btnBesinEkle);
            Controls.Add(btnOgunOlustur);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgunOlusturmaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OgunOlusturmaEkrani";
            Load += OgunOlusturmaEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)besinBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource besinBindingSource;
        private DataGridViewTextBoxColumn porsiyonBirimiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onayliMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn olusturulmaTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degistirilmeTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn silinmeTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private Button btnBesinDuzenleSil;
        private Button btnOgunOlustur;
        private Button btnBesinEkle;
        private Label label1;
        private Button btnBesinlereBesinEkle;
        private ListView lstSeciliBesinler;
        private Label lblOgunAdi;
        private ColumnHeader clmAd;
        private ColumnHeader clmKalori;
        private ColumnHeader clmProtein;
        private ColumnHeader clmYagMiktari;
        private ColumnHeader clmKarbonhidrat;
        private Button btnBesinBul;
        private TextBox txtArama;
        private ListView lstvKulaniciBesinleri;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView lstvBesinler;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label lblOgunAdi2;
    }
}