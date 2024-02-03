namespace DietApp.UI
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            cboxSifreGizleGoster = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnGirisYap = new Button();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // cboxSifreGizleGoster
            // 
            cboxSifreGizleGoster.AutoSize = true;
            cboxSifreGizleGoster.BackColor = Color.Transparent;
            cboxSifreGizleGoster.Location = new Point(70, 202);
            cboxSifreGizleGoster.Name = "cboxSifreGizleGoster";
            cboxSifreGizleGoster.Size = new Size(94, 19);
            cboxSifreGizleGoster.TabIndex = 0;
            cboxSifreGizleGoster.Text = "Sifreyi goster";
            cboxSifreGizleGoster.UseVisualStyleBackColor = false;
            cboxSifreGizleGoster.CheckedChanged += cboxSifreGizleGoster_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(70, 239);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(155, 34);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(70, 173);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(155, 23);
            txtSifre.TabIndex = 5;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(479, 305);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(btnGirisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxSifreGizleGoster);
            DoubleBuffered = true;
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisEkrani";
            Load += GirisEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cboxSifreGizleGoster;
        private Label label1;
        private Label label2;
        private Button btnGirisYap;
        private TextBox txtEmail;
        private TextBox txtSifre;
    }
}