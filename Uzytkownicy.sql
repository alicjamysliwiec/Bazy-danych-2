-- -----------------------------------------------------
-- `Uzytkownicy`
-- -----------------------------------------------------
DROP USER IF EXISTS Domyslny;
flush privileges;
CREATE USER Domyslny IDENTIFIED BY 'domyslny';
DROP USER IF EXISTS Klient;
flush privileges;
CREATE USER Klient IDENTIFIED BY 'kLient12';
DROP USER IF EXISTS Właściciel;
flush privileges;
CREATE USER Właściciel IDENTIFIED BY 'sZef12';
DROP USER IF EXISTS Kierownik;
flush privileges;
CREATE USER Kierownik IDENTIFIED BY 'kIerownik12';
DROP USER IF EXISTS Pracownik;
flush privileges;
CREATE USER Pracownik IDENTIFIED BY 'pRacownik12';

FLUSH PRIVILEGES;
GRANT SELECT, INSERT ON `zaklad_transportowy`.Klient TO Domyslny;
GRANT SELECT ON `zaklad_transportowy`.Pracownik TO Domyslny;
GRANT SELECT, INSERT ON `zaklad_transportowy`.Kontakt TO Domyslny;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKlienta` TO Domyslny;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKontakt` TO Domyslny;

GRANT SELECT, INSERT, DELETE ON `zaklad_transportowy`.Zamowienie TO Klient;
GRANT SELECT, INSERT, DELETE, UPDATE ON `zaklad_transportowy`.Klient TO Klient;
GRANT SELECT, INSERT, DELETE, UPDATE ON `zaklad_transportowy`.Kontakt TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKlienta` TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKontakt` TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Klient;
GRANT SELECT ON `zaklad_transportowy`.Pojazd TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajZamowienie` TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Właściciel;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.view_zamowienie TO Klient;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.Pojazd TO Klient;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Klient;

GRANT SELECT ON `zaklad_transportowy`.Zamowienie TO Pracownik;
GRANT SELECT, UPDATE ON `zaklad_transportowy`.Pojazd TO Pracownik;
GRANT SELECT ON `zaklad_transportowy`.pracownik_pojazd TO Pracownik;
GRANT SELECT, INSERT, UPDATE ON `zaklad_transportowy`.Raport TO Pracownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRaport` TO Pracownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRozliczenie` TO Pracownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajZamowienie` TO Pracownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.Zamowienie TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.Klient TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.view_zamowienie TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.view_klient TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.Kontakt TO Pracownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.Rozliczenie TO Pracownik;

GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Kierownik;
GRANT SELECT, UPDATE ON `zaklad_transportowy`.Pojazd TO Kierownik;
GRANT SELECT ON `zaklad_transportowy`.Pracownik_Pojazd TO Kierownik;
GRANT SELECT, INSERT, UPDATE, DELETE ON `zaklad_transportowy`.Zamowienie TO Kierownik;
GRANT SELECT, INSERT, UPDATE ON `zaklad_transportowy`.Kontakt TO Kierownik;
GRANT SELECT, INSERT, DELETE, UPDATE ON `zaklad_transportowy`.Klient TO Kierownik;
GRANT SELECT, INSERT, UPDATE ON `zaklad_transportowy`.Rozliczenie TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKlienta` TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKontakt` TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajZamowienie` TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRaport` TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRozliczenie` TO Kierownik;
GRANT SELECT ON `zaklad_transportowy`.`view_zamowienie` TO Kierownik;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.view_klient TO Kierownik;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoKlienta` TO Kierownik;

GRANT SELECT ON `zaklad_transportowy`.* TO Właściciel;
GRANT INSERT, UPDATE ON `zaklad_transportowy`.Rozliczenie TO Właściciel;
GRANT INSERT, UPDATE, DELETE ON `zaklad_transportowy`.Pracownik to Właściciel;
GRANT INSERT, UPDATE, DELETE ON `zaklad_transportowy`.Pojazd to Właściciel;
GRANT INSERT, UPDATE, DELETE ON `zaklad_transportowy`.Pracownik_pojazd to Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajPracownika` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`przypiszPojazdDoPracownika` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajKontakt` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRaport` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajRozliczenie` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`dodajPojazd` TO Właściciel;
GRANT EXECUTE ON PROCEDURE `zaklad_transportowy`.`modyfikujKontoPracownika` TO Właściciel;
GRANT EXECUTE ON FUNCTION `zaklad_transportowy`.`dochod` TO Właściciel;
GRANT EXECUTE ON FUNCTION `zaklad_transportowy`.`dochod_dnia` TO Właściciel;
GRANT EXECUTE ON FUNCTION `zaklad_transportowy`.`dochod_z_okresu_czasu` TO Właściciel;
GRANT EXECUTE ON FUNCTION `zaklad_transportowy`.`srednie_zarobki` TO Właściciel;
GRANT EXECUTE ON FUNCTION `zaklad_transportowy`.`vat` TO Właściciel;
GRANT SELECT, UPDATE, DELETE, INSERT ON `zaklad_transportowy`.view_pracownik TO Właściciel;

