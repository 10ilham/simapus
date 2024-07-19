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
    public partial class Pendaftaran : Form
    {
        PasienCls pasien = new PasienCls(); //inisialiasi objek pasien dari kelas PasienCls
        public Pendaftaran() //konstruktor
        {
            InitializeComponent();
            idpasien_txt.Text = pasien.buatid();
        }

        void combo()
        {
            DataTable ruangandata = pasien.isicombo();
            nama_ruangan_cb.DataSource = ruangandata;
            nama_ruangan_cb.DisplayMember = "nama_ruangan";
            nama_ruangan_cb.ValueMember = "nama_ruangan";
        }

        void bersihkan()
        {
            idpasien_txt.Text = pasien.buatid();
            nama_txt.Clear();
            lk_radio.Checked = false;
            pr_radio.Checked = false;
            usia_txt.Clear();
            tanggal_dt.Value = DateTime.Now;
            kontak_txt.Clear();
            almt_txt.Clear();
            keluhan_txt.Clear();
            nama_ruangan_cb.SelectedIndex = -1;
            nama_txt.Focus();
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (!pasien.apakahAda(idpasien_txt.Text))
            {
                pasien.Id_pasien = idpasien_txt.Text;
                pasien.Nama_pasien = nama_txt.Text;
                pasien.Jenis_kelamin = lk_radio.Checked ? "Laki-laki" : "Perempuan";
                pasien.Umur = usia_txt.Text;
                pasien.Tanggal_lahir = tanggal_dt.Value.ToString("yyyy-MM-dd");
                pasien.Kontak = kontak_txt.Text;
                pasien.Alamat = almt_txt.Text;
                pasien.Keluhan = keluhan_txt.Text;
                pasien.Nama_ruangan = nama_ruangan_cb.Text;

                if (pasien.tambahPasien() >= 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan", 
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan", 
                           "KESALAHAN", MessageBoxButtons.OK, 
                           MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Data sudah ada", 
                 "PERINGATAN", MessageBoxButtons.OK, 
                  MessageBoxIcon.Error);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void Pendaftaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            //jika tombol enter ditekan
            if (e.KeyChar == (char)13)
            {
                tambah_btn_Click(sender, e);
            }
        }

        private void Pendaftaran_KeyDown(object sender, KeyEventArgs e)
        {
            //jika tombiol delete ditekan maka akan memanggil metode reset_btn_Click
            if (e.KeyCode == Keys.Delete)
            {
                // Panggil metode reset_btn_Click di sini
                reset_btn_Click(sender, e);
            }
        }

        private void Pendaftaran_Load(object sender, EventArgs e)
        {
            combo(); //memanggil metode combo untuk ditampilkan nama_ruangan
            bersihkan();
        }

    }
}
