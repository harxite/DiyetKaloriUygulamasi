namespace DietApp.UI
{
    partial class KarsilamaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarsilamaEkrani));
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.LightYellow;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.ForeColor = Color.Black;
            btnGirisYap.Location = new Point(111, 223);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(121, 46);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.LightYellow;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.ForeColor = Color.Black;
            btnKayitOl.Location = new Point(111, 283);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(121, 46);
            btnKayitOl.TabIndex = 0;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // KarsilamaEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(344, 530);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            DoubleBuffered = true;
            Name = "KarsilamaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KarsilamaEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGirisYap;
        private Button btnKayitOl;
    }
}