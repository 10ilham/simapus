namespace SIMAPUS
{
    partial class Ruangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ruangan));
            this.ruangan_gv = new System.Windows.Forms.DataGridView();
            this.No_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipe_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga_ruangan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noruangan_txt = new System.Windows.Forms.TextBox();
            this.noruangan_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inforuangan_lbl = new System.Windows.Forms.Label();
            this.tipe_ruangan_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.harga_ruangan_cb = new System.Windows.Forms.ComboBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.nama_ruangan_cb = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ruangan_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ruangan_gv
            // 
            this.ruangan_gv.AllowUserToAddRows = false;
            this.ruangan_gv.AllowUserToDeleteRows = false;
            this.ruangan_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruangan_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_ruangan_dgv,
            this.Nama_ruangan_dgv,
            this.Tipe_ruangan_dgv,
            this.Harga_ruangan_dgv});
            this.ruangan_gv.Location = new System.Drawing.Point(138, 417);
            this.ruangan_gv.Margin = new System.Windows.Forms.Padding(4);
            this.ruangan_gv.Name = "ruangan_gv";
            this.ruangan_gv.ReadOnly = true;
            this.ruangan_gv.RowHeadersVisible = false;
            this.ruangan_gv.RowHeadersWidth = 51;
            this.ruangan_gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ruangan_gv.Size = new System.Drawing.Size(488, 128);
            this.ruangan_gv.TabIndex = 181;
            this.ruangan_gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ruangan_gv_CellClick);
            // 
            // No_ruangan_dgv
            // 
            this.No_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No_ruangan_dgv.DataPropertyName = "no_ruangan";
            this.No_ruangan_dgv.FillWeight = 100.0194F;
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
            this.Nama_ruangan_dgv.FillWeight = 99.8085F;
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
            this.Tipe_ruangan_dgv.FillWeight = 99.75607F;
            this.Tipe_ruangan_dgv.HeaderText = "Tipe_ruangan";
            this.Tipe_ruangan_dgv.MinimumWidth = 6;
            this.Tipe_ruangan_dgv.Name = "Tipe_ruangan_dgv";
            this.Tipe_ruangan_dgv.ReadOnly = true;
            this.Tipe_ruangan_dgv.Width = 120;
            // 
            // Harga_ruangan_dgv
            // 
            this.Harga_ruangan_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Harga_ruangan_dgv.DataPropertyName = "harga_ruangan";
            this.Harga_ruangan_dgv.FillWeight = 100.4161F;
            this.Harga_ruangan_dgv.HeaderText = "Harga_ruangan";
            this.Harga_ruangan_dgv.MinimumWidth = 6;
            this.Harga_ruangan_dgv.Name = "Harga_ruangan_dgv";
            this.Harga_ruangan_dgv.ReadOnly = true;
            this.Harga_ruangan_dgv.Width = 130;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Yellow;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(562, 356);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(111, 33);
            this.reset_btn.TabIndex = 180;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.tambah_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tambah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah_btn.Location = new System.Drawing.Point(98, 356);
            this.tambah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(97, 33);
            this.tambah_btn.TabIndex = 179;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 172;
            this.label6.Text = "Harga Ruangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 169;
            this.label2.Text = "Tipe Ruangan";
            // 
            // noruangan_txt
            // 
            this.noruangan_txt.Enabled = false;
            this.noruangan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noruangan_txt.Location = new System.Drawing.Point(338, 97);
            this.noruangan_txt.Margin = new System.Windows.Forms.Padding(4);
            this.noruangan_txt.Name = "noruangan_txt";
            this.noruangan_txt.Size = new System.Drawing.Size(184, 26);
            this.noruangan_txt.TabIndex = 168;
            // 
            // noruangan_lbl
            // 
            this.noruangan_lbl.AutoSize = true;
            this.noruangan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noruangan_lbl.Location = new System.Drawing.Point(197, 100);
            this.noruangan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noruangan_lbl.Name = "noruangan_lbl";
            this.noruangan_lbl.Size = new System.Drawing.Size(116, 20);
            this.noruangan_lbl.TabIndex = 167;
            this.noruangan_lbl.Text = "No. Ruangan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // inforuangan_lbl
            // 
            this.inforuangan_lbl.AutoSize = true;
            this.inforuangan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforuangan_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inforuangan_lbl.Location = new System.Drawing.Point(249, 28);
            this.inforuangan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inforuangan_lbl.Name = "inforuangan_lbl";
            this.inforuangan_lbl.Size = new System.Drawing.Size(230, 29);
            this.inforuangan_lbl.TabIndex = 165;
            this.inforuangan_lbl.Text = "Informasi Ruangan";
            // 
            // tipe_ruangan_cb
            // 
            this.tipe_ruangan_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipe_ruangan_cb.FormattingEnabled = true;
            this.tipe_ruangan_cb.Items.AddRange(new object[] {
            "Kelas 1",
            "Kelas 2",
            "Kelas 3",
            "VIP",
            "VVIP"});
            this.tipe_ruangan_cb.Location = new System.Drawing.Point(338, 201);
            this.tipe_ruangan_cb.Name = "tipe_ruangan_cb";
            this.tipe_ruangan_cb.Size = new System.Drawing.Size(184, 24);
            this.tipe_ruangan_cb.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 183;
            this.label1.Text = "Nama Ruangan";
            // 
            // harga_ruangan_cb
            // 
            this.harga_ruangan_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.harga_ruangan_cb.FormattingEnabled = true;
            this.harga_ruangan_cb.Items.AddRange(new object[] {
            "300000",
            "500000",
            "800000",
            "1000000",
            "2000000"});
            this.harga_ruangan_cb.Location = new System.Drawing.Point(338, 253);
            this.harga_ruangan_cb.Name = "harga_ruangan_cb";
            this.harga_ruangan_cb.Size = new System.Drawing.Size(184, 24);
            this.harga_ruangan_cb.TabIndex = 185;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Red;
            this.hapus_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus_btn.Location = new System.Drawing.Point(391, 356);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(111, 33);
            this.hapus_btn.TabIndex = 186;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // nama_ruangan_cb
            // 
            this.nama_ruangan_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_ruangan_cb.Location = new System.Drawing.Point(338, 144);
            this.nama_ruangan_cb.Margin = new System.Windows.Forms.Padding(4);
            this.nama_ruangan_cb.Name = "nama_ruangan_cb";
            this.nama_ruangan_cb.Size = new System.Drawing.Size(184, 26);
            this.nama_ruangan_cb.TabIndex = 187;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.LightCyan;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_btn.Location = new System.Drawing.Point(241, 356);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 33);
            this.update_btn.TabIndex = 216;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Ruangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 585);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.nama_ruangan_cb);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.harga_ruangan_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipe_ruangan_cb);
            this.Controls.Add(this.ruangan_gv);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.tambah_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noruangan_txt);
            this.Controls.Add(this.noruangan_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inforuangan_lbl);
            this.KeyPreview = true;
            this.Name = "Ruangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruangan";
            this.Load += new System.EventHandler(this.Ruangan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ruangan_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ruangan_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ruangan_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ruangan_gv;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noruangan_txt;
        private System.Windows.Forms.Label noruangan_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label inforuangan_lbl;
        private System.Windows.Forms.ComboBox tipe_ruangan_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox harga_ruangan_cb;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.TextBox nama_ruangan_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe_ruangan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga_ruangan_dgv;
        private System.Windows.Forms.Button update_btn;
    }
}