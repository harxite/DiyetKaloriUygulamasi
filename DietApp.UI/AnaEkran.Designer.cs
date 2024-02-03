namespace DietApp.UI
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            gbOgleYemegi = new GroupBox();
            lblOgleToplamK = new Label();
            label1 = new Label();
            lbOgleYemegi = new ListBox();
            btnSilOgle = new Button();
            btnEkleOgle = new Button();
            btnDuzenleOgle = new Button();
            gbAksamYemegi = new GroupBox();
            lblAksamToplamK = new Label();
            label2 = new Label();
            lbAksamYemegi = new ListBox();
            btnSilAksam = new Button();
            btnEkleAksam = new Button();
            btnDuzenleAksam = new Button();
            gbAraOgun = new GroupBox();
            lblAraToplamK = new Label();
            label3 = new Label();
            lbAraOgun = new ListBox();
            btnSilAraOgun = new Button();
            btnEkleAraOgun = new Button();
            btnDuzenleAraOgun = new Button();
            dtpGununTarihi = new DateTimePicker();
            btnHesabim = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox5 = new GroupBox();
            lblToplamProtein = new Label();
            lblToplamYag = new Label();
            lblToplamKarbonhidrat = new Label();
            lblToplamKalori = new Label();
            label15 = new Label();
            btnAnaliz = new Button();
            lblKaloriIhtiyaci = new Label();
            btnSecilenGunuGoster = new Button();
            label5 = new Label();
            btnEkleKahvalti = new Button();
            btnDuzenleKahvalti = new Button();
            btnSilKahvalti = new Button();
            lbKahvalti = new ListBox();
            label4 = new Label();
            lblKahvaltiToplamK = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            gbOgleYemegi.SuspendLayout();
            gbAksamYemegi.SuspendLayout();
            gbAraOgun.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbOgleYemegi
            // 
            gbOgleYemegi.BackColor = Color.Transparent;
            gbOgleYemegi.Controls.Add(lblOgleToplamK);
            gbOgleYemegi.Controls.Add(label1);
            gbOgleYemegi.Controls.Add(lbOgleYemegi);
            gbOgleYemegi.Controls.Add(btnSilOgle);
            gbOgleYemegi.Controls.Add(btnEkleOgle);
            gbOgleYemegi.Controls.Add(btnDuzenleOgle);
            gbOgleYemegi.ForeColor = Color.Black;
            gbOgleYemegi.Location = new Point(460, 382);
            gbOgleYemegi.Name = "gbOgleYemegi";
            gbOgleYemegi.Size = new Size(419, 238);
            gbOgleYemegi.TabIndex = 0;
            gbOgleYemegi.TabStop = false;
            // 
            // lblOgleToplamK
            // 
            lblOgleToplamK.AutoSize = true;
            lblOgleToplamK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgleToplamK.ForeColor = Color.Black;
            lblOgleToplamK.Location = new Point(58, 204);
            lblOgleToplamK.Name = "lblOgleToplamK";
            lblOgleToplamK.Size = new Size(18, 20);
            lblOgleToplamK.TabIndex = 6;
            lblOgleToplamK.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 184);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Toplam Kalori ";
            // 
            // lbOgleYemegi
            // 
            lbOgleYemegi.FormattingEnabled = true;
            lbOgleYemegi.ItemHeight = 20;
            lbOgleYemegi.Location = new Point(6, 27);
            lbOgleYemegi.Name = "lbOgleYemegi";
            lbOgleYemegi.Size = new Size(291, 144);
            lbOgleYemegi.TabIndex = 0;
            lbOgleYemegi.MouseClick += lbOgleYemegi_MouseClick;
            // 
            // btnSilOgle
            // 
            btnSilOgle.Location = new Point(303, 180);
            btnSilOgle.Name = "btnSilOgle";
            btnSilOgle.Size = new Size(94, 29);
            btnSilOgle.TabIndex = 0;
            btnSilOgle.Text = "Sil";
            btnSilOgle.UseVisualStyleBackColor = true;
            btnSilOgle.Click += btnSilOgle_Click;
            // 
            // btnEkleOgle
            // 
            btnEkleOgle.Location = new Point(303, 27);
            btnEkleOgle.Name = "btnEkleOgle";
            btnEkleOgle.Size = new Size(94, 104);
            btnEkleOgle.TabIndex = 0;
            btnEkleOgle.Text = "Ekle";
            btnEkleOgle.UseVisualStyleBackColor = true;
            btnEkleOgle.Click += btnEkleOgle_Click;
            // 
            // btnDuzenleOgle
            // 
            btnDuzenleOgle.Location = new Point(303, 142);
            btnDuzenleOgle.Name = "btnDuzenleOgle";
            btnDuzenleOgle.Size = new Size(94, 29);
            btnDuzenleOgle.TabIndex = 0;
            btnDuzenleOgle.Text = "Duzenle";
            btnDuzenleOgle.UseVisualStyleBackColor = true;
            btnDuzenleOgle.Click += btnDuzenleOgle_Click;
            // 
            // gbAksamYemegi
            // 
            gbAksamYemegi.BackColor = Color.Transparent;
            gbAksamYemegi.Controls.Add(lblAksamToplamK);
            gbAksamYemegi.Controls.Add(label2);
            gbAksamYemegi.Controls.Add(lbAksamYemegi);
            gbAksamYemegi.Controls.Add(btnSilAksam);
            gbAksamYemegi.Controls.Add(btnEkleAksam);
            gbAksamYemegi.Controls.Add(btnDuzenleAksam);
            gbAksamYemegi.ForeColor = Color.Black;
            gbAksamYemegi.Location = new Point(9, 655);
            gbAksamYemegi.Name = "gbAksamYemegi";
            gbAksamYemegi.Size = new Size(419, 253);
            gbAksamYemegi.TabIndex = 0;
            gbAksamYemegi.TabStop = false;
            // 
            // lblAksamToplamK
            // 
            lblAksamToplamK.AutoSize = true;
            lblAksamToplamK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAksamToplamK.Location = new Point(225, 212);
            lblAksamToplamK.Name = "lblAksamToplamK";
            lblAksamToplamK.Size = new Size(18, 20);
            lblAksamToplamK.TabIndex = 6;
            lblAksamToplamK.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 192);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Toplam Kalori ";
            // 
            // lbAksamYemegi
            // 
            lbAksamYemegi.FormattingEnabled = true;
            lbAksamYemegi.ItemHeight = 20;
            lbAksamYemegi.Location = new Point(6, 27);
            lbAksamYemegi.Name = "lbAksamYemegi";
            lbAksamYemegi.Size = new Size(291, 144);
            lbAksamYemegi.TabIndex = 0;
            lbAksamYemegi.MouseClick += lbAksamYemegi_MouseClick;
            // 
            // btnSilAksam
            // 
            btnSilAksam.Location = new Point(303, 192);
            btnSilAksam.Name = "btnSilAksam";
            btnSilAksam.Size = new Size(94, 29);
            btnSilAksam.TabIndex = 0;
            btnSilAksam.Text = "Sil";
            btnSilAksam.UseVisualStyleBackColor = true;
            btnSilAksam.Click += btnSilAksam_Click;
            // 
            // btnEkleAksam
            // 
            btnEkleAksam.Location = new Point(303, 27);
            btnEkleAksam.Name = "btnEkleAksam";
            btnEkleAksam.Size = new Size(94, 104);
            btnEkleAksam.TabIndex = 0;
            btnEkleAksam.Text = "Ekle";
            btnEkleAksam.UseVisualStyleBackColor = true;
            btnEkleAksam.Click += btnEkleAksam_Click;
            // 
            // btnDuzenleAksam
            // 
            btnDuzenleAksam.Location = new Point(303, 142);
            btnDuzenleAksam.Name = "btnDuzenleAksam";
            btnDuzenleAksam.Size = new Size(94, 29);
            btnDuzenleAksam.TabIndex = 0;
            btnDuzenleAksam.Text = "Duzenle";
            btnDuzenleAksam.UseVisualStyleBackColor = true;
            btnDuzenleAksam.Click += btnDuzenleAksam_Click;
            // 
            // gbAraOgun
            // 
            gbAraOgun.BackColor = Color.Transparent;
            gbAraOgun.Controls.Add(lblAraToplamK);
            gbAraOgun.Controls.Add(label3);
            gbAraOgun.Controls.Add(lbAraOgun);
            gbAraOgun.Controls.Add(btnSilAraOgun);
            gbAraOgun.Controls.Add(btnEkleAraOgun);
            gbAraOgun.Controls.Add(btnDuzenleAraOgun);
            gbAraOgun.ForeColor = Color.Black;
            gbAraOgun.Location = new Point(457, 655);
            gbAraOgun.Name = "gbAraOgun";
            gbAraOgun.Size = new Size(419, 253);
            gbAraOgun.TabIndex = 0;
            gbAraOgun.TabStop = false;
            // 
            // lblAraToplamK
            // 
            lblAraToplamK.AutoSize = true;
            lblAraToplamK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAraToplamK.Location = new Point(62, 222);
            lblAraToplamK.Name = "lblAraToplamK";
            lblAraToplamK.Size = new Size(18, 20);
            lblAraToplamK.TabIndex = 6;
            lblAraToplamK.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 196);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 1;
            label3.Text = "Toplam Kalori ";
            // 
            // lbAraOgun
            // 
            lbAraOgun.FormattingEnabled = true;
            lbAraOgun.ItemHeight = 20;
            lbAraOgun.Location = new Point(6, 27);
            lbAraOgun.Name = "lbAraOgun";
            lbAraOgun.Size = new Size(291, 144);
            lbAraOgun.TabIndex = 0;
            lbAraOgun.MouseClick += lbAraOgun_MouseClick;
            // 
            // btnSilAraOgun
            // 
            btnSilAraOgun.Location = new Point(306, 183);
            btnSilAraOgun.Name = "btnSilAraOgun";
            btnSilAraOgun.Size = new Size(94, 29);
            btnSilAraOgun.TabIndex = 0;
            btnSilAraOgun.Text = "Sil";
            btnSilAraOgun.UseVisualStyleBackColor = true;
            btnSilAraOgun.Click += btnSilAraOgun_Click;
            // 
            // btnEkleAraOgun
            // 
            btnEkleAraOgun.Location = new Point(305, 27);
            btnEkleAraOgun.Name = "btnEkleAraOgun";
            btnEkleAraOgun.Size = new Size(94, 104);
            btnEkleAraOgun.TabIndex = 0;
            btnEkleAraOgun.Text = "Ekle";
            btnEkleAraOgun.UseVisualStyleBackColor = true;
            btnEkleAraOgun.Click += btnEkleAraOgun_Click;
            // 
            // btnDuzenleAraOgun
            // 
            btnDuzenleAraOgun.Location = new Point(306, 142);
            btnDuzenleAraOgun.Name = "btnDuzenleAraOgun";
            btnDuzenleAraOgun.Size = new Size(94, 29);
            btnDuzenleAraOgun.TabIndex = 0;
            btnDuzenleAraOgun.Text = "Duzenle";
            btnDuzenleAraOgun.UseVisualStyleBackColor = true;
            btnDuzenleAraOgun.Click += btnDuzenleAraOgun_Click;
            // 
            // dtpGununTarihi
            // 
            dtpGununTarihi.Location = new Point(12, 30);
            dtpGununTarihi.Name = "dtpGununTarihi";
            dtpGununTarihi.Size = new Size(278, 27);
            dtpGununTarihi.TabIndex = 1;
            // 
            // btnHesabim
            // 
            btnHesabim.ForeColor = Color.Black;
            btnHesabim.Location = new Point(689, 30);
            btnHesabim.Name = "btnHesabim";
            btnHesabim.Size = new Size(167, 44);
            btnHesabim.TabIndex = 2;
            btnHesabim.Text = "Hesabim";
            btnHesabim.UseVisualStyleBackColor = true;
            btnHesabim.Click += btnHesabim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 52);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 4;
            label6.Text = "Toplam Kalori :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(75, 183);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 4;
            label7.Text = "Toplam Protein :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(88, 251);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 4;
            label8.Text = "Toplam Yag :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(54, 115);
            label9.Name = "label9";
            label9.Size = new Size(166, 20);
            label9.TabIndex = 4;
            label9.Text = "Toplam Karbonhidrat :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(48, 212);
            label10.Name = "label10";
            label10.Size = new Size(192, 23);
            label10.TabIndex = 3;
            label10.Text = "Gunluk Kalori Ihtiyaci :";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(lblToplamProtein);
            groupBox5.Controls.Add(lblToplamYag);
            groupBox5.Controls.Add(lblToplamKarbonhidrat);
            groupBox5.Controls.Add(lblToplamKalori);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(297, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(278, 331);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // lblToplamProtein
            // 
            lblToplamProtein.AutoSize = true;
            lblToplamProtein.BackColor = Color.Transparent;
            lblToplamProtein.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamProtein.ForeColor = Color.Brown;
            lblToplamProtein.Location = new Point(101, 218);
            lblToplamProtein.Name = "lblToplamProtein";
            lblToplamProtein.Size = new Size(50, 28);
            lblToplamProtein.TabIndex = 6;
            lblToplamProtein.Text = "0 gr";
            // 
            // lblToplamYag
            // 
            lblToplamYag.AutoSize = true;
            lblToplamYag.BackColor = Color.Transparent;
            lblToplamYag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamYag.ForeColor = Color.Brown;
            lblToplamYag.Location = new Point(101, 286);
            lblToplamYag.Name = "lblToplamYag";
            lblToplamYag.Size = new Size(50, 28);
            lblToplamYag.TabIndex = 6;
            lblToplamYag.Text = "0 gr";
            // 
            // lblToplamKarbonhidrat
            // 
            lblToplamKarbonhidrat.AutoSize = true;
            lblToplamKarbonhidrat.BackColor = Color.Transparent;
            lblToplamKarbonhidrat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKarbonhidrat.ForeColor = Color.Brown;
            lblToplamKarbonhidrat.Location = new Point(101, 150);
            lblToplamKarbonhidrat.Name = "lblToplamKarbonhidrat";
            lblToplamKarbonhidrat.Size = new Size(50, 28);
            lblToplamKarbonhidrat.TabIndex = 6;
            lblToplamKarbonhidrat.Text = "0 gr";
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.BackColor = Color.Transparent;
            lblToplamKalori.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKalori.ForeColor = Color.Brown;
            lblToplamKalori.Location = new Point(112, 80);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(29, 35);
            lblToplamKalori.TabIndex = 6;
            lblToplamKalori.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Green;
            label15.Location = new Point(47, 12);
            label15.Name = "label15";
            label15.Size = new Size(173, 35);
            label15.TabIndex = 9;
            label15.Text = "Gunun Ozeti";
            // 
            // btnAnaliz
            // 
            btnAnaliz.ForeColor = Color.Black;
            btnAnaliz.Location = new Point(689, 104);
            btnAnaliz.Name = "btnAnaliz";
            btnAnaliz.Size = new Size(167, 44);
            btnAnaliz.TabIndex = 2;
            btnAnaliz.Text = "ANALIZ / RAPORLAR";
            btnAnaliz.UseVisualStyleBackColor = true;
            btnAnaliz.Click += btnAnaliz_Click;
            // 
            // lblKaloriIhtiyaci
            // 
            lblKaloriIhtiyaci.AutoSize = true;
            lblKaloriIhtiyaci.BackColor = Color.OldLace;
            lblKaloriIhtiyaci.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblKaloriIhtiyaci.ForeColor = Color.Brown;
            lblKaloriIhtiyaci.Location = new Point(105, 263);
            lblKaloriIhtiyaci.Name = "lblKaloriIhtiyaci";
            lblKaloriIhtiyaci.Size = new Size(29, 35);
            lblKaloriIhtiyaci.TabIndex = 6;
            lblKaloriIhtiyaci.Text = "0";
            // 
            // btnSecilenGunuGoster
            // 
            btnSecilenGunuGoster.ForeColor = Color.Black;
            btnSecilenGunuGoster.Location = new Point(196, 104);
            btnSecilenGunuGoster.Name = "btnSecilenGunuGoster";
            btnSecilenGunuGoster.Size = new Size(94, 29);
            btnSecilenGunuGoster.TabIndex = 7;
            btnSecilenGunuGoster.Text = "Goster";
            btnSecilenGunuGoster.UseVisualStyleBackColor = true;
            btnSecilenGunuGoster.Click += btnSecilenGunuGoster_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 59);
            label5.Name = "label5";
            label5.Size = new Size(276, 40);
            label5.TabIndex = 8;
            label5.Text = "Detaylarini gormek istediginiz gunu secip,\r\n'Goster' butonuna tiklayabilirsiniz.";
            // 
            // btnEkleKahvalti
            // 
            btnEkleKahvalti.ForeColor = Color.Black;
            btnEkleKahvalti.Location = new Point(315, 30);
            btnEkleKahvalti.Name = "btnEkleKahvalti";
            btnEkleKahvalti.Size = new Size(94, 104);
            btnEkleKahvalti.TabIndex = 0;
            btnEkleKahvalti.Text = "Ekle";
            btnEkleKahvalti.UseVisualStyleBackColor = true;
            btnEkleKahvalti.Click += btnEkleKahvalti_Click;
            // 
            // btnDuzenleKahvalti
            // 
            btnDuzenleKahvalti.ForeColor = Color.Black;
            btnDuzenleKahvalti.Location = new Point(315, 145);
            btnDuzenleKahvalti.Name = "btnDuzenleKahvalti";
            btnDuzenleKahvalti.Size = new Size(94, 29);
            btnDuzenleKahvalti.TabIndex = 0;
            btnDuzenleKahvalti.Text = "Duzenle";
            btnDuzenleKahvalti.UseVisualStyleBackColor = true;
            btnDuzenleKahvalti.Click += btnDuzenleKahvalti_Click;
            // 
            // btnSilKahvalti
            // 
            btnSilKahvalti.ForeColor = Color.Black;
            btnSilKahvalti.Location = new Point(315, 188);
            btnSilKahvalti.Name = "btnSilKahvalti";
            btnSilKahvalti.Size = new Size(94, 29);
            btnSilKahvalti.TabIndex = 0;
            btnSilKahvalti.Text = "Sil";
            btnSilKahvalti.UseVisualStyleBackColor = true;
            btnSilKahvalti.Click += btnSilKahvalti_Click;
            // 
            // lbKahvalti
            // 
            lbKahvalti.FormattingEnabled = true;
            lbKahvalti.ItemHeight = 20;
            lbKahvalti.Location = new Point(6, 30);
            lbKahvalti.Name = "lbKahvalti";
            lbKahvalti.Size = new Size(291, 144);
            lbKahvalti.TabIndex = 0;
            lbKahvalti.MouseClick += lbKahvalti_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(191, 185);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 1;
            label4.Text = "Toplam Kalori ";
            // 
            // lblKahvaltiToplamK
            // 
            lblKahvaltiToplamK.AutoSize = true;
            lblKahvaltiToplamK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKahvaltiToplamK.ForeColor = Color.Black;
            lblKahvaltiToplamK.Location = new Point(225, 205);
            lblKahvaltiToplamK.Name = "lblKahvaltiToplamK";
            lblKahvaltiToplamK.Size = new Size(18, 20);
            lblKahvaltiToplamK.TabIndex = 6;
            lblKahvaltiToplamK.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(312, 359);
            label11.Name = "label11";
            label11.Size = new Size(122, 29);
            label11.TabIndex = 9;
            label11.Text = "KAHVALTI";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lbKahvalti);
            groupBox1.Controls.Add(btnEkleKahvalti);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblKahvaltiToplamK);
            groupBox1.Controls.Add(btnDuzenleKahvalti);
            groupBox1.Controls.Add(btnSilKahvalti);
            groupBox1.Location = new Point(9, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 238);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(457, 359);
            label12.Name = "label12";
            label12.Size = new Size(162, 29);
            label12.TabIndex = 9;
            label12.Text = "OGLE YEMEGI";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(247, 623);
            label13.Name = "label13";
            label13.Size = new Size(181, 29);
            label13.TabIndex = 9;
            label13.Text = "AKSAM YEMEGI";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Green;
            label14.Location = new Point(457, 623);
            label14.Name = "label14";
            label14.Size = new Size(125, 29);
            label14.TabIndex = 9;
            label14.Text = "ARA OGUN";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 915);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(btnSecilenGunuGoster);
            Controls.Add(groupBox5);
            Controls.Add(label10);
            Controls.Add(btnAnaliz);
            Controls.Add(lblKaloriIhtiyaci);
            Controls.Add(btnHesabim);
            Controls.Add(dtpGununTarihi);
            Controls.Add(gbAraOgun);
            Controls.Add(gbAksamYemegi);
            Controls.Add(gbOgleYemegi);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            gbOgleYemegi.ResumeLayout(false);
            gbOgleYemegi.PerformLayout();
            gbAksamYemegi.ResumeLayout(false);
            gbAksamYemegi.PerformLayout();
            gbAraOgun.ResumeLayout(false);
            gbAraOgun.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbOgleYemegi;
        private ListBox lbOgleYemegi;
        private Label label1;
        private GroupBox gbAksamYemegi;
        private Label label2;
        private ListBox lbAksamYemegi;
        private GroupBox gbAraOgun;
        private Label label3;
        private ListBox lbAraOgun;
        private DateTimePicker dtpGununTarihi;
        private Button btnHesabim;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox5;
        private Button btnAnaliz;
        private Button btnSilOgle;
        private Button btnEkleOgle;
        private Button btnDuzenleOgle;
        private Button btnSilAksam;
        private Button btnEkleAksam;
        private Button btnDuzenleAksam;
        private Button btnSilAraOgun;
        private Button btnEkleAraOgun;
        private Button btnDuzenleAraOgun;
        private Label lblOgleToplamK;
        private Label lblAksamToplamK;
        private Label lblAraToplamK;
        private Label lblToplamProtein;
        private Label lblToplamYag;
        private Label lblToplamKarbonhidrat;
        private Label lblToplamKalori;
        private Label lblKaloriIhtiyaci;
        private Button btnSecilenGunuGoster;
        private Label label5;
        private Button btnEkleKahvalti;
        private Button btnDuzenleKahvalti;
        private Button btnSilKahvalti;
        private ListBox lbKahvalti;
        private Label label4;
        private Label lblKahvaltiToplamK;
        private Label label11;
        private GroupBox groupBox1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}