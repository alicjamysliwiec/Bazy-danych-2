using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy.Dostep_do_danych.ModeleDanych
{
    public class WidokKlient
    {
        public int idKlient { get; set; }
        public int idKontakt { get; set; }
        public String IMIE { get; set; }
        public String NAZWISKO { get; set; }
        public String RODZAJ_KLIENTA { get; set; }
        public String NUMER_TELEFONU { get; set; }
        public String EMAIL { get; set; }

        public WidokKlient(Int32 idKlient, Int32 idKontakt, String IMIE, String NAZWISKO, String RODZAJ_KLIENTA, String NUMER_TELEFONU, String EMAIL)
        {
            this.idKlient = idKlient;
            this.idKontakt = idKontakt;
            this.IMIE = IMIE;
            this.NAZWISKO = NAZWISKO;
            this.RODZAJ_KLIENTA = RODZAJ_KLIENTA;
            this.NUMER_TELEFONU = NUMER_TELEFONU;
            this.EMAIL = EMAIL;
        }
    }

}
