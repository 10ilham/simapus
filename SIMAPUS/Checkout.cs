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
    public partial class Checkout : Form
    {
        CheckoutCls checkout = new CheckoutCls();
        public Checkout()
        {
            InitializeComponent();
            id_checkout_txt.Text = checkout.buatid();
        }

        //Menghubungkan dari no_ruangan, id_pasien di tabel ruangan ke combo box di tabel pasien, ruangan
        void combo()
        {
            //memanggil data dari tabel pasien di isiCombo pada CheckoutCls
            DataTable pasiendata = checkout.isiCombo();

            //untuk mengisi otomatis id_pasien sinkron dengan database
            id_pasien_cb.DataSource = pasiendata;
            id_pasien_cb.DisplayMember = "id_pasien";
            id_pasien_cb.ValueMember = "id_pasien";

            keluhan_cb.DataSource = pasiendata;
            keluhan_cb.DisplayMember = "keluhan";
            keluhan_cb.ValueMember = "keluhan";
        }
        void combo2()
        {
            //memanggil data dari tabel dokter di isiCombo2 pada CheckoutCls
            DataTable dokterdata = checkout.isiCombo2();

            //untuk mengisi otomatis nama_dokter sinkron dengan database
            nama_dokter_cb.DataSource = dokterdata;
            nama_dokter_cb.DisplayMember = "nama_dokter";
            nama_dokter_cb.ValueMember = "nama_dokter";
        }
        void combo3()
        {
            //memanggil data dari tabel ruangan di isiCombo3 pada CheckoutCls
            DataTable ruangandata = checkout.isiCombo3();

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

            //untuk mengisi/menampilkan otomatis harga_ruangan sinkron dengan database
            harga_ruangan_cb.DataSource = ruangandata;
            harga_ruangan_cb.DisplayMember = "harga_ruangan";
            harga_ruangan_cb.ValueMember = "harga_ruangan";
        }

        void bersihkan()
        {
            id_checkout_txt.Text = checkout.buatid();
            id_pasien_cb.SelectedIndex = -1;
            nama_txt.Clear();
            lk_radio.Checked = false;
            pr_radio.Checked = false;
            usia_txt.Clear();
            tanggal_dt.Value = DateTime.Now;
            kontak_txt.Clear();
            almt_txt.Clear();
            keluhan_cb.SelectedIndex = -1;
            tanggal_masuk_dt.Value = DateTime.Now;
            tanggal_keluar_dt.Value = DateTime.Now;
            nama_dokter_cb.SelectedIndex = -1;
            noruangan_cb.SelectedIndex = -1;
            nama_ruangan_cb.SelectedIndex = -1;
            tipe_ruangan_cb.SelectedIndex = -1;
            harga_ruangan_cb.SelectedIndex = -1;
            biaya_txt.Clear();
            total_txt.Clear();
            nama_txt.Focus();
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            // Validate numeric input for biaya_pengobatan before proceeding
            if (!decimal.TryParse(biaya_txt.Text, out _))
            {
                MessageBox.Show("Tolong masukkan hanya numeric untuk biaya pengobatan.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!checkout.apakahAda(id_checkout_txt.Text))
            {
                checkout.Id_checkout = id_checkout_txt.Text;
                checkout.Id_pasien = id_pasien_cb.Text;
                checkout.Nama_pasien = nama_txt.Text;
                checkout.Jenis_kelamin = lk_radio.Checked ? "Laki-laki" : "Perempuan";
                checkout.Umur = usia_txt.Text;
                checkout.Tanggal_lahir = tanggal_dt.Value.ToString("yyyy-MM-dd");
                checkout.Kontak = kontak_txt.Text;
                checkout.Alamat = almt_txt.Text;
                checkout.Keluhan = keluhan_cb.Text;
                checkout.Tanggal_masuk = tanggal_masuk_dt.Value.ToString("yyyy-MM-dd");
                checkout.Tanggal_keluar = tanggal_keluar_dt.Value.ToString("yyyy-MM-dd");
                checkout.Nama_dokter = nama_dokter_cb.Text;
                checkout.No_ruangan = noruangan_cb.Text;
                checkout.Nama_ruangan = nama_ruangan_cb.Text;
                checkout.Tipe_ruangan = tipe_ruangan_cb.Text;
                checkout.Harga_ruangan = harga_ruangan_cb.Text;
                checkout.Biaya_pengobatan = biaya_txt.Text;
                checkout.Total = total_txt.Text;

                if (checkout.tambahCheckout() >= 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Checkout sudah ada", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            combo(); //memanggil method combo untuk ditampilkan di form
            combo2();
            combo3();
            bersihkan();
        }

        //Method untuk mengisi/menampilkan otomatis data pasien berdasarkan id_pasien yang dipilih
        private void id_pasien_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (id_pasien_cb.SelectedIndex != -1)
            {
                string id_pasien = id_pasien_cb.SelectedValue.ToString();
                DataTable pasiendata = checkout.isiDataPasien(id_pasien);

                if (pasiendata.Rows.Count > 0)
                {
                    nama_txt.Text = pasiendata.Rows[0]["nama_pasien"].ToString();
                    lk_radio.Checked = pasiendata.Rows[0]["jenis_kelamin"].ToString() == "Laki-laki" ? true : false;
                    pr_radio.Checked = pasiendata.Rows[0]["jenis_kelamin"].ToString() == "Perempuan" ? true : false;
                    usia_txt.Text = pasiendata.Rows[0]["umur"].ToString();
                    tanggal_dt.Value = Convert.ToDateTime(pasiendata.Rows[0]["tanggal_lahir"].ToString());
                    kontak_txt.Text = pasiendata.Rows[0]["kontak"].ToString();
                    almt_txt.Text = pasiendata.Rows[0]["alamat"].ToString();
                    keluhan_cb.Text = pasiendata.Rows[0]["keluhan"].ToString();
                    noruangan_cb.Text = pasiendata.Rows[0]["no_ruangan"].ToString();
                    nama_ruangan_cb.Text = pasiendata.Rows[0]["nama_ruangan"].ToString();
                    tipe_ruangan_cb.Text = pasiendata.Rows[0]["tipe_ruangan"].ToString();
                    harga_ruangan_cb.Text = pasiendata.Rows[0]["harga_ruangan"].ToString();
                }
                else
                {
                    nama_txt.Text = "";
                    lk_radio.Checked = false;
                    pr_radio.Checked = false;
                    usia_txt.Text = "";
                    tanggal_dt.Value = DateTime.Now;
                    kontak_txt.Text = "";
                    almt_txt.Text = "";
                    keluhan_cb.Text = "";
                    noruangan_cb.Text = "";
                    nama_ruangan_cb.Text = "";
                    tipe_ruangan_cb.Text = "";
                    harga_ruangan_cb.Text = "";
                }
            }
        }

        //Method untuk mengisi otomatis nama, tipe, harga ruangan berdasarkan no ruangan yang dipilih
        private void noruangan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noruangan_cb.SelectedIndex != -1)
            {
                string no_ruangan = noruangan_cb.SelectedValue.ToString(); //mengambil data dari no_ruangan yang dipilih
                DataTable ruangandata = checkout.isiDataRuangan(no_ruangan);

                if (ruangandata.Rows.Count > 0)
                {
                    nama_ruangan_cb.Text = ruangandata.Rows[0]["nama_ruangan"].ToString();
                    tipe_ruangan_cb.Text = ruangandata.Rows[0]["tipe_ruangan"].ToString();
                    harga_ruangan_cb.Text = ruangandata.Rows[0]["harga_ruangan"].ToString();
                }
                else
                {
                    nama_ruangan_cb.Text = "";
                    tipe_ruangan_cb.Text = "";
                    harga_ruangan_cb.Text = "";
                }
            }
        }

        private void HitungTotal()
        {
            // Pastikan harga_ruangan tidak kosong dan biaya_pengobatan valid atau kosong
            if (decimal.TryParse(harga_ruangan_cb.Text, out decimal hargaRuangan))
            {
                if (string.IsNullOrWhiteSpace(biaya_txt.Text)) //jika biaya kosong, maka total kosong (tidak muncul pesan error)
                {
                    total_txt.Text = "";
                }
                else if (decimal.TryParse(biaya_txt.Text, out decimal biayaPengobatan))
                {
                    decimal total = hargaRuangan + biayaPengobatan;
                    total_txt.Text = total.ToString();
                }
                else
                {
                    total_txt.Text = "Invalid input"; //jika biaya tidak valid (non numeric), maka akan muncul pesan error
                }
            }
        }


        private void harga_ruangan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void biaya_txt_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void Checkout_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol enter ditekan, maka akan memanggil method tambah_btn_Click
            if (e.KeyChar == (char)13)
            {
                tambah_btn_Click(sender, e);
            }

        }

        private void Checkout_KeyDown(object sender, KeyEventArgs e)
        {
            // Jika tombol escape ditekan, maka akan memanggil method reset_btn_Click
            if (e.KeyCode == Keys.Escape)
            {
                reset_btn_Click(sender, e);
            }

        }

        private void id_checkout_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
