namespace KutuphaneOtomasyonu
{
    partial class KitapEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikisK = new System.Windows.Forms.Button();
            this.btnGeriK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTemizleK = new System.Windows.Forms.Button();
            this.btnGuncelleK = new System.Windows.Forms.Button();
            this.btnSilK = new System.Windows.Forms.Button();
            this.btnEkleK = new System.Windows.Forms.Button();
            this.KitapNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSayfaS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYıl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCikisK
            // 
            this.btnCikisK.BackColor = System.Drawing.Color.Silver;
            this.btnCikisK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikisK.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisK.Image")));
            this.btnCikisK.Location = new System.Drawing.Point(1215, 22);
            this.btnCikisK.Name = "btnCikisK";
            this.btnCikisK.Size = new System.Drawing.Size(53, 49);
            this.btnCikisK.TabIndex = 13;
            this.btnCikisK.UseVisualStyleBackColor = false;
            this.btnCikisK.Click += new System.EventHandler(this.btnCikisK_Click);
            // 
            // btnGeriK
            // 
            this.btnGeriK.BackColor = System.Drawing.Color.Silver;
            this.btnGeriK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriK.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriK.Image")));
            this.btnGeriK.Location = new System.Drawing.Point(27, 22);
            this.btnGeriK.Name = "btnGeriK";
            this.btnGeriK.Size = new System.Drawing.Size(53, 49);
            this.btnGeriK.TabIndex = 12;
            this.btnGeriK.UseVisualStyleBackColor = false;
            this.btnGeriK.Click += new System.EventHandler(this.btnGeriK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 539);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 272);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnTemizleK
            // 
            this.btnTemizleK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnTemizleK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleK.Location = new System.Drawing.Point(1077, 319);
            this.btnTemizleK.Name = "btnTemizleK";
            this.btnTemizleK.Size = new System.Drawing.Size(160, 60);
            this.btnTemizleK.TabIndex = 13;
            this.btnTemizleK.Text = "Temizle";
            this.btnTemizleK.UseVisualStyleBackColor = false;
            this.btnTemizleK.Click += new System.EventHandler(this.btnTemizleK_Click);
            // 
            // btnGuncelleK
            // 
            this.btnGuncelleK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnGuncelleK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelleK.Location = new System.Drawing.Point(711, 319);
            this.btnGuncelleK.Name = "btnGuncelleK";
            this.btnGuncelleK.Size = new System.Drawing.Size(160, 60);
            this.btnGuncelleK.TabIndex = 11;
            this.btnGuncelleK.Text = "Güncelle";
            this.btnGuncelleK.UseVisualStyleBackColor = false;
            this.btnGuncelleK.Click += new System.EventHandler(this.btnGuncelleK_Click);
            // 
            // btnSilK
            // 
            this.btnSilK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnSilK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilK.Location = new System.Drawing.Point(893, 319);
            this.btnSilK.Name = "btnSilK";
            this.btnSilK.Size = new System.Drawing.Size(160, 60);
            this.btnSilK.TabIndex = 12;
            this.btnSilK.Text = "Sil";
            this.btnSilK.UseVisualStyleBackColor = false;
            this.btnSilK.Click += new System.EventHandler(this.btnSilK_Click);
            // 
            // btnEkleK
            // 
            this.btnEkleK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnEkleK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleK.Location = new System.Drawing.Point(521, 319);
            this.btnEkleK.Name = "btnEkleK";
            this.btnEkleK.Size = new System.Drawing.Size(160, 60);
            this.btnEkleK.TabIndex = 10;
            this.btnEkleK.Text = "Ekle";
            this.btnEkleK.UseVisualStyleBackColor = false;
            this.btnEkleK.Click += new System.EventHandler(this.btnEkleK_Click);
            // 
            // KitapNo
            // 
            this.KitapNo.AutoSize = true;
            this.KitapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapNo.Location = new System.Drawing.Point(51, 158);
            this.KitapNo.Name = "KitapNo";
            this.KitapNo.Size = new System.Drawing.Size(73, 18);
            this.KitapNo.TabIndex = 40;
            this.KitapNo.Text = "Kitap No";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(159, 157);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(244, 22);
            this.txtNo.TabIndex = 0;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(159, 229);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(244, 22);
            this.txtAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kitap Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(159, 263);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(244, 22);
            this.txtYazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Yazar";
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.Location = new System.Drawing.Point(159, 302);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(244, 22);
            this.txtYayınevi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Yayınevi";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(159, 339);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(244, 22);
            this.txtTur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kitap Türü";
            // 
            // txtSayfaS
            // 
            this.txtSayfaS.Location = new System.Drawing.Point(159, 376);
            this.txtSayfaS.Name = "txtSayfaS";
            this.txtSayfaS.Size = new System.Drawing.Size(244, 22);
            this.txtSayfaS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // txtYıl
            // 
            this.txtYıl.Location = new System.Drawing.Point(159, 413);
            this.txtYıl.Name = "txtYıl";
            this.txtYıl.Size = new System.Drawing.Size(244, 22);
            this.txtYıl.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Basım Yıllı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(159, 454);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(244, 22);
            this.txtAciklama.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Açıklama";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(159, 192);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(244, 22);
            this.txtBarkod.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Barkod No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(159, 495);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(244, 22);
            this.txtStok.TabIndex = 9;
            this.txtStok.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "Stok Sayısı";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // KitapEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1290, 832);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYıl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSayfaS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYayınevi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.KitapNo);
            this.Controls.Add(this.btnTemizleK);
            this.Controls.Add(this.btnGuncelleK);
            this.Controls.Add(this.btnSilK);
            this.Controls.Add(this.btnEkleK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikisK);
            this.Controls.Add(this.btnGeriK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEkrani";
            this.Load += new System.EventHandler(this.KitapEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCikisK;
        private System.Windows.Forms.Button btnGeriK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTemizleK;
        private System.Windows.Forms.Button btnGuncelleK;
        private System.Windows.Forms.Button btnSilK;
        private System.Windows.Forms.Button btnEkleK;
        private System.Windows.Forms.Label KitapNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSayfaS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYıl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label9;
    }
}