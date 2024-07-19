using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMAPUS
{
    using model;
    public partial class Dokter : Form
    {
        DokterCls dokter = new DokterCls();
        public Dokter()
        {
            InitializeComponent();
            id_dokter_txt.Text = dokter.buatid();
        }

        void bersihkan()
        {
            id_dokter_txt.Text = dokter.buatid();
            nama_txt.Clear();
            lk_radio.Checked = false;
            pr_radio.Checked = false;
            spesialis_cb.SelectedIndex = -1;
            gaji_txt.Clear();
            kontak_txt.Clear();
            alamat_txt.Clear();
            nama_txt.Focus();
        }

        // Menampilkan data pada grid view
        void tampilGrid()
        {
            dokter_dgv.DataSource = dokter.tampilDokter(); //ngambil dari method tampilDokter di model DokterCls
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (!dokter.apakahAda(id_dokter_txt.Text))
            {
                dokter.Id_dokter = id_dokter_txt.Text;
                dokter.Nama_dokter = nama_txt.Text;
                dokter.Jenis_kelamin = lk_radio.Checked ? "Laki-laki" : "Perempuan";
                dokter.Spesialis = spesialis_cb.Text;
                dokter.Gaji = gaji_txt.Text;
                dokter.Kontak = kontak_txt.Text;
                dokter.Alamat = alamat_txt.Text;

                if (dokter.tambahDokter() >= 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan",
                     "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid(); //update data pada grid view
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan",
                     "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data sudah ada",
                 "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dokter.apakahAda(id_dokter_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin ingin mengubah data ini?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)

                    dokter.Nama_dokter = nama_txt.Text;
                    dokter.Jenis_kelamin = lk_radio.Checked ? "Laki-laki" : "Perempuan";
                    dokter.Spesialis = spesialis_cb.Text;
                    dokter.Gaji = gaji_txt.Text;
                    dokter.Kontak = kontak_txt.Text;
                    dokter.Alamat = alamat_txt.Text;

                    if (dokter.ubahDokter(id_dokter_txt.Text) >= 0)
                    {
                        MessageBox.Show("Data berhasil diubah",
                         "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah",
                         "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (dokter.apakahAda(id_dokter_txt.Text))
            {
                if (MessageBox.Show("Data sudah ada, apakah yakin akan dihapus?",
                   "KOMFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dokter.hapusDokter(id_dokter_txt.Text) >= 0)
                    {
                        //sebagai pesan jika data berhasil dihapus
                        MessageBox.Show("Data berhasil dihapus",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid(); //update data pada grid view
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus",
                        "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void Dokter_Load(object sender, EventArgs e)
        {
            tampilGrid(); // Menampilkan data pada grid view
            bersihkan();
        }

        //Method untuk menampilkan data dokter yang di click pada grid view
        private void dokter_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.dokter_dgv.Rows[e.RowIndex];
                id_dokter_txt.Text = baris.Cells[0].Value.ToString();
                nama_txt.Text = baris.Cells[1].Value.ToString();
                lk_radio.Checked = baris.Cells[2].Value.ToString() == "Laki-laki" ? true : false;
                pr_radio.Checked = baris.Cells[2].Value.ToString() == "Perempuan" ? true : false;
                spesialis_cb.Text = baris.Cells[3].Value.ToString();
                gaji_txt.Text = baris.Cells[4].Value.ToString();
                kontak_txt.Text = baris.Cells[5].Value.ToString();
                alamat_txt.Text = baris.Cells[6].Value.ToString();
            }
        }

        private void Dokter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Jika kita menekan enter maka akan memanggil method tambah_btn_Click
            if (e.KeyChar == (char)13)
            {
                tambah_btn_Click(sender, e);
            }
        }

        private void Dokter_KeyDown(object sender, KeyEventArgs e)
        {
            //Jika menekan tombol insert maka akan memanggil method update_btn_Click
            if (e.KeyCode == Keys.Insert)
            {
                update_btn_Click(sender, e);
            }

            //Jika menekan tombol delete maka akan memanggil method hapus_btn_Click
            if (e.KeyCode == Keys.Delete)
            {
                hapus_btn_Click(sender, e);
            }

            //Jika menekan tombol escape maka akan memanggil method reset_btn_Click
            if (e.KeyCode == Keys.Escape)
            {
                reset_btn_Click(sender, e);
            }
        }
    }
}
