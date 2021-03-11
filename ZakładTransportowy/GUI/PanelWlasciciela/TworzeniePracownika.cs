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
    public partial class TworzeniePracownika : Form
    {
        String imie;
        String nazwisko;
        String login;
        String haslo;
        String pensja;
        String numer;
        String mail;
        String stanowisko;
        List<String> uprawnienia = new List<String>();
        Pracownik pracownik;
        
        public TworzeniePracownika(Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
            PojazdyLabel.Visible = false;
            BusIcon.Visible = false;
            TirIcon.Visible = false;
            CiezarowkaIcon.Visible = false;
            OsobowkaIcon.Visible = false;
            CysternaIcon.Visible = false;
            loginText.Visible = false;
            imieText.Text = pracownik.imie;
            nazwiskoText.Text = pracownik.nazwisko;
            loginLabel.Text = pracownik.login;
            hasloText.Text = pracownik.haslo;
            pensjaText.Text = pracownik.pensja.ToString();
            numerTelefonuText.Text = pracownik.kontakt.numerTelefonu;
            eMailText.Text = pracownik.kontakt.email;
            comboBox1.Text = pracownik.uprawnienia;
        }
        public TworzeniePracownika()
        {
            InitializeComponent();
            PojazdyLabel.Visible = false;
            BusIcon.Visible = false;
            TirIcon.Visible = false;
            CiezarowkaIcon.Visible = false;
            OsobowkaIcon.Visible = false;
            CysternaIcon.Visible = false;
            loginLabel.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stanowisko = comboBox1.Text;
            if(stanowisko == "KIEROWCA" && pracownik == null)
            {
                PojazdyLabel.Visible = true;
                BusIcon.Visible = true;
                TirIcon.Visible = true;
                CiezarowkaIcon.Visible = true;
                OsobowkaIcon.Visible = true;
                CysternaIcon.Visible = true;
            }
            else
            {
                PojazdyLabel.Visible = false;
                BusIcon.Visible = false;
                TirIcon.Visible = false;
                CiezarowkaIcon.Visible = false;
                OsobowkaIcon.Visible = false;
                CysternaIcon.Visible = false;
            }
        }

        private void imieText_TextChanged(object sender, EventArgs e)
        {
            imie = imieText.Text;
        }

        private void nazwiskoText_TextChanged(object sender, EventArgs e)
        {
            nazwisko = nazwiskoText.Text;
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {
            login = loginText.Text;
        }

        private void hasloText_TextChanged(object sender, EventArgs e)
        {
            haslo = hasloText.Text;
        }

        private void pensjaText_TextChanged(object sender, EventArgs e)
        {
            pensja = pensjaText.Text;
        }

        private void numerTelefonuText_TextChanged(object sender, EventArgs e)
        {
            numer = numerTelefonuText.Text;
        }

        private void eMailText_TextChanged(object sender, EventArgs e)
        {
            mail = eMailText.Text;
        }

        private void BusIcon_CheckedChanged(object sender, EventArgs e)
        {
            uprawnienia.Add(BusIcon.Text);
        }

        private void TirIcon_CheckedChanged(object sender, EventArgs e)
        {
            uprawnienia.Add(TirIcon.Text);
        }

        private void CiezarowkaIcon_CheckedChanged(object sender, EventArgs e)
        {
            uprawnienia.Add(CiezarowkaIcon.Text);
        }

        private void OsobowkaIcon_CheckedChanged(object sender, EventArgs e)
        {
            uprawnienia.Add(OsobowkaIcon.Text);
        }

        private void CysternaIcon_CheckedChanged(object sender, EventArgs e)
        {
            uprawnienia.Add(CysternaIcon.Text);
        }


        private void OK_Click(object sender, EventArgs e)
        {
            if(pracownik == null)
            {
                try{
                    Pracownik pracownik = new Pracownik(numer, mail, 2, imie, nazwisko, login, haslo, stanowisko, Int32.Parse(pensja), DateTime.Now);
                    BazaDanych.DodajKontoPracownika(pracownik, uprawnienia);
                    MessageBox.Show("Konto zostało utworzone! LOGIN:" + login + " Hasło:" + haslo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } catch (Exception)
                {
                    MessageBox.Show("Błędnie wprowadzone dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pracownik.imie = imie;
                pracownik.nazwisko = nazwisko;
                pracownik.pensja = Int32.Parse(pensja);
                pracownik.haslo = haslo;
                pracownik.kontakt.email = mail;
                pracownik.kontakt.numerTelefonu = numer;
                pracownik.uprawnienia = stanowisko;
                try
                {
                    BazaDanych.EdytujKontoPracownika(pracownik);
                    MessageBox.Show("Dane zostały zaktualizowane", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                } catch (Exception)
                {
                    MessageBox.Show("Nie udało się zaktualizować danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
