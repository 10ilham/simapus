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
    public partial class InformasiPasien : Form
    {
        PasienCls pasien = new PasienCls(); //inisisalisasi objek pasien dari kelas PasienCls
        public InformasiPasien() //konstruktor informasi pasien
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            informasi_dgv.DataSource = pasien.tampilPasien();
        }

        //Menghubungkan dari no_ruangan di tabel ruangan ke combo box no_ruangan di tabel pasien
        void combo()
        {
            //memanggil data dari tabel ruangan di isicombo2 pada PasienCls
            DataTable ruangandata = pasien.isicombo();

            //untuk mengisi/menampilkan otomatis no_ruangan sinkron dengan database
            noruangan_cb.DataSource = ruangandata;
            noruangan_cb.DisplayMember = "no_ruangan";
            noruangan_cb.ValueMember = "no_ruangan";

            //untuk mengisi/menampilkan otomatis nama_ruangan sinkron dengan database
            nama_ruangan_cb.DataSource = ruangandata;
            nama_ruangan_cb.DisplayMember = "nama_ruangan";
            nama_ruangan_cb.ValueMember = "nama_ruangan";

            //untuk mengisi/menampilkan otomatis tipe_ruangan sinkron dengan database
            tipe_ruangan_cb.DataSource = ruangandata;
            tipe_ruangan_cb.DisplayMember = "tipe_ruangan";
            tipe_ruangan_cb.ValueMember = "tipe_ruangan";
        }

        void bersihkan()
        {
            idpasien_txt.Clear();
            nama_txt.Clear();
            lk_radio.Checked = false;
            pr_radio.Checked = false;
            usia_txt.Clear();
            tanggal_dt.Value = DateTime.Now;
            kontak_txt.Clear();
            almt_txt.Clear();
            keluhan_txt.Clear();
            noruangan_cb.SelectedIndex = -1;
            nama_ruangan_cb.SelectedIndex = -1;
            tipe_ruangan_cb.SelectedIndex = -1;
            nama_txt.Focus();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(idpasien_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin ingin mengubah data ini?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)

                pasien.Nama_pasien = nama_txt.Text;
                pasien.Jenis_kelamin = lk_radio.Checked ? "Laki-laki" : "Perempuan";
                pasien.Umur = usia_txt.Text;
                pasien.Tanggal_lahir = tanggal_dt.Value.ToString("yyyy-MM-dd");
                pasien.Kontak = kontak_txt.Text;
                pasien.Alamat = almt_txt.Text;
                pasien.Keluhan = keluhan_txt.Text;
                pasien.No_ruangan = noruangan_cb.Text;

                if (pasien.ubahData(idpasien_txt.Text) >= 0)
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
                    bersihkan();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(idpasien_txt.Text))
            {
                if (MessageBox.Show("Data sudah ada, apakah yakin akan dihapus?",
                    "KOMFIRMASI", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pasien.hapusData(idpasien_txt.Text) >= 0)
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

        private void InformasiPasien_Load(object sender, EventArgs e)
        {
            tampilGrid(); //menampilkan data pada grid view
            combo(); //menampilkan data pada combo
            bersihkan();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        //Method untuk menampilkan data pasien yang dipilih pada datagridview ke textbox dan lainnya
        private void informasi_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.informasi_dgv.Rows[e.RowIndex];
                idpasien_txt.Text = baris.Cells[0].Value.ToString();
                nama_txt.Text = baris.Cells[1].Value.ToString();
                lk_radio.Checked = baris.Cells[2].Value.ToString() == "Laki-laki" ? true : false;
                pr_radio.Checked = baris.Cells[2].Value.ToString() == "Perempuan" ? true : false;
                usia_txt.Text = baris.Cells[3].Value.ToString();
                tanggal_dt.Value = Convert.ToDateTime(baris.Cells[4].Value.ToString());
                kontak_txt.Text = baris.Cells[5].Value.ToString();
                almt_txt.Text = baris.Cells[6].Value.ToString();
                keluhan_txt.Text = baris.Cells[7].Value.ToString();
                noruangan_cb.Text = baris.Cells[8].Value.ToString();
                nama_ruangan_cb.Text = baris.Cells[9].Value.ToString();
                tipe_ruangan_cb.Text = baris.Cells[10].Value.ToString();
            }
        }

        //Method untuk mengisi/menampilkan otomatis nama ruangan dan tipe ruangan berdasarkan no ruangan yang dipilih
        private void noruangan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noruangan_cb.SelectedIndex != -1)
            {
                string no_ruangan = noruangan_cb.SelectedValue.ToString(); //mengambil data dari combobox no ruangan
                DataTable ruangandata = pasien.isiDataRuangan(no_ruangan);

                if (ruangandata.Rows.Count > 0)
                {
                    nama_ruangan_cb.Text = ruangandata.Rows[0]["nama_ruangan"].ToString();
                    tipe_ruangan_cb.Text = ruangandata.Rows[0]["tipe_ruangan"].ToString();
                }
                else
                {
                    nama_ruangan_cb.Text = "";
                    tipe_ruangan_cb.Text = "";
                }
            }
        }

        //Method untuk mencari data berdasarkan id_pasien saat tombol enter ditekan
        private void InformasiPasien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                update_btn_Click(sender, e);
            }
        }

        private void InformasiPasien_KeyDown(object sender, KeyEventArgs e)
        {
            //Untuk menghapus data pada saat tombol delete ditekan
            if (e.KeyCode == Keys.Delete)
            {
                delete_btn_Click(sender, e);
            }
            //Untuk mereset data pada saat tombol escape ditekan
            if (e.KeyCode == Keys.Escape)
            {
                reset_btn_Click(sender, e);
            }
        }

    }
}
