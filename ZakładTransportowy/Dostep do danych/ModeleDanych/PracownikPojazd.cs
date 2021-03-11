using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class PracownikPojazd
    {
        public int idPracownikPojazd { get; set; }
        public Pojazd pojazd { get; set; }
        public Pracownik pracownik { get; set; }        

        public PracownikPojazd(Pracownik pracownik, Pojazd pojazd)
        {
            this.idPracownikPojazd = 0;
            this.pracownik = pracownik;
            this.pojazd = pojazd;
        }
    }
}
