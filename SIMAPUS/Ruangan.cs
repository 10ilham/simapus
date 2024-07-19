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
    public partial class Ruangan : Form
    {
        RuanganCls ruangan = new RuanganCls();
        public Ruangan()
        {
            InitializeComponent();
            noruangan_txt.Text = ruangan.buatid();
        }

        void bersihkan()
        {
            noruangan_txt.Text = ruangan.buatid();
            nama_ruangan_cb.Clear(); 
            tipe_ruangan_cb.SelectedIndex = -1; // Untuk menghapus pilihan yang terpilih combo box
            harga_ruangan_cb.SelectedIndex = -1;
        }

        // Menampilkan data pada grid view
        void tampilGrid()
        {
           ruangan_gv.DataSource = ruangan.tampilRuangan(); //ngambil dari method tampilRuangan di model RuanganCls
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (!ruangan.apakahAda(noruangan_txt.Text))
            {
                ruangan.No_ruangan = noruangan_txt.Text;
                ruangan.Nama_ruangan = nama_ruangan_cb.Text;
                ruangan.Tipe_ruangan = tipe_ruangan_cb.Text;
                ruangan.Harga_ruangan = harga_ruangan_cb.Text;
                if (ruangan.tambahRuangan() >= 0)
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
            if (ruangan.apakahAda(noruangan_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin ingin mengubah data ini?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ruangan.No_ruangan = noruangan_txt.Text;
                    ruangan.Nama_ruangan = nama_ruangan_cb.Text;
                    ruangan.Tipe_ruangan = tipe_ruangan_cb.Text;
                    ruangan.Harga_ruangan = harga_ruangan_cb.Text;
                    if (ruangan.ubahData(noruangan_txt.Text) >= 0)
                    {
                        MessageBox.Show("Data berhasil diubah",
                         "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid(); //update data pada grid view
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah",
                        "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (ruangan.apakahAda(noruangan_txt.Text))
            {
                if (MessageBox.Show("Data sudah ada, apakah yakin akan dihapus?",
                    "KOMFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ruangan.hapusRuangan(noruangan_txt.Text) >= 0)
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

        private void Ruangan_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        private void ruangan_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.ruangan_gv.Rows[e.RowIndex];
                noruangan_txt.Text = baris.Cells[0].Value.ToString();
                nama_ruangan_cb.Text = baris.Cells[1].Value.ToString();
                tipe_ruangan_cb.Text = baris.Cells[2].Value.ToString();
                harga_ruangan_cb.Text = baris.Cells[3].Value.ToString();
            }
        }

        private void Ruangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Jika kita menekan tombol enter maka akan memanggil method cari_btn_Click
            if (e.KeyChar == (char)13)
            {
                tambah_btn_Click(sender, e);
            }

        }

        private void Ruangan_KeyDown(object sender, KeyEventArgs e)
        {
            //Jika kita menekan tombol delete maka akan memanggil method hapus_btn_Click
            if (e.KeyCode == Keys.Delete)
            {
                hapus_btn_Click(sender, e);
            }
            //Jika kita menekan tombol escape maka akan memanggil method reset_btn_Click
            if (e.KeyCode == Keys.Escape)
            {
                reset_btn_Click(sender, e);
            }

        }
    }
}
