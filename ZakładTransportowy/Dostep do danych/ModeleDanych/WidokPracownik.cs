using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class WidokPracownik
    {
        public int idPracownik { get; set; }
        public int idKontakt { get; set; }
        public String IMIE { get; set; }
        public String NAZWISKO { get; set; }
        public String UPRAWNIENIA { get; set; }
        public int PENSJA { get; set; }
        public String NUMER_TELEFONU { get; set; }
        public String EMAIL { get; set; }

        public WidokPracownik(Int32 idPracownik, Int32 idKontakt, String IMIE, String NAZWISKO, String UPRAWNIENIA, Int32 PENSJA, String NUMER_TELEFONU, String EMAIL)
        {
            this.idPracownik = idPracownik;
            this.idKontakt = idKontakt;
            this.IMIE = IMIE;
            this.NAZWISKO = NAZWISKO;
            this.UPRAWNIENIA = UPRAWNIENIA;
            this.PENSJA = PENSJA;
            this.NUMER_TELEFONU = NUMER_TELEFONU;
            this.EMAIL = EMAIL;
        }

        public WidokPracownik(String IMIE, String NAZWISKO, String UPRAWNIENIA, int PENSJA, String NUMER_TELEFONU, String EMAIL)
        {
            this.idPracownik = 0;
            this.idKontakt = 0;
            this.IMIE = IMIE;
            this.NAZWISKO = NAZWISKO;
            this.UPRAWNIENIA = UPRAWNIENIA;
            this.PENSJA = PENSJA;
            this.NUMER_TELEFONU = NUMER_TELEFONU;
            this.EMAIL = EMAIL;
        }
    }

}
