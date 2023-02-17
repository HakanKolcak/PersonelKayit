using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKayıt
{
    public class Avans
    {
        public DateTime AvansTarıhı { get; set; }
        public Decimal AvansMıktarı { get; set; }
        public Decimal KalanTutar { get; set; }
        public int Id { get; set; }
        public int PersonelId { get; set; }

    }
}
