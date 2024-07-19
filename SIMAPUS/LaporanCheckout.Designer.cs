namespace SIMAPUS
{
    partial class LaporanCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanCheckout));
            this.cari_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_checkout_txt = new System.Windows.Forms.TextBox();
            this.id_checkout_lbl = new System.Windows.Forms.Label();
            this.laporan_dgv = new System.Windows.Forms.DataGridView();
            this.Id_checkout_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_pasien_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_pasien_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_kelamin_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umur_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_lahir_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontak_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keluhan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_masuk_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_keluar_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_dokter_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipe_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya_pengobatan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cari_btn
            // 
            this.cari_btn.BackColor = System.Drawing.Color.Yellow;
            this.cari_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cari_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cari_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_btn.Location = new System.Drawing.Point(275, 184);
            this.cari_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(97, 33);
            this.cari_btn.TabIndex = 166;
            this.cari_btn.Text = "Cari";
            this.cari_btn.UseVisualStyleBackColor = false;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 164;
            this.label3.Text = "Laporan Checkout";
            // 
            // id_checkout_txt
            // 
            this.id_checkout_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_checkout_txt.Location = new System.Drawing.Point(351, 94);
            this.id_checkout_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_checkout_txt.Name = "id_checkout_txt";
            this.id_checkout_txt.Size = new System.Drawing.Size(184, 26);
            this.id_checkout_txt.TabIndex = 163;
            this.id_checkout_txt.TextChanged += new System.EventHandler(this.id_checkout_txt_TextChanged);
            // 
            // id_checkout_lbl
            // 
            this.id_checkout_lbl.AutoSize = true;
            this.id_checkout_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_checkout_lbl.Location = new System.Drawing.Point(217, 98);
            this.id_checkout_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_checkout_lbl.Name = "id_checkout_lbl";
            this.id_checkout_lbl.Size = new System.Drawing.Size(112, 20);
            this.id_checkout_lbl.TabIndex = 162;
            this.id_checkout_lbl.Text = "ID Checkout";
            // 
            // laporan_dgv
            // 
            this.laporan_dgv.AllowUserToAddRows = false;
            this.laporan_dgv.AllowUserToDeleteRows = false;
            this.laporan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laporan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_checkout_dgv,
            this.Id_pasien_dgv,
            this.Nama_pasien_dgv,
            this.Jenis_kelamin_dgv,
            this.Umur_dgv,
            this.Tanggal_lahir_dgv,
            this.Kontak_dgv,
            this.Alamat_dgv,
            this.Keluhan_dgv,
            this.Tanggal_masuk_dgv,
            this.Tanggal_keluar_dgv,
            this.Nama_dokter_dgv,
            this.No_ruangan_dgv,
            this.Nama_ruangan_dgv,
            this.Tipe_ruangan_dgv,
            this.Harga_ruangan_dgv,
            this.Biaya_pengobatan_dgv,
            this.Total_dgv});
            this.laporan_dgv.Location = new System.Drawing.Point(173, 273);
            this.laporan_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.laporan_dgv.Name = "laporan_dgv";
            this.laporan_dgv.ReadOnly = true;
            this.laporan_dgv.RowHeadersVisible = false;
            this.laporan_dgv.RowHeadersWidth = 51;
            this.laporan_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laporan_dgv.Size = new System.Drawing.Size(434, 117);
            this.laporan_dgv.TabIndex = 173;
            this.laporan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.laporan_dgv_CellClick);
            // 
            // Id_checkout_dgv
            // 
            this.Id_checkout_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_checkout_dgv.DataPropertyName = "id_checkout";
            this.Id_checkout_dgv.HeaderText = "Id_checkout";
            this.Id_checkout_dgv.MinimumWidth = 6;
            this.Id_checkout_dgv.Name = "Id_checkout_dgv";
            this.Id_checkout_dgv.ReadOnly = true;
            this.Id_checkout_dgv.Width = 108;
            // 
            // Id_pasien_dgv
            // 
            this.Id_pasien_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_pasien_dgv.DataPropertyName = "id_pasien";
            this.Id_pasien_dgv.HeaderText = "Id_pasien";
            this.Id_pasien_dgv.MinimumWidth = 6;
            this.Id_pasien_dgv.Name = "Id_pasien_dgv";
            this.Id_pasien_dgv.ReadOnly = true;
            this.Id_pasien_dgv.Width = 95;
            // 
            // Nama_pasien_dgv
            // 
            this.Nama_pasien_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nama_pasien_dgv.DataPropertyName = "nama_pasien";
            this.Nama_pasien_dgv.HeaderText = "Nama_pasien";
            this.Nama_pasien_dgv.MinimumWidth = 6;
            this.Nama_pasien_dgv.Name = "Nama_pasien_dgv";
            this.Nama_pasien_dgv.ReadOnly = true;
            this.Nama_pasien_dgv.Width = 121;
            // 
            // Jenis_kelamin_dgv
            // 
            this.Jenis_kelamin_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Jenis_kelamin_dgv.DataPropertyName = "jenis_kelamin";
            this.Jenis_kelamin_dgv.HeaderText = "Jenis_kelamin";
            this.Jenis_kelamin_dgv.MinimumWidth = 6;
            this.Jenis_kelamin_dgv.Name = "Jenis_kelamin_dgv";
            this.Jenis_kelamin_dgv.ReadOnly = true;
            this.Jenis_kelamin_dgv.Width = 122;
            // 
            // Umur_dgv
            // 
            this.Umur_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Umur_dgv.DataPropertyName = "umur";
            this.Umur_dgv.HeaderText = "Umur";
            this.Umur_dgv.MinimumWidth = 6;
            this.Umur_dgv.Name = "Umur_dgv";
            this.Umur_dgv.ReadOnly = true;
            this.Umur_dgv.Width = 68;
            // 
            // Tanggal_lahir_dgv
            // 
            this.Tanggal_lahir_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tanggal_lahir_dgv.DataPropertyName = "tanggal_lahir";
            this.Tanggal_lahir_dgv.HeaderText = "Tanggal_lahir";
            this.Tanggal_lahir_dgv.MinimumWidth = 6;
            this.Tanggal_lahir_dgv.Name = "Tanggal_lahir_dgv";
            this.Tanggal_lahir_dgv.ReadOnly = true;
            this.Tanggal_lahir_dgv.Width = 119;
            // 
            // Kontak_dgv
            // 
            this.Kontak_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Kontak_dgv.DataPropertyName = "kontak";
            this.Kontak_dgv.HeaderText = "Kontak";
            this.Kontak_dgv.MinimumWidth = 6;
            this.Kontak_dgv.Name = "Kontak_dgv";
            this.Kontak_dgv.ReadOnly = true;
            this.Kontak_dgv.Width = 77;
            // 
            // Alamat_dgv
            // 
            this.Alamat_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Alamat_dgv.DataPropertyName = "alamat";
            this.Alamat_dgv.HeaderText = "Alamat";
            this.Alamat_dgv.MinimumWidth = 6;
            this.Alamat_dgv.Name = "Alamat_dgv";
            this.Alamat_dgv.ReadOnly = true;
            this.Alamat_dgv.Width = 78;
            // 
            // Keluhan_dgv
            // 
            this.Keluhan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Keluhan_dgv.DataPropertyName = "keluhan";
            this.Keluhan_dgv.HeaderText = "Keluhan";
            this.Keluhan_dgv.MinimumWidth = 6;
            this.Keluhan_dgv.Name = "Keluhan_dgv";
            this.Keluhan_dgv.ReadOnly = true;
            this.Keluhan_dgv.Width = 84;
            // 
            // Tanggal_masuk_dgv
            // 
            this.Tanggal_masuk_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tanggal_masuk_dgv.DataPropertyName = "tanggal_masuk";
            this.Tanggal_masuk_dgv.HeaderText = "Tanggal_masuk";
            this.Tanggal_masuk_dgv.MinimumWidth = 6;
            this.Tanggal_masuk_dgv.Name = "Tanggal_masuk_dgv";
            this.Tanggal_masuk_dgv.ReadOnly = true;
            this.Tanggal_masuk_dgv.Width = 134;
            // 
            // Tanggal_keluar_dgv
            // 
            this.Tanggal_keluar_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tanggal_keluar_dgv.DataPropertyName = "tanggal_keluar";
            this.Tanggal_keluar_dgv.HeaderText = "Tanggal_keluar";
            this.Tanggal_keluar_dgv.MinimumWidth = 6;
            this.Tanggal_keluar_dgv.Name = "Tanggal_keluar_dgv";
            this.Tanggal_keluar_dgv.ReadOnly = true;
            this.Tanggal_keluar_dgv.Width = 131;
            // 
            // Nama_dokter_dgv
            // 
            this.Nama_dokter_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nama_dokter_dgv.DataPropertyName = "nama_dokter";
            this.Nama_dokter_dgv.HeaderText = "Nama_dokter";
            this.Nama_dokter_dgv.MinimumWidth = 6;
            this.Nama_dokter_dgv.Name = "Nama_dokter_dgv";
            this.Nama_dokter_dgv.ReadOnly = true;
            this.Nama_dokter_dgv.Width = 118;
            // 
            // No_ruangan_dgv
            // 
            this.No_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No_ruangan_dgv.DataPropertyName = "nama_ruangan";
            this.No_ruangan_dgv.HeaderText = "No_ruangan";
            this.No_ruangan_dgv.MinimumWidth = 6;
            this.No_ruangan_dgv.Name = "No_ruangan_dgv";
            this.No_ruangan_dgv.ReadOnly = true;
            this.No_ruangan_dgv.Width = 110;
            // 
            // Nama_ruangan_dgv
            // 
            this.Nama_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nama_ruangan_dgv.DataPropertyName = "nama_ruangan";
            this.Nama_ruangan_dgv.HeaderText = "Nama_ruangan";
            this.Nama_ruangan_dgv.MinimumWidth = 6;
            this.Nama_ruangan_dgv.Name = "Nama_ruangan_dgv";
            this.Nama_ruangan_dgv.ReadOnly = true;
            this.Nama_ruangan_dgv.Width = 129;
            // 
            // Tipe_ruangan_dgv
            // 
            this.Tipe_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tipe_ruangan_dgv.DataPropertyName = "tipe_ruangan";
            this.Tipe_ruangan_dgv.HeaderText = "Tipe_ruangan";
            this.Tipe_ruangan_dgv.MinimumWidth = 6;
            this.Tipe_ruangan_dgv.Name = "Tipe_ruangan_dgv";
            this.Tipe_ruangan_dgv.ReadOnly = true;
            this.Tipe_ruangan_dgv.Width = 120;
            // 
            // Harga_ruangan_dgv
            // 
            this.Harga_ruangan_dgv.DataPropertyName = "harga_ruangan";
            this.Harga_ruangan_dgv.HeaderText = "Harga_ruangan";
            this.Harga_ruangan_dgv.MinimumWidth = 6;
            this.Harga_ruangan_dgv.Name = "Harga_ruangan_dgv";
            this.Harga_ruangan_dgv.ReadOnly = true;
            this.Harga_ruangan_dgv.Width = 125;
            // 
            // Biaya_pengobatan_dgv
            // 
            this.Biaya_pengobatan_dgv.DataPropertyName = "biaya_pengobatan";
            this.Biaya_pengobatan_dgv.HeaderText = "Biaya_pengobatan";
            this.Biaya_pengobatan_dgv.MinimumWidth = 6;
            this.Biaya_pengobatan_dgv.Name = "Biaya_pengobatan_dgv";
            this.Biaya_pengobatan_dgv.ReadOnly = true;
            this.Biaya_pengobatan_dgv.Width = 125;
            // 
            // Total_dgv
            // 
            this.Total_dgv.DataPropertyName = "total";
            this.Total_dgv.HeaderText = "Total";
            this.Total_dgv.MinimumWidth = 6;
            this.Total_dgv.Name = "Total_dgv";
            this.Total_dgv.ReadOnly = true;
            this.Total_dgv.Width = 125;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Red;
            this.hapus_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus_btn.Location = new System.Drawing.Point(426, 184);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(97, 33);
            this.hapus_btn.TabIndex = 174;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // LaporanCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.laporan_dgv);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_checkout_txt);
            this.Controls.Add(this.id_checkout_lbl);
            this.KeyPreview = true;
            this.Name = "LaporanCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanCheckout";
            this.Load += new System.EventHandler(this.LaporanCheckout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaporanCheckout_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LaporanCheckout_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cari_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_checkout_txt;
        private System.Windows.Forms.Label id_checkout_lbl;
        private System.Windows.Forms.DataGridView laporan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_checkout_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pasien_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pasien_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_kelamin_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umur_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_lahir_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontak_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keluhan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_masuk_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_keluar_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_dokter_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya_pengobatan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_dgv;
        private System.Windows.Forms.Button hapus_btn;
    }
}