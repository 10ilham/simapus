using SIMAPUS.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMAPUS.model
{
    internal class DokterCls // membuat kelas DokterCls 
    {
        private string id_dokter;// atribut dari kelas DokterClass
        private string nama_dokter;
        private string jenis_kelamin;
        private string spesialis;
        private string gaji;
        private string kontak;
        private string alamat;

        Koneksi koneksi;// membuat koneksi ke database dari folder konfigurasi 
        DataTable temp;
        string query; //untuk Insert, Update, Delete

        //Konstruktor DokterCls
        public DokterCls()
        {
            id_dokter = ""; //proses inisialisasi variabel / properti
            nama_dokter = ""; //proses inisialisasi variabel / properti
            jenis_kelamin = "";
            spesialis = "";
            gaji = "";
            kontak = "";
            alamat = "";

            koneksi = new Koneksi(); //membuat objek koneksi
            temp = new DataTable(); //membuat objek datatable
            query = ""; //membuat objek query
        }

        //Menambahkan Accessor Method mengatur nilai dari variabel
        public string Id_dokter
        {
            set { id_dokter = value; }// prosedur setter 
        }
        public string Nama_dokter
        {
            set { nama_dokter = value; }
        }
        public string Jenis_kelamin
        {
            set { jenis_kelamin = value; }
        }
        public string Spesialis
        {
            set { spesialis = value; }
        }
        public string Gaji
        {
            set { gaji = value; }
        }
        public string Kontak
        {
            set { kontak = value; }
        }
        public string Alamat
        {
            set { alamat = value; }
        }


        //Method untuk mengecek apakah data sudah ada atau belum
        public bool apakahAda(string id_dokter)// metod fungsi 
        {
            bool cek = false; //mengecek data false = tidak ada
            query = "SELECT * FROM dokter WHERE id_dokter = '" + id_dokter + "'";// perintah dari sql
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true; //jika data sudah ada
            }
            return cek;
        }

        //Method untuk menambahkan data
        public int tambahDokter()
        {
            int result = -1;
            query = "INSERT INTO dokter VALUES ('" + id_dokter + "','" + nama_dokter + "','" + jenis_kelamin + "','" + spesialis + "','" + gaji + "','" + kontak + "','" + alamat + "')";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //memanggil method eksekusiNonQuery di class Koneksi
                if (result > 0)
                {
                    throw new Exception("Gagal menambahkan data dokter");
                }
            }
            catch (Exception e) { }
            return result;
        }

        //Method untuk mengubah data
        public int ubahDokter(string id)
        {
            int result = -1;
            query = "UPDATE dokter SET nama_dokter = '" + nama_dokter + "', jenis_kelamin = '" + jenis_kelamin + "', spesialis = '" + spesialis + "', gaji = '" + gaji + "', kontak = '" + kontak + "', alamat = '" + alamat + "' WHERE id_dokter = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //memanggil method eksekusiNonQuery di class Koneksi
                if (result > 0)
                {
                    throw new Exception("Gagal mengubah data dokter");
                }
            }
            catch (Exception e) { }
            return result;
        }

        //Method untuk menghapus data
        public int hapusDokter(string id)
        {
            int result = -1;
            query = "DELETE FROM dokter WHERE id_dokter = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //memanggil method eksekusiNonQuery di class Koneksi
                if (result > 0)
                {
                    throw new Exception("Gagal menghapus data dokter");
                }
            }
            catch (Exception e) { }
            return result;
        }

        //Method untuk menambahkan id_dokter otomatis berdasarkan id terakhir
        public string buatid()
        {
            string id = "";
            int result = -1; //inisialisasi result untuk menampung hasil eksekusi query
            query  = "SELECT IFNULL(MAX(id_dokter),0)+1 AS id FROM dokter";
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

        //Method untuk menampilkan data dokter pada datagridview
        public DataTable tampilDokter()
        {
            query = "SELECT * FROM dokter";
            return koneksi.eksekusiQuery(query);
        }
    }
}
