using SIMAPUS.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SIMAPUS.model
{
    internal class PasienCls
    {
        private string id_pasien;
        private string nama_pasien;
        private string jenis_kelamin;
        private string umur;
        private string tanggal_lahir;
        private string kontak;
        private string alamat;
        private string keluhan;
        private string no_ruangan;
        private string nama_ruangan;

        Koneksi koneksi;
        DataTable temp;
        string query; //untuk Insert, Update, Delete

        //Konstruktor PasienCls
        public PasienCls()
        {
            id_pasien = ""; //proses inisialisasi variabel / properti
            nama_pasien = ""; //proses inisialisasi variabel / properti
            jenis_kelamin = "";
            umur = "";
            tanggal_lahir = "";
            kontak = "";
            alamat = "";
            keluhan = "";
            no_ruangan = "";
            nama_ruangan = "";

            koneksi = new Koneksi(); //membuat objek koneksi
            temp = new DataTable(); //membuat objek datatable
            query = ""; //membuat objek query
        }

        //Menambahkan Accessor Method mengatur nilai dari variabel
        public string Id_pasien
        {
            set { id_pasien = value; } //Accessor Method atau membuat data (setter)
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
        public string No_ruangan
        {
            set { no_ruangan = value; }
        }
        public string Nama_ruangan
        {
            set { nama_ruangan = value; }
        }

        //Method untuk mengecek apakah data pasien sudah ada atau belum
        public bool apakahAda(string id)
        {
            bool cek = false; //inisialisasi cek false (belum ada)
            query = "SELECT * FROM pasien WHERE id_pasien = '" + id + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true; //jika data sudah ada
            }
            return cek;
        }

        //Method untuk menambahkan data pasien pada form pendaftaran
        public int tambahPasien()
        {
            int result = -1;
            string no_ruangan = getNoRuangan(nama_ruangan); //menjadikan nama ruangan menjadi no ruangan saat pendaftaran
            query = "INSERT INTO pasien VALUES ('" + id_pasien + "','" + nama_pasien + "','" + jenis_kelamin + "','" + umur + "','" + tanggal_lahir + "','" + kontak + "','" + alamat + "','" + keluhan + "', '" + no_ruangan + "')";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuery dari class Koneksi
                if (result < 0)
                {
                    throw new Exception("Gagal menambahkan data pasien");
                }
            }catch (Exception e) { }
            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;

            query = "UPDATE pasien SET nama_pasien = '" + nama_pasien + "', jenis_kelamin = '" + jenis_kelamin + "', umur = '" + umur + "', tanggal_lahir = '" + tanggal_lahir + "', kontak = '" + kontak + "', alamat = '" + alamat + "', keluhan = '" + keluhan + "', no_ruangan = '" + no_ruangan + "' WHERE id_pasien = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuery dari class Koneksi
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data pasien");
                }
            } catch (Exception e) { }
            return result;
        }

        public int hapusData(string id)
        {
            int result = -1;
            query = "DELETE FROM pasien WHERE id_pasien = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuery dari class Koneksi
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data pasien");
                }
            } catch (Exception e) { }
            return result;
        }

        //Method untuk menambahkan id_Pasien otomatis berdasarkan id terakhir
        public string buatid()
        {
            string id = "";
            int result = -1; //inisialisasi result untuk menampung hasil query (id_checkout)
            query = "SELECT IFNULL(MAX(id_pasien),0)+1 AS id FROM pasien";
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
                } else if (result >= 10 && result < 100)
                {
                    id = result.ToString();
                }
            }
            return id;
        }

        //Method untuk menampilkan data pasien pada datagridview ketika diklik
        public DataTable tampilPasien()
        {
            // Query dengan operasi JOIN antara tabel pasien dan ruangan
            query = "SELECT p.*, r.nama_ruangan, r.tipe_ruangan FROM pasien p JOIN ruangan r ON p.no_ruangan = r.no_ruangan";
            return koneksi.eksekusiQuery(query);
        }

        //Untuk mengisi combo box no ruangan
        public DataTable isicombo()
        {
            query = "SELECT * FROM ruangan";
            return koneksi.eksekusiQuery(query);
        }

        //Untuk mengisi data ruangan di combo box
        public DataTable isiDataRuangan(string no_ruangan)
        {
            query = "SELECT nama_ruangan, tipe_ruangan FROM ruangan WHERE no_ruangan = '" + no_ruangan + "'";
            return koneksi.eksekusiQuery(query);
        }

        // method untuk mendapatkan no_ruangan berdasarkan nama_ruangan
        public string getNoRuangan(string nama_ruangan)
        {
            string no_ruangan = "";
            query = "SELECT no_ruangan FROM ruangan WHERE nama_ruangan = '" + nama_ruangan + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                no_ruangan = temp.Rows[0]["no_ruangan"].ToString();
            }
            return no_ruangan;
        }

    }
}
