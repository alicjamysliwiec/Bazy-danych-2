DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajKlienta`(IN idKontakt int, imie varchar(20), nazwisko varchar(20),
				   login varchar(20), haslo varchar(20), ostatnie_logowanie datetime,
                   rodzaj enum('OSOBA FIZYCZNA','FIRMA'), nazwa_firmy varchar(45),
                   nip varchar(10), INOUT id int)
BEGIN
	INSERT INTO `Klient` (`idKontakt`, `IMIE`, `NAZWISKO`, `LOGIN`, `HASLO`,
						  `OSTATNIE_LOGOWANIE`, `RODZAJ_KLIENTA`, `NAZWA_FIRMY`,
                          `NIP`) VALUES	(idKontakt, imie, nazwisko, login, haslo,
                          ostatnie_logowanie, rodzaj, nazwa_firmy, nip);
	
	SET id = (SELECT idKlient FROM `Klient` ORDER BY idKlient DESC LIMIT 1);
END$$klient
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajKontakt`(IN numer varchar(20), email varchar(45), INOUT id int)
BEGIN
	INSERT INTO `Kontakt` (`NUMER_TELEFONU`, `EMAIL`) VALUES (numer, email);
    
    SET id = (SELECT idKontakt FROM `Kontakt` ORDER BY idKontakt DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajPracownika`(IN idKontakt int, idKierownik int, imie varchar(20), nazwisko varchar(20),
									login varchar(20), haslo varchar(20), uprawnienia enum('ADMINISTRATOR','WLASCICIEL','KIEROWNIK','MECHANIK','KIEROWCA'),
                                    pensja int, data_zatrudnienia datetime, INOUT id int)
BEGIN

	INSERT INTO `Pracownik`(`idKontakt`, `idKierownik`, `imie`, `nazwisko`, `login`, 
							`haslo`, `uprawnienia`, `pensja`, `data_zatrudnienia`)
                            VALUES (idKontakt, idKierownik, imie, nazwisko, login, haslo,
									uprawnienia, pensja, data_zatrudnienia);
		
	SET id = (SELECT `idPracownik` FROM `Pracownik` ORDER BY `idPracownik` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `przypiszPojazdDoPracownika`(IN idPojazd int, idPracownik int, INOUT id int)
BEGIN
	
    INSERT INTO `pracownik_pojazd` (`idPojazd`, `idPracownik`) VALUES (idPojazd, idPracownik);
    SET id = (SELECT `idPracownik_Pojazd` FROM `pracownik_pojazd` ORDER BY `idPracownik_Pojazd` DESC LIMIT 1);
END$$
DELIMITER ;
DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajZamowienie`(IN idKlient int, idPojazd int, statusZ enum('ZLOZONO','W TRAKCIE','ZREALIZOWANO'),
									data_zlozenia date, data_realizacji date, cena decimal(10,2), zaplacono char(3), INOUT id int)
BEGIN
	
    INSERT INTO `zaklad_transportowy`.`Zamowienie` (`idKlient`, `idPojazd`, `STATUS`, `DATA_ZLOZENIA`, `DATA_REALIZACJI`, `CENA`, `CZY_ZAPLACONO`) 
    VALUES (idKlient, idPojazd, statusZ, data_zlozenia, data_realizacji, cena, zaplacono);
    SET id = (SELECT `idZamowienie` FROM `Zamowienie` ORDER BY `idZamowienie` DESC LIMIT 1);
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajRozliczenie`(IN idZamowienie int, formaR enum('PARAGON','FAKTURA'), 
									 formaP enum('PRZELEW','GOTOWKA','KARTA PLATNICZA'), dataR date, cena decimal(10,2), INOUT id int)
BEGIN

	INSERT INTO `zaklad_transportowy`.`Rozliczenie` (`idZamowienie`,`FORMA_ROZLICZENIA`,`FORMA_PLATNOSCI`,`DATA_ROZLICZENIA`,`BRUTTO`,`NETTO`,`VAT`)
	VALUES(idZamowienie, formaR, formaP, dataR, cena, netto(cena), vat(cena));
    SET id = (SELECT `idRozliczenie` FROM `Rozliczenie` ORDER BY `idRozliczenie` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajRaport`(IN idPracownik int, idZamowienie int)
BEGIN
	INSERT INTO `Raport`(`idPracownik`, `idZamowienie`) VALUES(idPracownik, idZamowienie);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajPojazd`(IN numer varchar(10), rodzaj enum('BUS','TIR','CIĘŻARÓWKA','CYSTERNA','OSOBÓWKA'),
								 dataP datetime, stanTechniczny enum('SPRAWNY','POTRZEBNY PRZEGLAD','W NAPRAWIE','DO NAPRAWY'), INOUT id int)
BEGIN

	INSERT INTO `Pojazd`( `NUMER_REJESTRACYJNY`, `RODZAJ`, `DATA_OSTATNIEGO_PRZEGLADU`, `STAN_TECHNICZNY`)
					     VALUES (numer, rodzaj, dataP, stanTechniczny);
	SET id = (SELECT `idPojazd` FROM `Pojazd` ORDER BY `idPojazd` DESC LIMIT 1);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `modyfikujKontoKlienta`(IN id int, idK int, imie varchar(20), nazwisko varchar(20),
				   haslo varchar(20), rodzaj enum('OSOBA FIZYCZNA','FIRMA'),
                   nip varchar(10), numertelefonu varchar(20), email varchar(45))
BEGIN

	UPDATE `Klient` SET `imie` = imie WHERE `idKlient` = id;
    UPDATE `Klient` SET `nazwisko` = nazwisko WHERE `idKlient` = id;
    UPDATE `Klient` SET `haslo` = haslo WHERE `idKlient` = id;
    UPDATE `Klient` SET `rodzaj_klienta` = rodzaj WHERE `idKlient` = id;
	UPDATE `Klient` SET `nazwa_firmy` = nazwa_firmy WHERE `idKlient` = id;
    UPDATE `Klient` SET `nip` = nip WHERE `idKlient` = id;
    UPDATE `Kontakt` SET `NUMER_TELEFONU` = numertelefonu WHERE idKontakt = idK;
    UPDATE `Kontakt` SET `EMAIL` = email WHERE idKontakt = idK;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `modyfikujKontoPracownika`(IN id int, idK int, idKierownik int, imie varchar(20), nazwisko varchar(20),
									haslo varchar(20), uprawnienia enum('ADMINISTRATOR','WLASCICIEL','KIEROWNIK','MECHANIK','KIEROWCA'),
                                    pensja int, numertelefonu varchar(20), email varchar(45))
BEGIN
	UPDATE `Pracownik` SET `idKierownik` = idKierownik WHERE `idPracownik` = id;
	UPDATE `Pracownik` SET `imie` = imie WHERE `idPracownik` = id;
    UPDATE `Pracownik` SET `nazwisko` = nazwisko WHERE `idPracownik` = id;
    UPDATE `Pracownik` SET `haslo` = haslo WHERE `idPracownik` = id;
    UPDATE `Pracownik` SET `uprawnienia` = uprawnienia WHERE `idPracownik` = id;
    UPDATE `Pracownik` SET `pensja` = pensja WHERE `idPracownik` = id;
    UPDATE `Kontakt` SET `NUMER_TELEFONU` = numertelefonu WHERE idKontakt = idK;
    UPDATE `Kontakt` SET `EMAIL` = email WHERE idKontakt = idK;
END$$
DELIMITER ;


