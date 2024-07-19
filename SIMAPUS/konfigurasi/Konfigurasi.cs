using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMAPUS.konfigurasi
{
    abstract class Konfigurasi
    {
        //Method untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiNonQuery(string query);

        //Method untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);
    }
}
