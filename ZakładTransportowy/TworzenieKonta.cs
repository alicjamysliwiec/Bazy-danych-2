using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakładTransportowy
{
    public partial class TworzenieKonta : Form
    {
        Klient klient;
        Kontakt kontakt;
        String imie;
        String nazwisko;
        String login;
        String haslo;
        String rodzaj_klienta;
        String numer_telefonu;
        String email;
        String nazwa_firmy;
        String nip;

        public TworzenieKonta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void imie_TextChanged(object sender, EventArgs e)
        {
            imie = imiee.Text;
        }

        private void nazwiskoo_TextChanged(object sender, EventArgs e)
        {
            nazwisko = nazwiskoo.Text;
        }

        private void loginn_TextChanged(object sender, EventArgs e)
        {
            login = loginn.Text;
        }

        private void hasloo_TextChanged(object sender, EventArgs e)
        {
            haslo = hasloo.Text;
        }

        private void numerTelefonu_TextChanged(object sender, EventArgs e)
        {
            numer_telefonu = numerTelefonu.Text;
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {
            email = mail.Text;
        }

        private void RodzajKlienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzaj_klienta = RodzajKlienta.Text;
        }

        private void NazwaFirmy_TextChanged(object sender, EventArgs e)
        {
            nazwa_firmy = NazwaFirmy.Text;
        }

        private void nipp_TextChanged(object sender, EventArgs e)
        {
            nip = nipp.Text;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //jezeli dane zostaly dobrze wprowadzone to:
            informacja.Text = "Konto zostało utworzone! Zaloguj się za pomocą loginu i hasła :)";
            klient = new Klient(numer_telefonu, email, imie, nazwisko, login, haslo, DateTime.Now, rodzaj_klienta, nazwa_firmy, nip);
            BazaDanych.DodajKontoKlienta(klient);

            //a jezeli nie:
            //informacja.Text = "Dane zostały niepoprawnie wprowadzone";

        }
    }
}
