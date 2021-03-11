using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakładTransportowy.Dostep_do_danych.ModeleDanych;

namespace ZakładTransportowy
{
    class BazaDanych
    {   
        /// <summary>
        /// Reprezentuje aktualna nazswe polaczenia z baza.
        /// </summary>
        private static String connectionName = "ZakladTransportowy";

        public static void Wyloguj()
        {
            connectionName = "ZakladTransportowy";
        }

        public static String getConnectionName()
        {
            return connectionName;
        }

        /// <summary>
        /// Reprezentuje logowanie na konto klienta.
        /// </summary>
        /// <param name="wprowadzonyLogin"> login jakim identyfikowane jest konto</param>
        /// <param name="wprowadzoneHaslo"> haslo jakim identyfikowane jest konto</param>
        /// <returns>Zwaraca obiekt typu klient reprezentujacy zalogowanego klienta</returns>
       
        public static Klient LogowanieKlient(String wprowadzonyLogin, String wprowadzoneHaslo)
        {
            Klient klient = WyszukajKlienta(wprowadzonyLogin);
            if(klient != null)
            {
                if(klient.haslo == wprowadzoneHaslo)
                {
                    connectionName = "Klient";
                    AktualizujLogowanie(klient);
                    return klient;             
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Reprezentuje logowanie na konto pracownika
        /// </summary>
        /// <param name="wprowadzonyLogin"> login jakim identyfikowane jest konto</param>
        /// <param name="wprowadzoneHaslo"> haslo jakim identyfikowane jest konto</param>
        /// <returns></returns>
        public static Pracownik LogowaniePracownik(String wprowadzonyLogin, String wprowadzoneHaslo)
        {
            Pracownik pracownik = WyszukajPracownika(wprowadzonyLogin);
            if(pracownik != null)
            {
                if(pracownik.haslo == wprowadzoneHaslo)
                {
                    if (pracownik.uprawnienia == "KIEROWNIK")
                    {
                        connectionName = "Kierownik";
                    }
                    else
                    {
                        connectionName = "Pracownik";
                    }
                    return pracownik;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Reprezentuje logowanie na konto wlasciciela
        /// </summary>
        /// <param name="wprowadzonyLogin"> login jakim identyfikowane jest konto</param>
        /// <param name="wprowadzoneHaslo"> haslo jakim identyfikowane jest konto</param>
        /// <returns>Zwraca informacje o powodzeniu logowania</returns>
        public static Boolean LogowanieWlasciciel(String wprowadzonyLogin, String wprowadzoneHaslo)
        {
            if(wprowadzonyLogin == "nosaljanek23" && wprowadzoneHaslo == "JANNOS3")
            {
                connectionName = "Właściciel";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Dodaje rekord w Tabeli Klient
        /// </summary>
        /// <param name="klient"></param>
        public static void DodajKontoKlienta(Klient klient)
        {

            Kontakt kontakt = DodajKontakt(klient.kontakt);
            klient.kontakt = kontakt;

            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idKontakt", klient.kontakt.idKontakt);
                p.Add("imie", klient.imie);
                p.Add("nazwisko", klient.nazwisko);
                p.Add("login", klient.login);
                p.Add("haslo", klient.haslo);
                p.Add("ostatnie_logowanie", klient.ostatnieLogowanie);
                p.Add("rodzaj", klient.rodzajKlienta);
                p.Add("nazwa_firmy", klient.nazwaFirmy);
                p.Add("nip", klient.nip);
                p.Add("id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dodajKlienta", p, commandType: CommandType.StoredProcedure);
                klient.idKlient = p.Get<int>("id");
            }
        }

        /// <summary>
        /// Usuwa rekord dotyczacy danego klienta z bazy
        /// </summary>
        /// <param name="klient"></param>
        public static void UsunKontoKlienta(Klient klient)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"DELETE FROM Klient WHERE idKlient = {klient.idKlient}");
            }
        }

        /// <summary>
        /// Edytuke rekord dotyczacy danego klienta w bazie
        /// </summary>
        /// <param name="klient">Obiekt reprezentujacy klienta ze zmodyfikowanymi danymi</param>
        public static void EdytujKontoKlienta(Klient klient)
        {

            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", klient.idKlient);
                p.Add("idK", klient.kontakt.idKontakt);
                p.Add("imie", klient.imie);
                p.Add("nazwisko", klient.nazwisko);
                p.Add("haslo", klient.haslo);
                p.Add("rodzaj", klient.rodzajKlienta);
                p.Add("nazwa_firmy", klient.nazwaFirmy);
                p.Add("nip", klient.nip);
                p.Add("numertelefonu", klient.kontakt.numerTelefonu);
                p.Add("email", klient.kontakt.email);

                connection.Execute("modyfikujKontoKlienta", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Wyszukuje konto klienta na podstawie loginu
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static Klient WyszukajKlienta(String login)
        {
            List<Klient> klienci = new List<Klient>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                klienci = connection.Query<Klient>($"SELECT * FROM Klient WHERE LOGIN = '{login}'").ToList();
            }
            klienci[0].kontakt = WyszukajKontakt(klienci[0].kontakt.idKontakt);
            return klienci[0];
        }

        /// <summary>
        /// Wyszukuje konto klienta na podstawie id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Klient WyszukajKlienta(int id)
        {
            List<Klient> klienci = new List<Klient>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                klienci = connection.Query<Klient>($"SELECT * FROM Klient WHERE idKlient = {id}").ToList();
            }
            klienci[0].kontakt = WyszukajKontakt(klienci[0].kontakt.idKontakt);
            return klienci[0];
        }



        /// <summary>
        /// Aktualizuje date ostatniego logowania danego klienta
        /// </summary>
        /// <param name="klient"></param>
        public static void AktualizujLogowanie(Klient klient)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"UPDATE Klient SET OSTATNIE_LOGOWANIE = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE idKlient = {klient.idKlient}");
            }
        }

        /// <summary>
        /// Dodaje rekord w Tabeli Pracownik
        /// </summary>
        /// <param name="pracownik"></param>
        /// <param name="uprawnieniaNaPojazd">Lista uprawnien na pojazdjakie posiada pracownik</param>
        public static void DodajKontoPracownika(Pracownik pracownik, List<String> uprawnieniaNaPojazd)
        {
            Kontakt kontakt = DodajKontakt(pracownik.kontakt);
            pracownik.kontakt = kontakt;

            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idKontakt", pracownik.kontakt.idKontakt);
                p.Add("idKierownik", pracownik.idKierownik);
                p.Add("imie", pracownik.imie);
                p.Add("nazwisko", pracownik.nazwisko);
                p.Add("login", pracownik.login);
                p.Add("haslo", pracownik.haslo);
                p.Add("uprawnienia", pracownik.uprawnienia);
                p.Add("pensja", pracownik.pensja);
                p.Add("data_zatrudnienia", pracownik.dataZatrudnienia);
                p.Add("id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dodajPracownika", p, commandType: CommandType.StoredProcedure);
                pracownik.idPracownik = p.Get<int>("id");
            }

            PowiazaniePracownikowPojazdow(pracownik, uprawnieniaNaPojazd);
        }

        /// <summary>
        /// Usuwa odpowiedni rekord z tabeli Pracownik
        /// </summary>
        /// <param name="pracownik"></param>
        public static void UsunKontoPracownika(Pracownik pracownik)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"DELETE FROM Pracownik WHERE idPracownik = {pracownik.idPracownik}");
            }
        }

        /// <summary>
        /// Edytuke rekord dotyczacy danego pracownika w bazie
        /// </summary>
        /// <param name="pracownik"></param>
        public static void EdytujKontoPracownika(Pracownik pracownik)
        {

            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", pracownik.idPracownik);
                p.Add("idK", pracownik.kontakt.idKontakt);
                p.Add("idKierownik", pracownik.idKierownik);
                p.Add("imie", pracownik.imie);
                p.Add("nazwisko", pracownik.nazwisko);
                p.Add("haslo", pracownik.haslo);
                p.Add("uprawnienia", pracownik.uprawnienia);
                p.Add("pensja", pracownik.pensja);
                p.Add("numertelefonu", pracownik.kontakt.numerTelefonu);
                p.Add("email", pracownik.kontakt.email);

                connection.Execute("modyfikujKontoPracownika", p, commandType: CommandType.StoredProcedure);
            }
        }


        /// <summary>
        /// Wyszukuje konkretne pojazdy, na ktore uprawnienia ma pracownik i przypisuje pojazdy do pracownika
        /// </summary>
        /// <param name="pracownik"></param>
        /// <param name="uprawnieniaNaPojazd"></param>
        public static void PowiazaniePracownikowPojazdow(Pracownik pracownik, List<String> uprawnieniaNaPojazd)
        {
            List<Pojazd> pojazdyDoPrzypisania = new List<Pojazd>();
            foreach (String u in uprawnieniaNaPojazd)
            {
                List<Pojazd> wyszukanePojazdy = WyszukajPojazd(u);
                if (wyszukanePojazdy != null)
                {
                    pojazdyDoPrzypisania.AddRange(wyszukanePojazdy);
                }
            }

            foreach (Pojazd p in pojazdyDoPrzypisania)
            {
                PracownikPojazd pracPojazd = new PracownikPojazd(pracownik, p);
                PrzypiszPojazdDoPracownika(pracPojazd);
            }
        }

        /// <summary>
        /// Dodaje rekord do tabeli Pracownik_Pojazd
        /// </summary>
        /// <param name="pracPojazd"></param>
        private static void PrzypiszPojazdDoPracownika(PracownikPojazd pracPojazd)
        {

            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idPojazd", pracPojazd.pojazd.idPojazd);
                p.Add("idPracownik", pracPojazd.pracownik.idPracownik);
                p.Add("id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("przypiszPojazdDoPracownika", p, commandType: CommandType.StoredProcedure);
                pracPojazd.idPracownikPojazd = p.Get<int>("id");
            }
        }

        /// <summary>
        /// Wyszukaj rekord tabeli Pracownik na podstawie loginu
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static Pracownik WyszukajPracownika(String login)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                pracownicy = connection.Query<Pracownik>($"SELECT * FROM Pracownik WHERE LOGIN = '{login}'").ToList();
            }
            pracownicy[0].kontakt = WyszukajKontakt(pracownicy[0].kontakt.idKontakt);
            return pracownicy[0];
        }


        /// <summary>
        /// Wyszukaj rekord tabeli Pracownik na podstawie id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Pracownik WyszukajPracownika(int id)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                pracownicy = connection.Query<Pracownik>($"SELECT * FROM Pracownik WHERE idPracownik = '{id}'").ToList();
            }
            pracownicy[0].kontakt = WyszukajKontakt(pracownicy[0].kontakt.idKontakt);
            return pracownicy[0];
        }

        /// <summary>
        /// Wyszukaj rekord tabeli Pracownik_Pojazd na podstawie danych pojazdu
        /// </summary>
        /// <param name="pojazd"></param>
        /// <returns></returns>
        public static List<Pracownik> WyszukajPracownikaPojazd(Pojazd pojazd)
        {
            List<int> listaId = new List<int>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                listaId = connection.Query<int>($"SELECT idPracownik FROM Pracownik_Pojazd WHERE idPojazd = '{pojazd.idPojazd}'").ToList();
            }

            List<Pracownik> pracownicyZUprawnieniami = new List<Pracownik>();
            foreach (int id in listaId)
            {
                pracownicyZUprawnieniami.Add(WyszukajPracownika(id));
            }

            return pracownicyZUprawnieniami;
        }


        /// <summary>
        /// Dodaje rekord do tabeli kontakt
        /// </summary>
        /// <param name="kontakt"></param>
        /// <returns></returns>
        private static Kontakt DodajKontakt(Kontakt kontakt)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("numer", kontakt.numerTelefonu);
                p.Add("email", kontakt.email);
                p.Add("id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dodajKontakt", p, commandType: CommandType.StoredProcedure);
                kontakt.idKontakt = p.Get<int>("id");
                return kontakt;
            }
        }

        /// <summary>
        /// Wyszukuje rekord z tabeli Kontakt na podstawie id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Kontakt WyszukajKontakt(int id)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<Kontakt> kontakty = connection.Query<Kontakt>($"SELECT * FROM Kontakt WHERE idKontakt = '{id}'").ToList();
                return kontakty[0];
            }
        }

        /// <summary>
        /// Dodaje rekord do tabeli Pojazd
        /// </summary>
        /// <param name="pojazd"></param>
        public static void DodajPojazd(Pojazd pojazd)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("numer", pojazd.numerRejestracyjny);
                p.Add("rodzaj", pojazd.rodzaj);
                p.Add("dataP", pojazd.dataOstatneigoPrzegladu);
                p.Add("stanTechniczny", pojazd.stanTechniczny);
                p.Add("id", 0, dbType: DbType.Int32, ParameterDirection.Output);

                connection.Execute("dodajPojazd", p, commandType: CommandType.StoredProcedure);
                pojazd.idPojazd = p.Get<int>("id");
            }

            List<Pracownik> pracownicy = new List<Pracownik>();
            pracownicy = WyszukajPracownikaOUprawnieniach(pojazd.rodzaj);
            foreach(Pracownik p in pracownicy)
            {
                PracownikPojazd pracownik_pojazd = new PracownikPojazd(p, pojazd);
                PrzypiszPojazdDoPracownika(pracownik_pojazd);
            }
        }


        /// <summary>
        /// Usuwa rekord z tabeli pojazd
        /// </summary>
        /// <param name="pojazd"></param>
        public static void UsunPojazd(Pojazd pojazd)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"DELETE FROM Pojazd WHERE idPojazd = {pojazd.idPojazd}");
            }
        }

        public static List<Pojazd> ListaPojazdow()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<Pojazd> pojazdy = connection.Query<Pojazd>($"SELECT * FROM Pojazd").ToList();
                return pojazdy;
            }
        }

        public static IList<WidokZamowienie> ListaZamowien()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<WidokZamowienie> zamowienia = connection.Query<WidokZamowienie>($"SELECT * FROM view_zamowienie").ToList();
                return zamowienia;
            }
        }

        public static IList<WidokKlient> ListaKlientow()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<WidokKlient> klienci = connection.Query<WidokKlient>($"SELECT * FROM view_klient").ToList();
                return klienci;
            }
        }

        public static IList<WidokZamowienie> ListaZamowienDlaKlienta(Klient klient)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<WidokZamowienie> zamowienia = connection.Query<WidokZamowienie>($"SELECT * FROM view_zamowienie WHERE idKlient = '{klient.idKlient}'").ToList();
                return zamowienia;
            }
        }
        /// <summary>
        /// Wyszukuje rekord z Tabeli Pojazd na podstawie id
        /// </summary>
        /// <param name="idPoajzd"></param>
        /// <returns></returns>
        public static Pojazd WyszukajPojazd(int idPoajzd)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<Pojazd> pojazdy = connection.Query<Pojazd>($"SELECT * FROM Pojazd WHERE idPojazd = {idPoajzd}").ToList();
                return pojazdy[0];
            }
        }

        /// <summary>
        /// Wyszukuje wszystkie rekordy z tabeli Pojazd odpowiadajace podanemu rodzajowi
        /// </summary>
        /// <param name="rodzaj">Okresla rodzaj pojazdu (Bus, Tir...)</param>
        /// <returns></returns>
        public static List<Pojazd> WyszukajPojazdSprawny(String rodzaj)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<Pojazd> pojazdy = connection.Query<Pojazd>($"SELECT * FROM Pojazd WHERE rodzaj = '{rodzaj}' AND stan_techniczny = 'SPRAWNY'").ToList();
                return pojazdy;
            }
        }

        public static List<Pojazd> WyszukajPojazd(String rodzaj)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                List<Pojazd> pojazdy = connection.Query<Pojazd>($"SELECT * FROM Pojazd WHERE rodzaj = '{rodzaj}'").ToList();
                return pojazdy;
            }
        }

        public static String SprawdzCzyOplacone(Zamowienie zamowienie)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                String oplacone = connection.Query<String>($"SELECT CZY_ZAPLACONO FROM Zamowienie WHERE idZamowienie = '{zamowienie.idZamowienie}'").ToList()[0].ToString();
                return oplacone;
            }
        }

        /// <summary>
        /// Zmienia status danego pojazdu (SPRAWNY, W_NAPRAWIE...)
        /// </summary>
        /// <param name="pojazd"></param>
        /// <param name="status"></param>
        public static void ZmienStatusPojazdu(Pojazd pojazd, String status, DateTime data)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"UPDATE Pojazd SET STAN_TECHNICZNY = '{status}' WHERE idPojazd = {pojazd.idPojazd}");
                connection.Execute($"UPDATE Pojazd SET DATA_OSTATNIEGO_PRZEGLADU = '{data.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE idPojazd = {pojazd.idPojazd}");
            }
        }

        public static void ZmienDate(Zamowienie zamowienie, DateTime data)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"UPDATE Zamowienie SET DATA_REALIZACJI = '{data.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE idZamowienie = {zamowienie.idZamowienie}");
            }
        }

        public static int IleSprawnychPojazdow()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                return connection.Query<int>($"SELECT COUNT(*) FROM Pojazd WHERE STAN_TECHNICZNY = 'SPRAWNY'").ToList()[0];
            }
        }

        public static IList<Pojazd> ListaSprawnychPojazdow()
        {
            IList<Pojazd> pojazdy = new List<Pojazd>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                pojazdy = connection.Query<Pojazd>($"SELECT * FROM Pojazd WHERE STAN_TECHNICZNY = 'SPRAWNY'").ToList();
            }
            return pojazdy;
        }

        public static IList<WidokPracownik> ListaPracownikow()
        {
            IList<WidokPracownik> pracownicy = new List<WidokPracownik>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                pracownicy = connection.Query<WidokPracownik>($"SELECT * FROM view_pracownik").ToList();
            }
            return pracownicy;
        }

        /// <summary>
        /// Wyszukaj rekordy tabeli Pracownik na podstawie uprawnien
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
       
        public static List<Pracownik> WyszukajPracownikaOUprawnieniach(String uprawnienie)
        {
            List<int> idPracownikow = new List<int>();
            List<Pracownik> pracownicy = new List<Pracownik>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                idPracownikow.AddRange(connection.Query<int>($"SELECT DISTINCT idPracownik FROM pracownik_pojazd " +
                    $" INNER JOIN Pojazd ON pracownik_pojazd.idPojazd = Pojazd.idPojazd WHERE RODZAJ = '{uprawnienie}'").ToList());
            }
            foreach (int id in idPracownikow)
            {
                pracownicy.Add(WyszukajPracownika(id));
            }
            return pracownicy;
        }


        /// <summary>
        /// Dodaje rekord do tabeli Zamowienie
        /// </summary>
        /// <param name="zamowienie"></param>
        public static void DodajZamowienie(Zamowienie zamowienie)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idKlient", zamowienie.klient.idKlient);
                p.Add("idPojazd", zamowienie.pojazd.idPojazd);
                p.Add("statusZ", zamowienie.status);
                p.Add("data_zlozenia", zamowienie.dataZlozenia);
                p.Add("data_realizacji", zamowienie.dataRealizacji);
                p.Add("cena", zamowienie.cena);
                p.Add("zaplacono", zamowienie.czyZaplacono);
                p.Add("id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dodajZamowienie", p, commandType: CommandType.StoredProcedure);
                zamowienie.idZamowienie = p.Get<int>("id");
            }
        }

        /// <summary>
        /// Usuwa rekord z tabeli zamowienie
        /// </summary>
        /// <param name="zamowienie"></param>
        public static void UsunZamowienie(Zamowienie zamowienie)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"DELETE FROM Zamowienie WHERE idZamowienie = {zamowienie.idZamowienie}");
            }
        }

        /// <summary>
        /// Zwraca rekord z tabeli Zamowienie na podstawie id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Zamowienie WyszukajZamowienie(int id)
        {
            List<Zamowienie> zamowienia = new List<Zamowienie>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                zamowienia = connection.Query<Zamowienie>($"SELECT * FROM Zamowienie WHERE idZamowienie = {id}").ToList();
            }
            zamowienia[0].klient = WyszukajKlienta(zamowienia[0].klient.idKlient);
            zamowienia[0].pojazd = WyszukajPojazd(zamowienia[0].pojazd.idPojazd);
            return zamowienia[0];
        }

        /// <summary>
        /// Zmienia status zamowienia w bazie na "Oplacony"
        /// </summary>
        /// <param name="zamowienie"></param>
        public static void ZmienStatusOplacenia(Zamowienie zamowienie)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"UPDATE Zamowienie SET CZY_ZAPLACONO = 'TAK' WHERE idZamowienie = {zamowienie.idZamowienie}");
            }
        }

        /// <summary>
        /// Zmienia status zamowienia w bazie
        /// </summary>
        /// <param name="zamowienie"></param>
        public static void ZmienStatusRealizacji(Zamowienie zamowienie, String status)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                connection.Execute($"UPDATE Zamowienie SET STATUS = '{status}' WHERE idZamowienie = {zamowienie.idZamowienie}");
            }
        }

        /// <summary>
        /// Rozliczza dane zamowienie, czyli dodaje rekord do tabeli Rozliczenie. Tworzy raport
        /// </summary>
        /// <param name="zamowienie"></param>
        /// <param name="formaRozliczenia"></param>
        /// <param name="formaPlatnosci"></param>
        /// <param name="pracownik"> Pracownik, ktory wykonal zamowienie</param>
        public static void RozliczZamowienie(Zamowienie zamowienie, String formaRozliczenia, String formaPlatnosci, Pracownik pracownik)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idZamowienie", zamowienie.idZamowienie);
                p.Add("formaR", formaRozliczenia);
                p.Add("formaP", formaPlatnosci);
                p.Add("dataR", zamowienie.dataRealizacji);
                p.Add("cena", zamowienie.cena);
                p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dodajRozliczenie", p, commandType: CommandType.StoredProcedure);
                connection.Execute($"UPDATE Rozliczenie SET DATA_ROZLICZENIA =  '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE idZamowienie = {zamowienie.idZamowienie}");
            }
            Raport raport = new Raport(pracownik, zamowienie);
            DodajRaport(raport);

        }

        /// <summary>
        /// Dodaje rekord do tabeli Raport
        /// </summary>
        /// <param name="raport"></param>
        public static void DodajRaport(Raport raport)
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idPracownik", raport.pracownik.idPracownik);
                p.Add("idZamowienie", raport.zamowienie.idZamowienie);

                connection.Execute("dodajRaport", p, commandType: CommandType.StoredProcedure);
            }
        }


        public static String dochodCalkowity()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                return connection.Query<decimal>("SELECT dochod()").ToList()[0].ToString();
            }
        }

        public static String dochodDnia()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                String dochod_Dnia = connection.Execute($"SELECT dochod_dnia('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')").ToString();

                if(dochod_Dnia == "-1")
                {
                    return null;
                }
                else
                {
                    return dochod_Dnia;
                }
               
            }
        }

        public static String SrednieZarobki()
        {
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                return connection.Query<decimal>("SELECT srednie_zarobki()").ToList()[0].ToString();
            }
        }

        /// <summary>
        /// Wyszukuje wszystkie zamowienia danego klienta
        /// </summary>
        /// <param name="klient"></param>
        /// <returns></returns>
        public static IList<Zamowienie> PrzegladajZamowienia(Klient klient)
        {
            IList<Zamowienie> zamowienia = new List<Zamowienie>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                zamowienia = connection.Query<Zamowienie>($"SELECT * FROM Zamowienie WHERE idKlient = {klient.idKlient}").ToList();
            }
            return zamowienia;
        }

        public static List<Zamowienie> PrzegladajZamowieniaNieoplacone(Klient klient)
        {
            List<Zamowienie> zamowienia = new List<Zamowienie>();
            using (IDbConnection connection = new MySqlConnection(Connection.GetConnectionString(connectionName)))
            {
                zamowienia = connection.Query<Zamowienie>($"SELECT * FROM Zamowienie WHERE idKlient = {klient.idKlient} AND CZY_ZAPLACONO = 'NIE'").ToList();
            }
            return zamowienia;
        }
    }
}
