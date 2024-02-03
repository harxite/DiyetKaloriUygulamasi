namespace DietApp.UI
{
    partial class HesabimEkrani
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
            btnProfiliDuzenle = new Button();
            btnHesabiSil = new Button();
            lblAdSoyad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblYas = new Label();
            lblBoy = new Label();
            lblKilo = new Label();
            label8 = new Label();
            lblHedefKilo = new Label();
            label10 = new Label();
            lblAktiviteDuzeyi = new Label();
            SuspendLayout();
            // 
            // btnProfiliDuzenle
            // 
            btnProfiliDuzenle.BackColor = SystemColors.ActiveCaption;
            btnProfiliDuzenle.Location = new Point(100, 337);
            btnProfiliDuzenle.Name = "btnProfiliDuzenle";
            btnProfiliDuzenle.Size = new Size(168, 68);
            btnProfiliDuzenle.TabIndex = 0;
            btnProfiliDuzenle.Text = "Profili Duzenle";
            btnProfiliDuzenle.UseVisualStyleBackColor = false;
            btnProfiliDuzenle.Click += btnProfiliDuzenle_Click;
            // 
            // btnHesabiSil
            // 
            btnHesabiSil.BackColor = Color.RosyBrown;
            btnHesabiSil.Location = new Point(100, 411);
            btnHesabiSil.Name = "btnHesabiSil";
            btnHesabiSil.Size = new Size(168, 51);
            btnHesabiSil.TabIndex = 0;
            btnHesabiSil.Text = "Hesabi Sil";
            btnHesabiSil.UseVisualStyleBackColor = false;
            btnHesabiSil.Click += btnHesabiSil_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(53, 59);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(118, 28);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "AD SOYAD ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 99);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Yasiniz :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 134);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Boyunuz :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 169);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 2;
            label5.Text = "Kilonuz :";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(121, 99);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(25, 20);
            lblYas.TabIndex = 3;
            lblYas.Text = "11";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(121, 134);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(33, 20);
            lblBoy.TabIndex = 3;
            lblBoy.Text = "111";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(121, 169);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(25, 20);
            lblKilo.TabIndex = 3;
            lblKilo.Text = "11";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 207);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 2;
            label8.Text = "Hedef Kilonuz :";
            // 
            // lblHedefKilo
            // 
            lblHedefKilo.AutoSize = true;
            lblHedefKilo.Location = new Point(169, 207);
            lblHedefKilo.Name = "lblHedefKilo";
            lblHedefKilo.Size = new Size(25, 20);
            lblHedefKilo.TabIndex = 3;
            lblHedefKilo.Text = "11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 241);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 2;
            label10.Text = "Aktivite Duzeyiniz :";
            // 
            // lblAktiviteDuzeyi
            // 
            lblAktiviteDuzeyi.AutoSize = true;
            lblAktiviteDuzeyi.Location = new Point(196, 241);
            lblAktiviteDuzeyi.Name = "lblAktiviteDuzeyi";
            lblAktiviteDuzeyi.Size = new Size(38, 20);
            lblAktiviteDuzeyi.TabIndex = 3;
            lblAktiviteDuzeyi.Text = "Orta";
            // 
            // HesabimEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(368, 497);
            Controls.Add(lblAktiviteDuzeyi);
            Controls.Add(lblHedefKilo);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(lblYas);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAdSoyad);
            Controls.Add(btnHesabiSil);
            Controls.Add(btnProfiliDuzenle);
            Name = "HesabimEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HesabimEkrani";
            Load += HesabimEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfiliDuzenle;
        private Button btnHesabiSil;
        private Label lblAdSoyad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblYas;
        private Label lblBoy;
        private Label lblKilo;
        private Label label8;
        private Label lblHedefKilo;
        private Label label10;
        private Label lblAktiviteDuzeyi;
    }
}