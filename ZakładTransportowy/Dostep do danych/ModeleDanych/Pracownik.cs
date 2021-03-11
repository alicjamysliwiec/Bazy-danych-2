using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Pracownik
    {
        public int idPracownik { get; set; }
        public Kontakt kontakt { get; set; }
        public int idKierownik { get; set; } 
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public String login { get; set; }
        public String haslo { get; set; }
        public String uprawnienia { get; set; }
        public int pensja { get; set; }
        public DateTime dataZatrudnienia { get; set; }

        public Pracownik(String numerTelefonu, String email, int idKierownik, String imie, String nazwisko, String login,
                         String haslo, String uprawnienia, int pensja, DateTime dataZatrudnienia)
        {
            this.idPracownik = 0;
            this.kontakt = new Kontakt(numerTelefonu, email);
            this.idKierownik = idKierownik;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = login;
            this.haslo = haslo;
            this.uprawnienia = uprawnienia;
            this.pensja = pensja;
            this.dataZatrudnienia = dataZatrudnienia;
        }

        public Pracownik(Int32 idPracownik, Int32 idKontakt, Int32 idKierownik, String IMIE, String NAZWISKO, String LOGIN, String HASLO,
                         String UPRAWNIENIA, Int32 PENSJA, DateTime DATA_ZATRUDNIENIA)
        {
            this.idPracownik = idPracownik;
            this.kontakt = new Kontakt(idKontakt);
            this.idKierownik = idKierownik;
            this.imie = IMIE;
            this.nazwisko = NAZWISKO;
            this.login = LOGIN;
            this.haslo = HASLO;
            this.uprawnienia = UPRAWNIENIA;
            this.pensja = PENSJA;
            this.dataZatrudnienia = DATA_ZATRUDNIENIA;
        }
    }
}
