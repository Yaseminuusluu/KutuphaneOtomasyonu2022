namespace KutuphaneOtomasyonu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.picturKullanici = new System.Windows.Forms.PictureBox();
            this.pictureBoxSifre = new System.Windows.Forms.PictureBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.linkSİfreUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnCikisG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSifre)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 810);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(737, 233);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(230, 22);
            this.txtKullanıcı.TabIndex = 0;
            this.txtKullanıcı.TextChanged += new System.EventHandler(this.txtKullanıcı_TextChanged);
            this.txtKullanıcı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullanıcı_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(737, 362);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(230, 22);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(647, 236);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(84, 16);
            this.labelAdi.TabIndex = 3;
            this.labelAdi.Text = "Personel Adı";
            this.labelAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(640, 365);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(91, 16);
            this.labelSifre.TabIndex = 4;
            this.labelSifre.Text = "Personel Şifre";
            // 
            // picturKullanici
            // 
            this.picturKullanici.Image = ((System.Drawing.Image)(resources.GetObject("picturKullanici.Image")));
            this.picturKullanici.Location = new System.Drawing.Point(594, 224);
            this.picturKullanici.Name = "picturKullanici";
            this.picturKullanici.Size = new System.Drawing.Size(40, 40);
            this.picturKullanici.TabIndex = 7;
            this.picturKullanici.TabStop = false;
            // 
            // pictureBoxSifre
            // 
            this.pictureBoxSifre.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSifre.Image")));
            this.pictureBoxSifre.Location = new System.Drawing.Point(594, 344);
            this.pictureBoxSifre.Name = "pictureBoxSifre";
            this.pictureBoxSifre.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSifre.TabIndex = 8;
            this.pictureBoxSifre.TabStop = false;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.girisBtn.Location = new System.Drawing.Point(737, 480);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(160, 60);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // linkSİfreUnuttum
            // 
            this.linkSİfreUnuttum.AutoSize = true;
            this.linkSİfreUnuttum.LinkColor = System.Drawing.Color.Black;
            this.linkSİfreUnuttum.Location = new System.Drawing.Point(868, 387);
            this.linkSİfreUnuttum.Name = "linkSİfreUnuttum";
            this.linkSİfreUnuttum.Size = new System.Drawing.Size(99, 16);
            this.linkSİfreUnuttum.TabIndex = 4;
            this.linkSİfreUnuttum.TabStop = true;
            this.linkSİfreUnuttum.Text = "Şifremi Unuttum";
            this.linkSİfreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCikisG
            // 
            this.btnCikisG.BackColor = System.Drawing.Color.Silver;
            this.btnCikisG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikisG.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisG.Image")));
            this.btnCikisG.Location = new System.Drawing.Point(985, 28);
            this.btnCikisG.Name = "btnCikisG";
            this.btnCikisG.Size = new System.Drawing.Size(53, 49);
            this.btnCikisG.TabIndex = 9;
            this.btnCikisG.UseVisualStyleBackColor = false;
            this.btnCikisG.Click += new System.EventHandler(this.btnCikisG_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1050, 810);
            this.Controls.Add(this.btnCikisG);
            this.Controls.Add(this.linkSİfreUnuttum);
            this.Controls.Add(this.pictureBoxSifre);
            this.Controls.Add(this.picturKullanici);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSifre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.PictureBox picturKullanici;
        private System.Windows.Forms.PictureBox pictureBoxSifre;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.LinkLabel linkSİfreUnuttum;
        private System.Windows.Forms.Button btnCikisG;
    }
}

