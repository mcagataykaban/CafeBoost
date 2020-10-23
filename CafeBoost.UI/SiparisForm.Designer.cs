namespace CafeBoost.UI
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboMasalar = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa No";
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(16, 32);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(183, 24);
            this.cboUrun.TabIndex = 3;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdet.Location = new System.Drawing.Point(205, 34);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(131, 22);
            this.nudAdet.TabIndex = 4;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(342, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 27);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboMasalar
            // 
            this.cboMasalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMasalar.FormattingEnabled = true;
            this.cboMasalar.Location = new System.Drawing.Point(476, 30);
            this.cboMasalar.Name = "cboMasalar";
            this.cboMasalar.Size = new System.Drawing.Size(114, 24);
            this.cboMasalar.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasaTasi.Location = new System.Drawing.Point(596, 29);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(101, 27);
            this.btnMasaTasi.TabIndex = 7;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            this.btnMasaTasi.Click += new System.EventHandler(this.btnMasaTasi_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Salmon;
            this.lblMasaNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasaNo.Location = new System.Drawing.Point(469, 71);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(221, 212);
            this.lblMasaNo.TabIndex = 8;
            this.lblMasaNo.Text = "05";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödeme Tutarı : ";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(599, 300);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(0, 20);
            this.lblOdemeTutari.TabIndex = 10;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Firebrick;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisIptal.Location = new System.Drawing.Point(465, 332);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(109, 57);
            this.btnSiparisIptal.TabIndex = 11;
            this.btnSiparisIptal.Text = "Sipariş İptal";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeAl.Location = new System.Drawing.Point(580, 332);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(106, 57);
            this.btnOdemeAl.TabIndex = 12;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfa.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnasayfa.Location = new System.Drawing.Point(465, 395);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(221, 57);
            this.btnAnasayfa.TabIndex = 13;
            this.btnAnasayfa.Text = "Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(16, 71);
            this.dgvSiparisDetaylar.MultiSelect = false;
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.RowHeadersVisible = false;
            this.dgvSiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(435, 378);
            this.dgvSiparisDetaylar.TabIndex = 14;
            this.dgvSiparisDetaylar.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSiparisDetaylar_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            this.Column2.HeaderText = "Birim Fiyat";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 471);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.cboMasalar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(720, 510);
            this.Name = "SiparisForm";
            this.Text = "Masa 01 - Sipariş Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cboMasalar;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}