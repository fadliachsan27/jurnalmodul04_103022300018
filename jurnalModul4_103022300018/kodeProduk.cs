using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalModul4_103022300018
{
    class kodeProduk
    {
        private Dictionary<string, string> daftarKodeElektronik;
            public kodeProduk()
            {
            daftarKodeElektronik = new Dictionary<string, string>
            {
                {"Laptop", "E100"},
                {"Smartphone", "E101"},
                {"Tablet", "E102"},
                {"Headset", "E103"},
                {"Keyboard", "E104"},
                {"Mouse", "E105"},
                {"Printer", "E106"},
                {"Monitor", "E107"},
                {"Smartwatch", "E108"},
                {"Kamera", "E109"}
            };
            }

        public string GetKodeElektronik(String elektronik)
        {
            if (daftarKodeElektronik.ContainsKey(elektronik))
            {
                return daftarKodeElektronik[elektronik];
            }
            else
            {
                return "Kode Pos Tidak Ditemukan";
            }
        }

        public void TampilkanSemua()
        {
            Console.WriteLine("Daftar kode Pos :");
            foreach (var entry in daftarKodeElektronik)
            {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
