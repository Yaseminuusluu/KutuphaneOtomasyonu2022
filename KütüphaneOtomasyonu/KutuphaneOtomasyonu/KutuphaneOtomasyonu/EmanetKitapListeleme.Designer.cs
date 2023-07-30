namespace KutuphaneOtomasyonu
{
    partial class EmanetKitapListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapListeleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeriK = new System.Windows.Forms.Button();
            this.btnCikisK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeriK
            // 
            this.btnGeriK.BackColor = System.Drawing.Color.Silver;
            this.btnGeriK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriK.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriK.Image")));
            this.btnGeriK.Location = new System.Drawing.Point(28, 24);
            this.btnGeriK.Name = "btnGeriK";
            this.btnGeriK.Size = new System.Drawing.Size(53, 49);
            this.btnGeriK.TabIndex = 18;
            this.btnGeriK.UseVisualStyleBackColor = false;
            this.btnGeriK.Click += new System.EventHandler(this.btnGeriK_Click);
            // 
            // btnCikisK
            // 
            this.btnCikisK.BackColor = System.Drawing.Color.Silver;
            this.btnCikisK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikisK.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisK.Image")));
            this.btnCikisK.Location = new System.Drawing.Point(874, 24);
            this.btnCikisK.Name = "btnCikisK";
            this.btnCikisK.Size = new System.Drawing.Size(53, 49);
            this.btnCikisK.TabIndex = 20;
            this.btnCikisK.UseVisualStyleBackColor = false;
            this.btnCikisK.Click += new System.EventHandler(this.btnCikisK_Click);
            // 
            // EmanetKitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(954, 620);
            this.Controls.Add(this.btnCikisK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeriK);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmanetKitapListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetKitapListeleme";
            this.Load += new System.EventHandler(this.EmanetKitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGeriK;
        private System.Windows.Forms.Button btnCikisK;
    }
}