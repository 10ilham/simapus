using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMAPUS.konfigurasi;
using System.Data;

namespace SIMAPUS.model
{
    internal class RuanganCls
    {
        private string no_ruangan;
        private string nama_ruangan;
        private string tipe_ruangan;
        private string harga_ruangan;

        Koneksi koneksi;
        DataTable temp;
        string query; //untuk Insert

        //Konstruktor RuanganCls
        public RuanganCls()
        {
            no_ruangan = ""; //proses inisialisasi variabel / properti
            nama_ruangan = ""; //proses inisialisasi variabel / properti
            tipe_ruangan = "";
            harga_ruangan = "";

            koneksi = new Koneksi(); //membuat objek koneksi
            temp = new DataTable(); //membuat objek datatable
            query = ""; //membuat objek query
        }

        //Accessor Method
        public string No_ruangan
        {
            set { no_ruangan = value; }  //properti setter
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

        public bool apakahAda(string no_ruangan)
        {
            bool cek = false;
            query = "SELECT * FROM ruangan WHERE no_ruangan = '" + no_ruangan + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //Method untuk menambahkan data ruangan
        public int tambahRuangan()
        {
            int result = -1;
            query = "INSERT INTO ruangan VALUES ('" + no_ruangan + "','" + nama_ruangan + "','" + tipe_ruangan + "','" + harga_ruangan + "')";
            try
            {
                result = koneksi.eksekusiNonQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menambahkan data pasien");
                }
            }
            catch (Exception e) { }
            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;
            query = "UPDATE ruangan SET nama_ruangan = '" + nama_ruangan + "', tipe_ruangan = '" + tipe_ruangan + "', harga_ruangan = '" + harga_ruangan + "' WHERE no_ruangan = '" + id + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuery dari class Koneksi
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data ruangan");
                }
            }
            catch (Exception e) { }
            return result;
        }

        //Method untuk menghapus data ruangan
        public int hapusRuangan(string no)
        {
            int result = -1;
            query = "DELETE FROM ruangan WHERE no_ruangan = '" + no + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query); //Memanggil method eksekusiNonQuey pada kelas KoneksiCls
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data ruangan");
                }
            }
            catch (Exception e) { }
            return result;
        }

        //Method untuk menambahkan no_ruangan otomatis
        public string buatid()
        {
            string no = "";
            int result = -1;
            query = "SELECT IFNULL(MAX(no_ruangan),0)+1 AS id FROM ruangan";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    no = "" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    no = result.ToString();
                }
            }
            return no;
        }

        public DataTable tampilRuangan()
        {
            query = "SELECT * FROM ruangan";
            return koneksi.eksekusiQuery(query);
        }
    }
}
