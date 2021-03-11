using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakładTransportowy
{
    public partial class TworzenieKontaKlienta : Form
    {
        Klient klient;
        String imie;
        String nazwisko;
        String login;
        String haslo;
        String rodzaj_klienta;
        String numer_telefonu;
        String email;
        String nazwa_firmy;
        String nip;

        public TworzenieKontaKlienta(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
            tbImie.Text = klient.imie;
            tbNazwisko.Text = klient.nazwisko;
            tbLogin.Visible = false;
            loginlabel.Visible = true;
            loginlabel.Text = klient.login;
            tbHaslo.Text = klient.haslo;
            cmRodzajKlienta.Text = klient.rodzajKlienta;
            tbNumerTelefonu.Text = klient.kontakt.numerTelefonu;
            tbEmail.Text = klient.kontakt.email;
            tbNazwaFirmy.Text = klient.nazwaFirmy;
            tbNip.Text = klient.nip;

            if(cmRodzajKlienta.Text == "FIRMA")
            {
                gbFirma.Visible = true;
            }
            else
            {
                gbFirma.Visible = false;
            }
        }
        public TworzenieKontaKlienta()
        {
            InitializeComponent();
            gbFirma.Visible = false;
            loginlabel.Visible = false;
        }


        private void tbImie_TextChanged(object sender, EventArgs e)
        {
            imie = tbImie.Text;
        }

        private void tbNazwisko_TextChanged(object sender, EventArgs e)
        {
            nazwisko = tbNazwisko.Text;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            login = tbLogin.Text;
        }

        private void tbHaslo_TextChanged(object sender, EventArgs e)
        {
            haslo = tbHaslo.Text;
        }

        private void cmRodzajKlienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzaj_klienta = cmRodzajKlienta.Text;
            if(rodzaj_klienta == "FIRMA")
            {
                gbFirma.Visible = true;
            }
            else
            {
                gbFirma.Visible = false;
            }
        }

        private void tbNumerTelefonu_TextChanged(object sender, EventArgs e)
        {
            numer_telefonu = tbNumerTelefonu.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            email = tbEmail.Text;
        }

        private void tbNazwaFirmy_TextChanged(object sender, EventArgs e)
        {
            nazwa_firmy = tbNazwaFirmy.Text;
        }

        private void tbNip_TextChanged(object sender, EventArgs e)
        {
            nip = tbNip.Text;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if(klient == null)
            {
                try
                {
                    klient = new Klient(numer_telefonu, email, imie, nazwisko, login, haslo, DateTime.Now, rodzaj_klienta, nazwa_firmy, nip);
                    BazaDanych.DodajKontoKlienta(klient);
                    MessageBox.Show("Konto zostało utworzone! Zaloguj się za pomocą loginu i hasła. Login: " + login + ". Hasło: " + haslo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie wszystkie dane zostały poprawnie wprowadzone.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                klient.kontakt.numerTelefonu = numer_telefonu;
                klient.kontakt.email = email;
                klient.imie = imie;
                klient.nazwisko = nazwisko;
                klient.haslo = haslo;
                klient.rodzajKlienta = rodzaj_klienta;
                klient.nazwaFirmy = nazwa_firmy;
                klient.nip = nip;

                try
                { 
                    BazaDanych.EdytujKontoKlienta(klient);
                    MessageBox.Show("Dane zostały zaktualizowane", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zaktualizować danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

}
