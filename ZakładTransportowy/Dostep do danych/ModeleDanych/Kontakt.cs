using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Kontakt
    {
        public int idKontakt;
        public String numerTelefonu { get; set; }
        public String email { get; set; }

        public Kontakt(Int32 idKontakt, String NUMER_TELEFONU, String EMAIL)
        {
            this.idKontakt = idKontakt;
            this.numerTelefonu = NUMER_TELEFONU;
            this.email = EMAIL;
        }

        public Kontakt(String numer, String em)
        {
            this.idKontakt = 0;
            this.numerTelefonu = numer;
            this.email = em;
        }

        public Kontakt(int id)
        {
            this.idKontakt = id;
            this.email = null;
            this.numerTelefonu = null;
        }
    }
}
