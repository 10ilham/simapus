namespace SIMAPUS
{
    partial class Dokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dokter));
            this.hapus_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spesialis_cb = new System.Windows.Forms.ComboBox();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.iddokter_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infodokter_lbl = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pr_radio = new System.Windows.Forms.RadioButton();
            this.lk_radio = new System.Windows.Forms.RadioButton();
            this.jk_lbl = new System.Windows.Forms.Label();
            this.gaji_txt = new System.Windows.Forms.TextBox();
            this.alamat_txt = new System.Windows.Forms.TextBox();
            this.kontak_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.dokter_dgv = new System.Windows.Forms.DataGridView();
            this.Id_dokter_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_dokter_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_kelamin_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spesialis_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaji_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontak_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dokter_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Red;
            this.hapus_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus_btn.Location = new System.Drawing.Point(439, 529);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(111, 33);
            this.hapus_btn.TabIndex = 200;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 197;
            this.label1.Text = "Nama Dokter";
            // 
            // spesialis_cb
            // 
            this.spesialis_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spesialis_cb.FormattingEnabled = true;
            this.spesialis_cb.Items.AddRange(new object[] {
            "Umum",
            "Bedah/Kulit",
            "Penyakit Dalam",
            "Ilmu Penyakit Tropis",
            "Dokter Gigi",
            "Kandungan & Kebidanan",
            "Mata",
            "Psikolog Klinis"});
            this.spesialis_cb.Location = new System.Drawing.Point(340, 243);
            this.spesialis_cb.Name = "spesialis_cb";
            this.spesialis_cb.Size = new System.Drawing.Size(184, 24);
            this.spesialis_cb.TabIndex = 196;
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.tambah_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tambah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah_btn.Location = new System.Drawing.Point(132, 529);
            this.tambah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(97, 33);
            this.tambah_btn.TabIndex = 193;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 192;
            this.label6.Text = "Gaji";
            // 
            // iddokter_lbl
            // 
            this.iddokter_lbl.AutoSize = true;
            this.iddokter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddokter_lbl.Location = new System.Drawing.Point(199, 109);
            this.iddokter_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iddokter_lbl.Name = "iddokter_lbl";
            this.iddokter_lbl.Size = new System.Drawing.Size(90, 20);
            this.iddokter_lbl.TabIndex = 189;
            this.iddokter_lbl.Tag = "";
            this.iddokter_lbl.Text = "ID Dokter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 188;
            this.pictureBox1.TabStop = false;
            // 
            // infodokter_lbl
            // 
            this.infodokter_lbl.AutoSize = true;
            this.infodokter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infodokter_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infodokter_lbl.Location = new System.Drawing.Point(335, 32);
            this.infodokter_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infodokter_lbl.Name = "infodokter_lbl";
            this.infodokter_lbl.Size = new System.Drawing.Size(150, 29);
            this.infodokter_lbl.TabIndex = 187;
            this.infodokter_lbl.Text = "Data Dokter";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Yellow;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(611, 529);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(111, 33);
            this.reset_btn.TabIndex = 194;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 191;
            this.label2.Text = "Spesialis";
            // 
            // pr_radio
            // 
            this.pr_radio.AutoSize = true;
            this.pr_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_radio.Location = new System.Drawing.Point(441, 199);
            this.pr_radio.Margin = new System.Windows.Forms.Padding(4);
            this.pr_radio.Name = "pr_radio";
            this.pr_radio.Size = new System.Drawing.Size(124, 24);
            this.pr_radio.TabIndex = 208;
            this.pr_radio.Text = "Perempuan";
            this.pr_radio.UseVisualStyleBackColor = true;
            // 
            // lk_radio
            // 
            this.lk_radio.AutoSize = true;
            this.lk_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk_radio.Location = new System.Drawing.Point(333, 199);
            this.lk_radio.Margin = new System.Windows.Forms.Padding(4);
            this.lk_radio.Name = "lk_radio";
            this.lk_radio.Size = new System.Drawing.Size(101, 24);
            this.lk_radio.TabIndex = 207;
            this.lk_radio.Text = "Laki-laki";
            this.lk_radio.UseVisualStyleBackColor = true;
            // 
            // jk_lbl
            // 
            this.jk_lbl.AutoSize = true;
            this.jk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk_lbl.Location = new System.Drawing.Point(179, 201);
            this.jk_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jk_lbl.Name = "jk_lbl";
            this.jk_lbl.Size = new System.Drawing.Size(127, 20);
            this.jk_lbl.TabIndex = 206;
            this.jk_lbl.Text = "Jenis Kelamin";
            // 
            // gaji_txt
            // 
            this.gaji_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaji_txt.Location = new System.Drawing.Point(340, 289);
            this.gaji_txt.Margin = new System.Windows.Forms.Padding(4);
            this.gaji_txt.Name = "gaji_txt";
            this.gaji_txt.Size = new System.Drawing.Size(184, 26);
            this.gaji_txt.TabIndex = 209;
            // 
            // alamat_txt
            // 
            this.alamat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_txt.Location = new System.Drawing.Point(340, 404);
            this.alamat_txt.Margin = new System.Windows.Forms.Padding(4);
            this.alamat_txt.Multiline = true;
            this.alamat_txt.Name = "alamat_txt";
            this.alamat_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamat_txt.Size = new System.Drawing.Size(184, 77);
            this.alamat_txt.TabIndex = 213;
            // 
            // kontak_txt
            // 
            this.kontak_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontak_txt.Location = new System.Drawing.Point(340, 347);
            this.kontak_txt.Margin = new System.Windows.Forms.Padding(4);
            this.kontak_txt.Name = "kontak_txt";
            this.kontak_txt.Size = new System.Drawing.Size(184, 26);
            this.kontak_txt.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 211;
            this.label8.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 210;
            this.label7.Text = "Kontak";
            // 
            // nama_txt
            // 
            this.nama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(340, 156);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(184, 26);
            this.nama_txt.TabIndex = 214;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.LightCyan;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_btn.Location = new System.Drawing.Point(287, 529);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 33);
            this.update_btn.TabIndex = 215;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // dokter_dgv
            // 
            this.dokter_dgv.AllowUserToAddRows = false;
            this.dokter_dgv.AllowUserToDeleteRows = false;
            this.dokter_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokter_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_dokter_dgv,
            this.Nama_dokter_dgv,
            this.Jenis_kelamin_dgv,
            this.Spesialis_dgv,
            this.Gaji_dgv,
            this.Kontak_dgv,
            this.Alamat_dgv});
            this.dokter_dgv.Location = new System.Drawing.Point(104, 603);
            this.dokter_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dokter_dgv.Name = "dokter_dgv";
            this.dokter_dgv.ReadOnly = true;
            this.dokter_dgv.RowHeadersVisible = false;
            this.dokter_dgv.RowHeadersWidth = 51;
            this.dokter_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dokter_dgv.Size = new System.Drawing.Size(636, 107);
            this.dokter_dgv.TabIndex = 216;
            this.dokter_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dokter_dgv_CellClick);
            // 
            // Id_dokter_dgv
            // 
            this.Id_dokter_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_dokter_dgv.DataPropertyName = "id_dokter";
            this.Id_dokter_dgv.HeaderText = "Id_dokter";
            this.Id_dokter_dgv.MinimumWidth = 6;
            this.Id_dokter_dgv.Name = "Id_dokter_dgv";
            this.Id_dokter_dgv.ReadOnly = true;
            this.Id_dokter_dgv.Width = 92;
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
            // Spesialis_dgv
            // 
            this.Spesialis_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Spesialis_dgv.DataPropertyName = "spesialis";
            this.Spesialis_dgv.HeaderText = "Spesialis";
            this.Spesialis_dgv.MinimumWidth = 6;
            this.Spesialis_dgv.Name = "Spesialis_dgv";
            this.Spesialis_dgv.ReadOnly = true;
            this.Spesialis_dgv.Width = 92;
            // 
            // Gaji_dgv
            // 
            this.Gaji_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gaji_dgv.DataPropertyName = "gaji";
            this.Gaji_dgv.HeaderText = "Gaji";
            this.Gaji_dgv.MinimumWidth = 6;
            this.Gaji_dgv.Name = "Gaji_dgv";
            this.Gaji_dgv.ReadOnly = true;
            this.Gaji_dgv.Width = 60;
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
            // id_dokter_txt
            // 
            this.id_dokter_txt.Enabled = false;
            this.id_dokter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_dokter_txt.Location = new System.Drawing.Point(340, 103);
            this.id_dokter_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_dokter_txt.Name = "id_dokter_txt";
            this.id_dokter_txt.Size = new System.Drawing.Size(184, 26);
            this.id_dokter_txt.TabIndex = 231;
            // 
            // Dokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 760);
            this.Controls.Add(this.id_dokter_txt);
            this.Controls.Add(this.dokter_dgv);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.alamat_txt);
            this.Controls.Add(this.kontak_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gaji_txt);
            this.Controls.Add(this.pr_radio);
            this.Controls.Add(this.lk_radio);
            this.Controls.Add(this.jk_lbl);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spesialis_cb);
            this.Controls.Add(this.tambah_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iddokter_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infodokter_lbl);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "Dokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokter";
            this.Load += new System.EventHandler(this.Dokter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dokter_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dokter_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox spesialis_cb;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label iddokter_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infodokter_lbl;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton pr_radio;
        private System.Windows.Forms.RadioButton lk_radio;
        private System.Windows.Forms.Label jk_lbl;
        private System.Windows.Forms.TextBox gaji_txt;
        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.TextBox kontak_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView dokter_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_dokter_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_dokter_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_kelamin_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spesialis_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaji_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontak_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat_dgv;
        private System.Windows.Forms.TextBox id_dokter_txt;
    }
}