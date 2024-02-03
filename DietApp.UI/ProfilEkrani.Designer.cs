namespace DietApp.UI
{
    partial class ProfilEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilEkrani));
            groupBox2 = new GroupBox();
            radYuksek = new RadioButton();
            radHareketsiz = new RadioButton();
            radOrta = new RadioButton();
            radHafif = new RadioButton();
            nudHedefKilo = new NumericUpDown();
            nudKilo = new NumericUpDown();
            nudBoy = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnKayitOl = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHedefKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(radYuksek);
            groupBox2.Controls.Add(radHareketsiz);
            groupBox2.Controls.Add(radOrta);
            groupBox2.Controls.Add(radHafif);
            groupBox2.ForeColor = Color.Gainsboro;
            groupBox2.Location = new Point(216, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 160);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aktivite Düzeyi";
            // 
            // radYuksek
            // 
            radYuksek.AutoSize = true;
            radYuksek.Location = new Point(18, 124);
            radYuksek.Name = "radYuksek";
            radYuksek.Size = new Size(62, 19);
            radYuksek.TabIndex = 10;
            radYuksek.Text = "Yüksek";
            radYuksek.UseVisualStyleBackColor = true;
            // 
            // radHareketsiz
            // 
            radHareketsiz.AutoSize = true;
            radHareketsiz.Location = new Point(18, 31);
            radHareketsiz.Name = "radHareketsiz";
            radHareketsiz.Size = new Size(79, 19);
            radHareketsiz.TabIndex = 10;
            radHareketsiz.Text = "Hareketsiz";
            radHareketsiz.UseVisualStyleBackColor = true;
            // 
            // radOrta
            // 
            radOrta.AutoSize = true;
            radOrta.Checked = true;
            radOrta.Location = new Point(18, 93);
            radOrta.Name = "radOrta";
            radOrta.Size = new Size(48, 19);
            radOrta.TabIndex = 10;
            radOrta.TabStop = true;
            radOrta.Text = "Orta";
            radOrta.UseVisualStyleBackColor = true;
            // 
            // radHafif
            // 
            radHafif.AutoSize = true;
            radHafif.Location = new Point(18, 62);
            radHafif.Name = "radHafif";
            radHafif.Size = new Size(51, 19);
            radHafif.TabIndex = 10;
            radHafif.Text = "Hafif";
            radHafif.UseVisualStyleBackColor = true;
            // 
            // nudHedefKilo
            // 
            nudHedefKilo.DecimalPlaces = 1;
            nudHedefKilo.ForeColor = Color.Black;
            nudHedefKilo.Location = new Point(299, 94);
            nudHedefKilo.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            nudHedefKilo.Name = "nudHedefKilo";
            nudHedefKilo.Size = new Size(135, 23);
            nudHedefKilo.TabIndex = 14;
            nudHedefKilo.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // nudKilo
            // 
            nudKilo.DecimalPlaces = 1;
            nudKilo.ForeColor = Color.Black;
            nudKilo.Location = new Point(299, 57);
            nudKilo.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            nudKilo.Name = "nudKilo";
            nudKilo.Size = new Size(135, 23);
            nudKilo.TabIndex = 15;
            nudKilo.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // nudBoy
            // 
            nudBoy.ForeColor = Color.Black;
            nudBoy.Location = new Point(299, 20);
            nudBoy.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            nudBoy.Name = "nudBoy";
            nudBoy.Size = new Size(135, 23);
            nudBoy.TabIndex = 16;
            nudBoy.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(216, 96);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 11;
            label8.Text = "Hedef Kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(216, 59);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 12;
            label7.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(216, 22);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 13;
            label6.Text = "Boy";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Transparent;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(216, 311);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(218, 37);
            btnKayitOl.TabIndex = 17;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // ProfilEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(449, 362);
            Controls.Add(btnKayitOl);
            Controls.Add(nudHedefKilo);
            Controls.Add(nudKilo);
            Controls.Add(nudBoy);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "ProfilEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilEkrani";
            Load += ProfilEkrani_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHedefKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radYuksek;
        private RadioButton radHareketsiz;
        private RadioButton radOrta;
        private RadioButton radHafif;
        private NumericUpDown nudHedefKilo;
        private NumericUpDown nudKilo;
        private NumericUpDown nudBoy;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnKayitOl;
    }
}