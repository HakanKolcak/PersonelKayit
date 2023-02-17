using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıt
{
    public class Worker
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cınsıyet { get; set; }
        public string Durum { get; set; }
        public string Sehır { get; set; }
        public Decimal Maas { get; set; }
        public string TelNo { get; set; }
        public string Meslek { get; set; }
        public Avans _avans { get; set; } = new Avans();
    }
}
