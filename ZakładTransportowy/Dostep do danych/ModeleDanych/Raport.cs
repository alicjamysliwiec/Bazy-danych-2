using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Raport
    {
        public int idRaport { get; set; }
        public Pracownik pracownik { get; set; }
        public Zamowienie zamowienie { get; set; }

        public Raport(Pracownik p, Zamowienie z)
        {
            this.idRaport = 0;
            this.pracownik = p;
            this.zamowienie = z;
        }
    }
}
