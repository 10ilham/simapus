namespace SIMAPUS
{
    partial class InformasiPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformasiPasien));
            this.informasi_dgv = new System.Windows.Forms.DataGridView();
            this.Id_pasien_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_pasien_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_kelamin_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umur_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_lahir_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontak_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keluhan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipe_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama_ruangan_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tipe_ruangan_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.noruangan_lbl = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.tanggal_dt = new System.Windows.Forms.DateTimePicker();
            this.almt_txt = new System.Windows.Forms.TextBox();
            this.kontak_txt = new System.Windows.Forms.TextBox();
            this.usia_txt = new System.Windows.Forms.TextBox();
            this.pr_radio = new System.Windows.Forms.RadioButton();
            this.lk_radio = new System.Windows.Forms.RadioButton();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usia_lbl = new System.Windows.Forms.Label();
            this.jk_lbl = new System.Windows.Forms.Label();
            this.nama_lbl = new System.Windows.Forms.Label();
            this.idpasien_txt = new System.Windows.Forms.TextBox();
            this.idpasien_lbl = new System.Windows.Forms.Label();
            this.noruangan_cb = new System.Windows.Forms.ComboBox();
            this.keluhan_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.informasi_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // informasi_dgv
            // 
            this.informasi_dgv.AllowUserToAddRows = false;
            this.informasi_dgv.AllowUserToDeleteRows = false;
            this.informasi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informasi_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_pasien_dgv,
            this.Nama_pasien_dgv,
            this.Jenis_kelamin_dgv,
            this.Umur_dgv,
            this.Tanggal_lahir_dgv,
            this.Kontak_dgv,
            this.Alamat_dgv,
            this.Keluhan_dgv,
            this.No_ruangan_dgv,
            this.Nama_ruangan_dgv,
            this.Tipe_ruangan_dgv});
            this.informasi_dgv.Location = new System.Drawing.Point(71, 711);
            this.informasi_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.informasi_dgv.Name = "informasi_dgv";
            this.informasi_dgv.ReadOnly = true;
            this.informasi_dgv.RowHeadersVisible = false;
            this.informasi_dgv.RowHeadersWidth = 51;
            this.informasi_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informasi_dgv.Size = new System.Drawing.Size(791, 107);
            this.informasi_dgv.TabIndex = 172;
            this.informasi_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.informasi_dgv_CellClick);
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
            // No_ruangan_dgv
            // 
            this.No_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No_ruangan_dgv.DataPropertyName = "no_ruangan";
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
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_btn.Location = new System.Drawing.Point(436, 645);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(111, 33);
            this.delete_btn.TabIndex = 171;
            this.delete_btn.Text = "Hapus";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_btn.Location = new System.Drawing.Point(286, 645);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(111, 33);
            this.update_btn.TabIndex = 170;
            this.update_btn.Text = "Perbarui";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(289, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 142;
            this.label3.Text = "Informasi Pasien";
            // 
            // nama_ruangan_cb
            // 
            this.nama_ruangan_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nama_ruangan_cb.Enabled = false;
            this.nama_ruangan_cb.FormattingEnabled = true;
            this.nama_ruangan_cb.Location = new System.Drawing.Point(647, 278);
            this.nama_ruangan_cb.Name = "nama_ruangan_cb";
            this.nama_ruangan_cb.Size = new System.Drawing.Size(184, 24);
            this.nama_ruangan_cb.TabIndex = 192;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 191;
            this.label9.Text = "Nama Ruangan";
            // 
            // tipe_ruangan_cb
            // 
            this.tipe_ruangan_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipe_ruangan_cb.Enabled = false;
            this.tipe_ruangan_cb.FormattingEnabled = true;
            this.tipe_ruangan_cb.Items.AddRange(new object[] {
            "Kelas 1",
            "Kelas 2",
            "Kelas 3",
            "VIP",
            "VVIP"});
            this.tipe_ruangan_cb.Location = new System.Drawing.Point(647, 344);
            this.tipe_ruangan_cb.Name = "tipe_ruangan_cb";
            this.tipe_ruangan_cb.Size = new System.Drawing.Size(184, 24);
            this.tipe_ruangan_cb.TabIndex = 190;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(498, 344);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 188;
            this.label11.Text = "Tipe Ruangan";
            // 
            // noruangan_lbl
            // 
            this.noruangan_lbl.AutoSize = true;
            this.noruangan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noruangan_lbl.Location = new System.Drawing.Point(506, 205);
            this.noruangan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noruangan_lbl.Name = "noruangan_lbl";
            this.noruangan_lbl.Size = new System.Drawing.Size(116, 20);
            this.noruangan_lbl.TabIndex = 186;
            this.noruangan_lbl.Text = "No. Ruangan";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Yellow;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reset_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(577, 645);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(111, 33);
            this.reset_btn.TabIndex = 193;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // tanggal_dt
            // 
            this.tanggal_dt.CustomFormat = "dd-MM-yyyy";
            this.tanggal_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggal_dt.Location = new System.Drawing.Point(181, 399);
            this.tanggal_dt.Name = "tanggal_dt";
            this.tanggal_dt.Size = new System.Drawing.Size(186, 22);
            this.tanggal_dt.TabIndex = 210;
            this.tanggal_dt.Value = new System.DateTime(2024, 5, 11, 0, 0, 0, 0);
            // 
            // almt_txt
            // 
            this.almt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almt_txt.Location = new System.Drawing.Point(183, 528);
            this.almt_txt.Margin = new System.Windows.Forms.Padding(4);
            this.almt_txt.Multiline = true;
            this.almt_txt.Name = "almt_txt";
            this.almt_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.almt_txt.Size = new System.Drawing.Size(184, 77);
            this.almt_txt.TabIndex = 208;
            // 
            // kontak_txt
            // 
            this.kontak_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontak_txt.Location = new System.Drawing.Point(183, 457);
            this.kontak_txt.Margin = new System.Windows.Forms.Padding(4);
            this.kontak_txt.Name = "kontak_txt";
            this.kontak_txt.Size = new System.Drawing.Size(184, 26);
            this.kontak_txt.TabIndex = 207;
            // 
            // usia_txt
            // 
            this.usia_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usia_txt.Location = new System.Drawing.Point(183, 329);
            this.usia_txt.Margin = new System.Windows.Forms.Padding(4);
            this.usia_txt.Name = "usia_txt";
            this.usia_txt.Size = new System.Drawing.Size(184, 26);
            this.usia_txt.TabIndex = 206;
            // 
            // pr_radio
            // 
            this.pr_radio.AutoSize = true;
            this.pr_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_radio.Location = new System.Drawing.Point(291, 267);
            this.pr_radio.Margin = new System.Windows.Forms.Padding(4);
            this.pr_radio.Name = "pr_radio";
            this.pr_radio.Size = new System.Drawing.Size(124, 24);
            this.pr_radio.TabIndex = 205;
            this.pr_radio.Text = "Perempuan";
            this.pr_radio.UseVisualStyleBackColor = true;
            // 
            // lk_radio
            // 
            this.lk_radio.AutoSize = true;
            this.lk_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk_radio.Location = new System.Drawing.Point(183, 267);
            this.lk_radio.Margin = new System.Windows.Forms.Padding(4);
            this.lk_radio.Name = "lk_radio";
            this.lk_radio.Size = new System.Drawing.Size(101, 24);
            this.lk_radio.TabIndex = 204;
            this.lk_radio.Text = "Laki-laki";
            this.lk_radio.UseVisualStyleBackColor = true;
            // 
            // nama_txt
            // 
            this.nama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(183, 200);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(184, 26);
            this.nama_txt.TabIndex = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 202;
            this.label1.Text = "Keluhan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 531);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 201;
            this.label8.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 200;
            this.label7.Text = "Kontak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 199;
            this.label6.Text = "Tanggal Lahir";
            // 
            // usia_lbl
            // 
            this.usia_lbl.AutoSize = true;
            this.usia_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usia_lbl.Location = new System.Drawing.Point(79, 335);
            this.usia_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usia_lbl.Name = "usia_lbl";
            this.usia_lbl.Size = new System.Drawing.Size(47, 20);
            this.usia_lbl.TabIndex = 198;
            this.usia_lbl.Text = "Usia";
            // 
            // jk_lbl
            // 
            this.jk_lbl.AutoSize = true;
            this.jk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk_lbl.Location = new System.Drawing.Point(36, 269);
            this.jk_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jk_lbl.Name = "jk_lbl";
            this.jk_lbl.Size = new System.Drawing.Size(127, 20);
            this.jk_lbl.TabIndex = 197;
            this.jk_lbl.Text = "Jenis Kelamin";
            // 
            // nama_lbl
            // 
            this.nama_lbl.AutoSize = true;
            this.nama_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_lbl.Location = new System.Drawing.Point(43, 203);
            this.nama_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nama_lbl.Name = "nama_lbl";
            this.nama_lbl.Size = new System.Drawing.Size(120, 20);
            this.nama_lbl.TabIndex = 196;
            this.nama_lbl.Text = "Nama Pasien";
            // 
            // idpasien_txt
            // 
            this.idpasien_txt.Enabled = false;
            this.idpasien_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpasien_txt.Location = new System.Drawing.Point(183, 127);
            this.idpasien_txt.Margin = new System.Windows.Forms.Padding(4);
            this.idpasien_txt.Name = "idpasien_txt";
            this.idpasien_txt.Size = new System.Drawing.Size(184, 26);
            this.idpasien_txt.TabIndex = 195;
            // 
            // idpasien_lbl
            // 
            this.idpasien_lbl.AutoSize = true;
            this.idpasien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpasien_lbl.Location = new System.Drawing.Point(57, 130);
            this.idpasien_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idpasien_lbl.Name = "idpasien_lbl";
            this.idpasien_lbl.Size = new System.Drawing.Size(91, 20);
            this.idpasien_lbl.TabIndex = 194;
            this.idpasien_lbl.Text = "ID Pasien";
            // 
            // noruangan_cb
            // 
            this.noruangan_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noruangan_cb.FormattingEnabled = true;
            this.noruangan_cb.Items.AddRange(new object[] {
            "Cempaka",
            "Flamboyan",
            "Rajawali",
            "Mawar",
            "Anggrek"});
            this.noruangan_cb.Location = new System.Drawing.Point(649, 205);
            this.noruangan_cb.Name = "noruangan_cb";
            this.noruangan_cb.Size = new System.Drawing.Size(184, 24);
            this.noruangan_cb.TabIndex = 212;
            this.noruangan_cb.SelectedIndexChanged += new System.EventHandler(this.noruangan_cb_SelectedIndexChanged);
            // 
            // keluhan_txt
            // 
            this.keluhan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluhan_txt.Location = new System.Drawing.Point(647, 130);
            this.keluhan_txt.Margin = new System.Windows.Forms.Padding(4);
            this.keluhan_txt.Name = "keluhan_txt";
            this.keluhan_txt.Size = new System.Drawing.Size(184, 26);
            this.keluhan_txt.TabIndex = 213;
            // 
            // InformasiPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 852);
            this.Controls.Add(this.keluhan_txt);
            this.Controls.Add(this.noruangan_cb);
            this.Controls.Add(this.tanggal_dt);
            this.Controls.Add(this.almt_txt);
            this.Controls.Add(this.kontak_txt);
            this.Controls.Add(this.usia_txt);
            this.Controls.Add(this.pr_radio);
            this.Controls.Add(this.lk_radio);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usia_lbl);
            this.Controls.Add(this.jk_lbl);
            this.Controls.Add(this.nama_lbl);
            this.Controls.Add(this.idpasien_txt);
            this.Controls.Add(this.idpasien_lbl);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.nama_ruangan_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tipe_ruangan_cb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.noruangan_lbl);
            this.Controls.Add(this.informasi_dgv);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.Name = "InformasiPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformasiPasien";
            this.Load += new System.EventHandler(this.InformasiPasien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InformasiPasien_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InformasiPasien_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.informasi_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nama_ruangan_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tipe_ruangan_cb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label noruangan_lbl;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.DateTimePicker tanggal_dt;
        private System.Windows.Forms.TextBox almt_txt;
        private System.Windows.Forms.TextBox kontak_txt;
        private System.Windows.Forms.TextBox usia_txt;
        private System.Windows.Forms.RadioButton pr_radio;
        private System.Windows.Forms.RadioButton lk_radio;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label usia_lbl;
        private System.Windows.Forms.Label jk_lbl;
        private System.Windows.Forms.Label nama_lbl;
        private System.Windows.Forms.TextBox idpasien_txt;
        private System.Windows.Forms.Label idpasien_lbl;
        private System.Windows.Forms.ComboBox noruangan_cb;
        private System.Windows.Forms.DataGridView informasi_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pasien_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_pasien_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_kelamin_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umur_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_lahir_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontak_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keluhan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe_ruangan_dgv;
        private System.Windows.Forms.TextBox keluhan_txt;
    }
}