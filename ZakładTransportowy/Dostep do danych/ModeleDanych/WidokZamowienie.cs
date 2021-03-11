using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class WidokZamowienie
    {
        public int idZamowienie { get; set; }
        public int idKlient { get; set; }
        public int idPojazd { get; set; }
        public String rodzaj { get; set; }
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public DateTime data_zlozenia { get; set; }
        public DateTime data_realizacji { get; set; }
        public String czy_Zaplacono { get; set; }
        public decimal cena { get; set; }


        public WidokZamowienie(Int32 idZamowienie, Int32 idKlient, Int32 idPojazd, String IMIE, String NAZWISKO, DateTime DATA_ZLOZENIA, DateTime DATA_REALIZACJI,String Rodzaj, String CZY_ZAPLACONO, decimal CENA)
        {
            this.idZamowienie = idZamowienie;
            this.idKlient = idKlient;
            this.idPojazd = idPojazd;
            this.rodzaj = Rodzaj;
            this.imie = IMIE;
            this.nazwisko = NAZWISKO;
            this.data_zlozenia = DATA_ZLOZENIA;
            this.data_realizacji = DATA_REALIZACJI;
            this.czy_Zaplacono = CZY_ZAPLACONO;
            this.cena = CENA;
        }

        public WidokZamowienie(String rodzaj, String imie, String nazwisko, DateTime data_zlozenia, DateTime data_realizacji, String czy_zaplacono, decimal cena)
        {
            this.idKlient = 0;
            this.idPojazd = 0;
            this.idZamowienie = 0;
            this.rodzaj = rodzaj;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.data_realizacji = data_realizacji;
            this.data_zlozenia = data_zlozenia;
            this.czy_Zaplacono = czy_zaplacono;
            this.cena = cena;
        }

    }
}
