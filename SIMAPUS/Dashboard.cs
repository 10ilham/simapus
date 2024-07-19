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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //Menampilkan Form berdasarkan label yang diklik
        private void pendaftaran_lbl_Click(object sender, EventArgs e)
        {
            Pendaftaran pendaftaran = new Pendaftaran();
            pendaftaran.Show();
        }

        private void informasi_lbl_Click(object sender, EventArgs e)
        {
            InformasiPasien informasiPasien = new InformasiPasien();
            informasiPasien.Show();
        }

        private void checkout_lbl_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void ruangan_lbl_Click(object sender, EventArgs e)
        {
            Ruangan ruangan = new Ruangan();
            ruangan.Show();
        }

        private void dokter_lbl_Click(object sender, EventArgs e)
        {
            Dokter dokter = new Dokter();
            dokter.Show();
        }
        private void laporan_lbl_Click(object sender, EventArgs e)
        {
            LaporanCheckout laporanCheckout = new LaporanCheckout();
            laporanCheckout.Show();
        }

        // Tombol Keluar untuk keluar dari aplikasi
        private void tutup_btn_Click(object sender, EventArgs e)
        {
            // Konfirmasi sebelum keluar dari aplikasi
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi jika tombol 'Yes' ditekan
            }
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            //jika tombiol escape ditekan maka akan memanggil metode tutup_btn_Click
            if (e.KeyCode == Keys.Escape)
            {
                // Panggil metode reset_btn_Click di sini
                tutup_btn_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
