using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakładTransportowy
{ 
    public class Pojazd
    {
        public int idPojazd { get; set; }
        public String numerRejestracyjny { get; set; }
        public String rodzaj { get; set; }
        public DateTime dataOstatneigoPrzegladu { get; set; }
        public String stanTechniczny { get; set; }

        public Pojazd(Int32 idPojazd, String NUMER_REJESTRACYJNY, String RODZAJ, DateTime DATA_OSTATNIEGO_PRZEGLADU, String STAN_TECHNICZNY)
        {
            this.idPojazd = idPojazd;
            this.numerRejestracyjny = NUMER_REJESTRACYJNY;
            this.rodzaj = RODZAJ;
            this.dataOstatneigoPrzegladu = DATA_OSTATNIEGO_PRZEGLADU;
            this.stanTechniczny = STAN_TECHNICZNY;
        }

        public Pojazd(String numer, String rodzaj, DateTime data, String stan)
        {
            this.numerRejestracyjny = numer;
            this.rodzaj = rodzaj;
            this.dataOstatneigoPrzegladu = data;
            this.stanTechniczny = stan;
        }

        public Pojazd (int id)
        {
            this.idPojazd = id;
        }
    }
}