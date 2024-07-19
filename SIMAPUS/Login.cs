using SIMAPUS.model;
using SIMAPUS.konfigurasi;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = username_lbl.Text;
            string password = password_lbl.Text;

            LoginCls loginCls = new LoginCls();

            // Memanggil metode cekLogin untuk memeriksa autentikasi
            bool isAuthenticated  = loginCls.cekLogin(username, password);

            if (isAuthenticated)
            {
                // Jika autentikasi berhasil, tampilkan dashboard
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Visible = false;
            }
            else
            {
                // Jika autentikasi gagal, tampilkan pesan kesalahan
                MessageBox.Show("Maaf, User ID atau Password Anda Salah.",
                                "Kesalahan", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                bersihkan();
            }
        }

        private void bersihkan()
        {
            username_lbl.Clear();
            password_lbl.Clear();
            username_lbl.Focus();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //jika tombol delete ditekan maka akan memanggil metode btn_reset_Click
            if (e.KeyCode == Keys.Delete)
            {
                // Panggil metode btn_reset_Click di sini
                btn_reset_Click(sender, e);
            }

            //jika tombol escape ditekan maka akan memanggil metode tutup_btn_Click
            if (e.KeyCode == Keys.Escape)
            {
                // Panggil metode tutup_btn_Click di sini
                tutup_btn_Click(sender, e);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Jika tombol enter ditekan maka akan memanggil metode btn_login_Click
            if (e.KeyChar == (char)13)
            {
                // Panggil metode btn_login_Click di sini
                btn_login_Click(sender, e);
            }
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
               "KONFIRMASI", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
