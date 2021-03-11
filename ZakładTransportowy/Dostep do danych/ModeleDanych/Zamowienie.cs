using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{
    public class Zamowienie
    {
        public int idZamowienie { get; set; }
        public Klient klient { get; set; }
        public Pojazd pojazd { get; set; }
        public String status { get; set; }
        public DateTime dataZlozenia { get; set; }
        public DateTime dataRealizacji { get; set; }
        public decimal cena { get; set; }
        public String czyZaplacono { get; set; }

        public Zamowienie(Int32 idZamowienie, Int32 idKlient, Int32 idPojazd, String STATUS, DateTime DATA_ZLOZENIA,
                           DateTime DATA_REALIZACJI, decimal CENA, String CZY_ZAPLACONO)
        {
            this.idZamowienie = idZamowienie;
            this.klient = new Klient(idKlient);
            this.pojazd = new Pojazd(idPojazd);
            this.status = STATUS;
            this.dataZlozenia = DATA_ZLOZENIA;
            this.dataRealizacji = DATA_REALIZACJI;
            this.cena = CENA;
            this.czyZaplacono = CZY_ZAPLACONO;
        }

        public Zamowienie(Klient klient, Pojazd pojazd, String status, DateTime dataZlozenia,
                          DateTime dataRealizacji, decimal cena, String zapalcono)
        {
            this.idZamowienie = 0;
            this.klient = klient;
            this.pojazd = pojazd;
            this.status = status;
            this.dataZlozenia = dataZlozenia;
            this.dataRealizacji = dataRealizacji;
            this.cena = cena;
            this.czyZaplacono = zapalcono;
        }
    }
}
