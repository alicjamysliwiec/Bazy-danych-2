using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Rozliczenie
    {
        public int idRozliczenie { get; set; }
        public Zamowienie idZamowienie { get; set; }
        public String formaRozliczenia { get; set; }
        public String formaPlatnosci { get; set; }
        public float brutto { get; set; }
        public float netto { get; set; }
        public float vat { get; set; }
    }

}
