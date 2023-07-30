namespace KutuphaneOtomasyonu
{
    partial class KitapTeslimSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapTeslimSayfasi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikisK = new System.Windows.Forms.Button();
            this.btnGeriK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnİadeEt = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikisK
            // 
            this.btnCikisK.BackColor = System.Drawing.Color.Silver;
            this.btnCikisK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikisK.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisK.Image")));
            this.btnCikisK.Location = new System.Drawing.Point(1260, 22);
            this.btnCikisK.Name = "btnCikisK";
            this.btnCikisK.Size = new System.Drawing.Size(53, 49);
            this.btnCikisK.TabIndex = 16;
            this.btnCikisK.UseVisualStyleBackColor = false;
            this.btnCikisK.Click += new System.EventHandler(this.btnCikisK_Click);
            // 
            // btnGeriK
            // 
            this.btnGeriK.BackColor = System.Drawing.Color.Silver;
            this.btnGeriK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriK.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriK.Image")));
            this.btnGeriK.Location = new System.Drawing.Point(30, 22);
            this.btnGeriK.Name = "btnGeriK";
            this.btnGeriK.Size = new System.Drawing.Size(53, 49);
            this.btnGeriK.TabIndex = 15;
            this.btnGeriK.UseVisualStyleBackColor = false;
            this.btnGeriK.Click += new System.EventHandler(this.btnGeriK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 416);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnİadeEt
            // 
            this.btnİadeEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnİadeEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİadeEt.Location = new System.Drawing.Point(587, 640);
            this.btnİadeEt.Name = "btnİadeEt";
            this.btnİadeEt.Size = new System.Drawing.Size(160, 60);
            this.btnİadeEt.TabIndex = 24;
            this.btnİadeEt.Text = "İade Et";
            this.btnİadeEt.UseVisualStyleBackColor = false;
            this.btnİadeEt.Click += new System.EventHandler(this.btnİadeEt_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(587, 49);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(171, 22);
            this.txtTc.TabIndex = 25;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(940, 49);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(171, 22);
            this.txtBarkodNo.TabIndex = 26;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = " TC ye Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Barkod No Göre";
            // 
            // KitapTeslimSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1347, 833);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.btnİadeEt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikisK);
            this.Controls.Add(this.btnGeriK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapTeslimSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapTeslimSayfasİ";
            this.Load += new System.EventHandler(this.KitapTeslimSayfasi_Load);
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
        private System.Windows.Forms.Button btnİadeEt;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}