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
    public partial class LaporanCheckout : Form
    {
        CheckoutCls checkout = new CheckoutCls();
        public LaporanCheckout()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_checkout_txt.Clear();
            id_checkout_txt.Focus();
        }

        void tampilGrid()
        {
            laporan_dgv.DataSource = checkout.tampilCheckout();
        }

        private void cari_btn_Click(object sender, EventArgs e)
        {
            //cari_btn.Enabled = false;
            laporan_dgv.DataSource = checkout.cariDgId(id_checkout_txt.Text);
        }

        private void LaporanCheckout_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        //Untuk menampilkan id_pasien di textbox ketika diklik pada column
        private void laporan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.laporan_dgv.Rows[e.RowIndex];
                id_checkout_txt.Text = baris.Cells[0].Value.ToString();
            }
        }

        private void id_checkout_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (id_checkout_txt.Text == "")
            {
                MessageBox.Show("Masukkan ID Checkout yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data checkout ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkout.hapusCheckout(id_checkout_txt.Text) > 0)
                    {
                        MessageBox.Show("Data checkout berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data checkout gagal dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        //Untuk saat kita tekan entar maka akan mencari data sesuai dengan id_checkout yang diinputkan
        private void LaporanCheckout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cari_btn_Click(sender, e);
            }
        }

        private void LaporanCheckout_KeyDown(object sender, KeyEventArgs e)
        {
            //Jika kita menekan tombol delete maka akan menghapus data checkout
            if (e.KeyCode == Keys.Delete)
            {
                hapus_btn_Click(sender, e);
            }
        }
    }
}
