using SIMAPUS.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data; // Menggunakan namespace System.Data
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMAPUS.model
{
    internal class LoginCls
    {
        //Atribut
        private string username; // Mendefinisikan variabel private user_id
        private string password; // Mendefinisikan variabel private password

        Koneksi koneksi; // Mendefinisikan variabel koneksi dari tipe KoneksiCls
        DataTable temp; // Mendefinisikan variabel temp dari tipe DataTable
        string query; // Mendefinisikan variabel query dari tipe string

        public LoginCls() // Konstruktor kelas LoginCLs
        {
            username = ""; // Menginisialisasi user_id dengan string kosong
            password = ""; // Menginisialisasi password dengan string kosong

            koneksi = new Koneksi(); // Membuat objek baru dari kelas KoneksiCls
            temp = new DataTable(); // Membuat objek baru dari kelas DataTable
            query = ""; // Menginisialisasi query dengan string kosong
        }

        public string Username // Property User_id untuk set nilai user_id
        {
            set { username = value; } // Mengatur nilai user_id
        }

        public string Password // Property Password untuk set nilai password
        {
            set { password = value; } // Mengatur nilai password
        }

        //Ngecek apakah username sama password sudah ada atau belum pada database
        public bool cekLogin(string user, string pass) // Metode untuk memeriksa login
        {
            bool cek = false; // Mendefinisikan variabel cek dan menginisialisasi dengan false
            // Membuat query SQL untuk memeriksa user dan password di database
            query = "SELECT * FROM admin WHERE username = '" + user + "' AND password = '" + pass + "'";
            temp = koneksi.eksekusiQuery(query); // Menjalankan query dan menyimpan hasilnya di temp

            if (temp.Rows.Count > 0) // Jika ada baris di temp (artinya user dan password ada di database)
            {
                cek = true; // Mengatur cek menjadi true
            }

            return cek; // Mengembalikan nilai cek
        }
    }
}
