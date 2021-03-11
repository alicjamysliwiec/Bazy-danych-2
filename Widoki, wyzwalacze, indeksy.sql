DELIMITER //
-- -----------------------------------------------------
-- `Widok Zamowienie`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `View_Zamowienie`//
CREATE VIEW `View_Zamowienie` AS 
	SELECT `idZamowienie`, Zamowienie.idKlient, Zamowienie.idPojazd, Klient.IMIE, Klient.NAZWISKO, `DATA_ZLOZENIA`, 
			`DATA_REALIZACJI`, Pojazd.Rodzaj, Zamowienie.CZY_ZAPLACONO, Zamowienie.CENA
	FROM `Zamowienie`
    JOIN Klient ON Zamowienie.idKlientdodajKlienta = Klient.idKlient
    JOIN Pojazd ON Zamowienie.idPojazd = Pojazd.idPojazd
	//
-- -----------------------------------------------------
-- `Widok Pracownik`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `View_Pracownik`//
CREATE VIEW `View_Pracownik` AS 
	SELECT `idPracownik`, Pracownik.idKontakt, `IMIE`, `NAZWISKO`, `UPRAWNIENIA`, `PENSJA`, Kontakt.NUMER_TELEFONU, Kontakt.EMAIL
	FROM `Pracownik`
    JOIN Kontakt ON Pracownik.idKontakt = Kontakt.idKontakt
    //
-- -----------------------------------------------------
-- `Widok Klient`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `View_Klient`//
CREATE VIEW `View_Klient` AS 
	SELECT `idKlient`, Klient.idKontakt, `IMIE`, `NAZWISKO`, `Rodzaj_KLIENTA`,  Kontakt.NUMER_TELEFONU, Kontakt.EMAIL
	FROM `Klient`
    JOIN Kontakt ON Klient.idKontakt = Kontakt.idKontakt
    //
-- -----------------------------------------------------
-- `Widok Zamowienie_zrealizowane`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `View_Zamowienie_zrealizowane`//
CREATE VIEW `View_Zamowienie_zrealizowane` AS 
	SELECT `idRozliczenie`, Rozliczenie.idZamowienie, Zamowienie.idKlient, Klient.IMIE, KLIENT.NAZWISKO, Zamowienie.DATA_ZLOZENIA, 
			`DATA_ROZLICZENIA`, `BRUTTO`, `NETTO`
	FROM `Rozliczenie`
    JOIN Zamowienie ON Rozliczenie.idZamowienie = Zamowienie.idZamowienie
    JOIN Klient ON Zamowienie.idKlient = Klient.idKlient
    //
-- -----------------------------------------------------
-- `Wyzwalacz usuniecie_konta_klienta`
-- -----------------------------------------------------
DROP TRIGGER IF EXISTS `usuniecie_konta_klienta`//
CREATE TRIGGER usuniecie_konta_klienta
BEFORE DELETE ON `Klient`
FOR EACH ROW
	BEGIN 	
    DELETE FROM `Kontakt` WHERE idKontakt = old.idKontakt;
    UPDATE `Zamowienie` SET idKlient = NULL WHERE idKlient = old.idKlient;
	END
	//
-- -----------------------------------------------------
-- `Wyzwalacz usuniecie_konta_pracownika`
-- -----------------------------------------------------
DROP TRIGGER IF EXISTS `usuniecie_konta_pracownika`//
CREATE TRIGGER `usuniecie_konta_pracownika`
BEFORE DELETE ON `Pracownik`
FOR EACH ROW
	BEGIN 
    DELETE FROM `Pracownik_Pojazd` WHERE idPracownik = old.idPracownik;
    DELETE FROM `Kontakt` WHERE idkontakt = old.idKontakt;
    UPDATE `Raport` SET idPracownik = NULL WHERE idPracownik = old.idPracownik;	
	END
	//
-- -----------------------------------------------------
-- `Wyzwalacz usuniecie_pojazdu`
-- -----------------------------------------------------
DROP TRIGGER IF EXISTS `usuniecie_pojazdu`//
CREATE TRIGGER `usuniecie_pojazdu`
BEFORE DELETE ON `Pojazd`
FOR EACH ROW
	BEGIN 
    DELETE FROM `Pracownik_Pojazd` WHERE idPojazd = old.idPojazd;
	END
	//
DELIMITER ;
-- -----------------------------------------------------
-- `Indeksy`
-- -----------------------------------------------------
 CREATE INDEX imie_nazwisko ON Klient(IMIE, NAZWISKO);
 CREATE INDEX imie_nazwisko ON Pracownik(IMIE, NAZWISKO);
