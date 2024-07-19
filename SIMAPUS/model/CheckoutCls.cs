using SIMAPUS.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMAPUS.model
{
    internal class CheckoutCls //kelas CheckoutCls
    {
        private string id_checkout; //atribut
        private string id_pasien;
        private string nama_pasien;
        private string jenis_kelamin;
        private string umur;
        private string tanggal_lahir;
        private string kontak;
        private string alamat;
        private string keluhan;
        private string tanggal_masuk;
        private string tanggal_keluar;
        private string nama_dokter;
        private string no_ruangan;
        private string nama_ruangan;
        private string tipe_ruangan;
        private string harga_ruangan;
        private string biaya_pengobatan;
        private string total;

        Koneksi koneksi;
        DataTable temp;
        string query; //untuk Insert, Update, Delete

        //Konstruktor CheckoutCls
        public CheckoutCls()
        {
            id_checkout = ""; //proses inisialisasi variabel / properti
            id_pasien = ""; //proses inisialisasi variabel / properti id_pasien
            nama_pasien = "";
            jenis_kelamin = "";
            umur = "";
            tanggal_lahir = "";
            kontak = "";
            alamat = "";
            keluhan = "";
            tanggal_masuk = "";
            tanggal_keluar = "";
            nama_dokter = "";
            no_ruangan = "";
            nama_ruangan = "";
            tipe_ruangan = "";
            harga_ruangan = "";
            biaya_pengobatan = "";
            total = "";

            koneksi = new Koneksi(); //membuat objek koneksi
            temp = new DataTable(); //membuat objek datatable
            query = ""; //inisialisasi query
        }

        //Menambahkan Accessor Method mengatur nilai dari variabel
        public string Id_checkout
        {
            set { id_checkout = value; } //Mengatur nilai id_checkout, properti seeter
        }
        public string Id_pasien
        {
            set { id_pasien = value; }
        }
        public string Nama_pasien
        {
            set { nama_pasien = value; }
        }
        public string Jenis_kelamin
        {
            set { jenis_kelamin = value; }
        }
        public string Umur
        {
            set { umur = value; }
        }
        public string Tanggal_lahir
        {
            set { tanggal_lahir = value; }
        }
        public string Kontak
        {
            set { kontak = value; }
        }
        public string Alamat
        {
            set { alamat = value; }
        }
        public string Keluhan
        {
            set { keluhan = value; }
        }
        public string Tanggal_masuk
        {
            set { tanggal_masuk = value; }
        }
        public string Tanggal_keluar
        {
            set { tanggal_keluar = value; }
        }
        public string Nama_dokter
        {
            set { nama_dokter = value; }
        }
        public string No_ruangan
        {
            set { no_ruangan = value; }
        }
        public string Nama_ruangan
        {
            set { nama_ruangan = value; }
        }
        public string Tipe_ruangan
        {
            set { tipe_ruangan = value; }
        }
        public string Harga_ruangan
        {
            set { harga_ruangan = value; }
        }
        public string Biaya_pengobatan
        {
            set { biaya_pengobatan = value; }
        }
        public string Total
        {
            set { total = value; }
        }

        //Method untuk mengecek apakah id_checkout sudah ada atau belum
        public bool apakahAda(string id)
        {
            bool cek = false; //inisialisasi cek false (belum ada)
            query = "SELECT * FROM checkout WHERE id_checkout = '" + id + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public int tambahCheckout()
        {
            int result = -1;
            query = "INSERT INTO checkout VALUES ('" + id_checkout + "','" + id_pasien + "','" + nama_pasien + "','" + jenis_kelamin + "','" + umur + "','" + tanggal_lahir + "','" + kontak + "','" + alamat + "','" + keluhan + "','" + tanggal_masuk + "','" + tanggal_keluar + "','" + nama_dokter + "','" + no_ruangan + "','" + nama_ruangan + "','" + tipe_ruangan + "','" + harga_ruangan + "','" + biaya_pengobatan + "','" + total + "')";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuery dari class koneksi untuk menjalankan query
                if (result < 0)
                {
                    throw new Exception("Gagal menambahkan data checkout");
                }
            }catch (Exception e) { }
            return result;
        }

        //Method untuk menambahkan id_checkout secara otomatis berdasarkan id terakhir
        public string buatid()
        {
            string id = "";
            int result = -1; //inisialisasi result untuk menampung hasil query (id_checkout)
            query = "SELECT IFNULL(MAX(id_checkout),0)+1 AS id FROM checkout";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    id = "" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    id = result.ToString();
                }
            }
            return id;
        }

        //Method untuk mengisi combobox id_pasien_cb, keluhan akan tampil id_pasien, keluhan dari tabel pasien
        public DataTable isiCombo()
        {
            //query = "SELECT p.id_pasien, d.nama_dokter, r.no_ruangan FROM pasien p, dokter d, ruangan r";
            query = "SELECT * FROM pasien";
            return koneksi.eksekusiQuery(query);
        }
        public DataTable isiCombo2()
        {
            query = "SELECT nama_dokter FROM dokter";
            return koneksi.eksekusiQuery(query);
        }
        public DataTable isiCombo3()
        {
            //query = "SELECT no_ruangan FROM ruangan";
            query = "SELECT * FROM ruangan";
            return koneksi.eksekusiQuery(query);
        }

        //Method untuk menampilkan data pasien berdasarkan id_pasien
        public DataTable isiDataPasien(string id_pasien)
        {
            //query = "SELECT * FROM pasien WHERE id_pasien = '" + id_pasien + "'";
            query = "SELECT p.*, r.nama_ruangan, r.tipe_ruangan, r.harga_ruangan FROM pasien p JOIN ruangan r ON p.id_pasien = r.no_ruangan WHERE id_pasien = '" + id_pasien + "'";
            return koneksi.eksekusiQuery(query);
        }

        //Method untuk menampilkan data dokter berdasarkan nama_dokter
        public DataTable isiDataDokter(string nama_dokter)
        {
            query = "SELECT nama_dokter FROM dokter WHERE nama_dokter = '" + nama_dokter + "'";
            return koneksi.eksekusiQuery(query);
        }

        //Method untuk menampilkan data ruangan berdasarkan no_ruangan
        public DataTable isiDataRuangan(string no_ruangan)
        {
            query = "SELECT nama_ruangan, tipe_ruangan, harga_ruangan FROM ruangan WHERE no_ruangan = '" + no_ruangan + "'";
            return koneksi.eksekusiQuery(query);
        }

        //Untuk Laporan CheckOut
        //Mencari data checkout berdasarkan id_checkout
        public DataTable cariDgId(string id)
        {
            query = "SELECT * FROM checkout WHERE id_checkout = '" + id + "'";
            return koneksi.eksekusiQuery(query);
        }

        public DataTable tampilCheckout()
        {
            query = "SELECT * FROM checkout";
            return koneksi.eksekusiQuery(query);
        }

        //Untuk menghapus data checkout berdasarkan id_checkout
        public int hapusCheckout(string id)
        {
            int result = -1;
            query = "DELETE FROM checkout WHERE id_checkout = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data checkout");
                }
            }catch (Exception e) { }
            return result;
        }

    }
}
