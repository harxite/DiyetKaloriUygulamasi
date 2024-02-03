namespace DietApp.UI
{
    partial class YeniBesinEklemeEkrani
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
            txtBesinAd = new TextBox();
            txtBesinAciklama = new TextBox();
            txtFotografYolu = new TextBox();
            cmbKategori = new ComboBox();
            cmbBirim = new ComboBox();
            nudYagMiktari = new NumericUpDown();
            nudKarbonHMiktari = new NumericUpDown();
            nudKaloriMiktari = new NumericUpDown();
            nudProteinMiktari = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnYeniBesinEkle = new Button();
            btnFotografEkle = new Button();
            pbBesinFotograf = new PictureBox();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYagMiktari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKarbonHMiktari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKaloriMiktari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProteinMiktari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBesinFotograf).BeginInit();
            SuspendLayout();
            // 
            // txtBesinAd
            // 
            txtBesinAd.Location = new Point(103, 21);
            txtBesinAd.Margin = new Padding(3, 4, 3, 4);
            txtBesinAd.Name = "txtBesinAd";
            txtBesinAd.Size = new Size(138, 27);
            txtBesinAd.TabIndex = 0;
            // 
            // txtBesinAciklama
            // 
            txtBesinAciklama.Location = new Point(103, 77);
            txtBesinAciklama.Margin = new Padding(3, 4, 3, 4);
            txtBesinAciklama.Name = "txtBesinAciklama";
            txtBesinAciklama.Size = new Size(138, 27);
            txtBesinAciklama.TabIndex = 1;
            // 
            // txtFotografYolu
            // 
            txtFotografYolu.Location = new Point(103, 133);
            txtFotografYolu.Margin = new Padding(3, 4, 3, 4);
            txtFotografYolu.Name = "txtFotografYolu";
            txtFotografYolu.Size = new Size(138, 27);
            txtFotografYolu.TabIndex = 2;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(103, 189);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(138, 28);
            cmbKategori.TabIndex = 4;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Location = new Point(103, 241);
            cmbBirim.Margin = new Padding(3, 4, 3, 4);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(138, 28);
            cmbBirim.TabIndex = 5;
            // 
            // nudYagMiktari
            // 
            nudYagMiktari.Location = new Point(449, 23);
            nudYagMiktari.Margin = new Padding(3, 4, 3, 4);
            nudYagMiktari.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudYagMiktari.Name = "nudYagMiktari";
            nudYagMiktari.Size = new Size(137, 27);
            nudYagMiktari.TabIndex = 6;
            // 
            // nudKarbonHMiktari
            // 
            nudKarbonHMiktari.Location = new Point(449, 79);
            nudKarbonHMiktari.Margin = new Padding(3, 4, 3, 4);
            nudKarbonHMiktari.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudKarbonHMiktari.Name = "nudKarbonHMiktari";
            nudKarbonHMiktari.Size = new Size(137, 27);
            nudKarbonHMiktari.TabIndex = 7;
            // 
            // nudKaloriMiktari
            // 
            nudKaloriMiktari.Location = new Point(449, 189);
            nudKaloriMiktari.Margin = new Padding(3, 4, 3, 4);
            nudKaloriMiktari.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudKaloriMiktari.Name = "nudKaloriMiktari";
            nudKaloriMiktari.Size = new Size(137, 27);
            nudKaloriMiktari.TabIndex = 8;
            // 
            // nudProteinMiktari
            // 
            nudProteinMiktari.Location = new Point(449, 133);
            nudProteinMiktari.Margin = new Padding(3, 4, 3, 4);
            nudProteinMiktari.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudProteinMiktari.Name = "nudProteinMiktari";
            nudProteinMiktari.Size = new Size(137, 27);
            nudProteinMiktari.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 10;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 81);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 11;
            label2.Text = "AÇIKLAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 137);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 12;
            label3.Text = "FOTOĞRAF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 193);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "KATEGORİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 25);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 14;
            label5.Text = "YAĞ MİKTARI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 249);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 15;
            label6.Text = "BİRİM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 192);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 16;
            label7.Text = "KALORİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 81);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 17;
            label8.Text = "KARBONHİDRAT MİKTARI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 136);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 18;
            label9.Text = "PROTEİN MİKTARI";
            // 
            // btnYeniBesinEkle
            // 
            btnYeniBesinEkle.Location = new Point(442, 269);
            btnYeniBesinEkle.Margin = new Padding(3, 4, 3, 4);
            btnYeniBesinEkle.Name = "btnYeniBesinEkle";
            btnYeniBesinEkle.Size = new Size(144, 43);
            btnYeniBesinEkle.TabIndex = 19;
            btnYeniBesinEkle.Text = "EKLE";
            btnYeniBesinEkle.UseVisualStyleBackColor = true;
            btnYeniBesinEkle.Click += btnYeniBesinEkle_Click;
            // 
            // btnFotografEkle
            // 
            btnFotografEkle.Location = new Point(248, 133);
            btnFotografEkle.Margin = new Padding(3, 4, 3, 4);
            btnFotografEkle.Name = "btnFotografEkle";
            btnFotografEkle.Size = new Size(32, 32);
            btnFotografEkle.TabIndex = 20;
            btnFotografEkle.Text = "...";
            btnFotografEkle.UseVisualStyleBackColor = true;
            btnFotografEkle.Click += btnFotografEkle_Click;
            // 
            // pbBesinFotograf
            // 
            pbBesinFotograf.Location = new Point(17, 313);
            pbBesinFotograf.Margin = new Padding(3, 4, 3, 4);
            pbBesinFotograf.Name = "pbBesinFotograf";
            pbBesinFotograf.Size = new Size(224, 171);
            pbBesinFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinFotograf.TabIndex = 21;
            pbBesinFotograf.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(442, 320);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(144, 45);
            btnSil.TabIndex = 22;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // YeniBesinEklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(600, 511);
            Controls.Add(btnSil);
            Controls.Add(btnYeniBesinEkle);
            Controls.Add(pbBesinFotograf);
            Controls.Add(btnFotografEkle);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudProteinMiktari);
            Controls.Add(nudKaloriMiktari);
            Controls.Add(nudKarbonHMiktari);
            Controls.Add(nudYagMiktari);
            Controls.Add(cmbBirim);
            Controls.Add(cmbKategori);
            Controls.Add(txtFotografYolu);
            Controls.Add(txtBesinAciklama);
            Controls.Add(txtBesinAd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YeniBesinEklemeEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniBesinEklemeEkrani";
            Load += YeniBesinEklemeEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)nudYagMiktari).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKarbonHMiktari).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKaloriMiktari).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProteinMiktari).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBesinFotograf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBesinAd;
        private TextBox txtBesinAciklama;
        private TextBox txtFotografYolu;
        private ComboBox cmbKategori;
        private ComboBox cmbBirim;
        private NumericUpDown nudYagMiktari;
        private NumericUpDown nudKarbonHMiktari;
        private NumericUpDown nudKaloriMiktari;
        private NumericUpDown nudProteinMiktari;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnYeniBesinEkle;
        private Button btnFotografEkle;
        private PictureBox pbBesinFotograf;
        private Button btnSil;
    }
}