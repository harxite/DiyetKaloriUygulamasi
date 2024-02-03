namespace DietApp.UI
{
    partial class BesinEklemeEkrani
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
            btnEkle = new Button();
            cmbBirim = new ComboBox();
            pbBesinFotograf = new PictureBox();
            nudMiktar = new NumericUpDown();
            lstGelenBesin = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBesinFotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(14, 411);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 31);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Location = new Point(12, 157);
            cmbBirim.Margin = new Padding(3, 4, 3, 4);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(162, 28);
            cmbBirim.TabIndex = 6;
            // 
            // pbBesinFotograf
            // 
            pbBesinFotograf.Location = new Point(415, 37);
            pbBesinFotograf.Margin = new Padding(3, 4, 3, 4);
            pbBesinFotograf.Name = "pbBesinFotograf";
            pbBesinFotograf.Size = new Size(258, 148);
            pbBesinFotograf.TabIndex = 7;
            pbBesinFotograf.TabStop = false;
            // 
            // nudMiktar
            // 
            nudMiktar.DecimalPlaces = 2;
            nudMiktar.Location = new Point(212, 157);
            nudMiktar.Margin = new Padding(3, 4, 3, 4);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(162, 27);
            nudMiktar.TabIndex = 8;
            nudMiktar.ValueChanged += nudMiktar_ValueChanged;
            // 
            // lstGelenBesin
            // 
            lstGelenBesin.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lstGelenBesin.GridLines = true;
            lstGelenBesin.Location = new Point(14, 212);
            lstGelenBesin.Margin = new Padding(3, 4, 3, 4);
            lstGelenBesin.Name = "lstGelenBesin";
            lstGelenBesin.Size = new Size(683, 191);
            lstGelenBesin.TabIndex = 21;
            lstGelenBesin.UseCompatibleStateImageBehavior = false;
            lstGelenBesin.View = View.Details;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 133);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 22;
            label1.Text = "Birim Seciniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 133);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 22;
            label2.Text = "Miktar Giriniz";
            // 
            // BesinEklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 452);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstGelenBesin);
            Controls.Add(nudMiktar);
            Controls.Add(pbBesinFotograf);
            Controls.Add(cmbBirim);
            Controls.Add(btnEkle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BesinEklemeEkrani";
            Text = "BesinEklemeEkrani";
            Load += BesinEklemeEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)pbBesinFotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private ComboBox cmbBirim;
        private PictureBox pbBesinFotograf;
        private NumericUpDown nudMiktar;
        private ListView lstGelenBesin;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label1;
        private Label label2;
    }
}