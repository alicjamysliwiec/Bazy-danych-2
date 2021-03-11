using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Klient
    {
        public int idKlient { get; set; }
        public Kontakt kontakt { get; set; }
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public String login { get; set; }
        public String haslo { get; set; }
        public DateTime ostatnieLogowanie { get; set; }
        public String rodzajKlienta { get; set; }
        public String nazwaFirmy { get; set; }
        public String nip { get; set; }

        public Klient(Int32 idKlient, Int32 idKontakt, String IMIE, String NAZWISKO, String LOGIN, String HASLO, DateTime OSTATNIE_LOGOWANIE, String RODZAJ_KLIENTA, String NAZWA_FIRMY, String NIP)
        {
            this.idKlient = idKlient;
            this.kontakt = new Kontakt(idKontakt);
            this.imie = IMIE;
            this.nazwisko = NAZWISKO;
            this.login = LOGIN;
            this.haslo = HASLO;
            this.ostatnieLogowanie = OSTATNIE_LOGOWANIE;
            this.rodzajKlienta = RODZAJ_KLIENTA;
            this.nazwaFirmy = NAZWA_FIRMY;
            this.nip = NIP;
        }

        public Klient(String numer, String email, String imie, String nazwisko, String login, String haslo, DateTime logowanie,
                      String rodzaj, String nFirmy, String nip)
        {
            this.idKlient = 0;
            this.kontakt = new Kontakt(numer, email);
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = login;
            this.haslo = haslo;
            this.ostatnieLogowanie = logowanie;
            this.rodzajKlienta = rodzaj;
            this.nazwaFirmy = nFirmy;
            this.nip = nip;
        }

        public Klient(int id)
        {
            this.idKlient = id;
        }
    }
}
