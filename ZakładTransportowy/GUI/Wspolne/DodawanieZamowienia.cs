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
    public partial class DodawanieZamowienia : Form
    {
        IList<Pojazd> pojazdy = new List<Pojazd>();
        int idKlienta;
        decimal cena;
        Klient klient;
        Pojazd pojazd;
        DateTime data;
        String conncectionName = BazaDanych.getConnectionName();
        

        public DodawanieZamowienia(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
            cenaLabel.Visible = true;
            CenaText.Visible = false;
            cenaLabel.Text = "Wybierz pojazd";
            pojazdy = BazaDanych.ListaSprawnychPojazdow();
            bsPojazdy.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazdy;
            IdKlientaText.Visible = false;
            idKlientaLabel.Visible = true;
            idKlientaLabel.Text = klient.idKlient.ToString();
        }
        public DodawanieZamowienia()
        {
            InitializeComponent();
            pojazdy = BazaDanych.ListaSprawnychPojazdow();
            bsPojazdy.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazdy;
            cenaLabel.Visible = false;
            CenaText.Visible = true;
            IdKlientaText.Visible = true;
            idKlientaLabel.Visible = false;

        }

        private void IdKlientaText_TextChanged(object sender, EventArgs e)
        {
            if(conncectionName != "Klient")
            {
                bool sukces = Int32.TryParse(IdKlientaText.Text, out idKlienta);
            }
        }

        private void CenaText_TextChanged(object sender, EventArgs e)
        {
            if(conncectionName != "Klient")
            {
                bool sukces = decimal.TryParse(CenaText.Text, out cena);
            }     
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            data = monthCalendar1.SelectionStart;
        }
        private void dgvPojazdy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pojazdID = Convert.ToInt32(dgvPojazdy.CurrentRow.Cells["IdPojazdKolumna"].Value);
            pojazd = BazaDanych.WyszukajPojazd(pojazdID);
            if (pojazd.rodzaj == "OSOBÓWKA")
            {
                cenaLabel.Text = "200";
            }
            else if (pojazd.rodzaj == "CIĘŻARÓWKA")
            {
                cenaLabel.Text = "500";
            }
            else if (pojazd.rodzaj == "CYSTERNA")
            {
                cenaLabel.Text = "1000";
            }
            else if (pojazd.rodzaj == "BUS")
            {
                cenaLabel.Text = "350";
            }
            else
            {
                cenaLabel.Text = "670";
            }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            int pojazdID = Convert.ToInt32(dgvPojazdy.CurrentRow.Cells["IdPojazdKolumna"].Value);
            pojazd = BazaDanych.WyszukajPojazd(pojazdID);

            if (conncectionName == "Klient")
            {
                bool sukces = decimal.TryParse(cenaLabel.Text, out cena);

            }

            if(conncectionName == "Klient")
            {
                bool sukces = Int32.TryParse(idKlientaLabel.Text, out idKlienta);
            }
            
            try
            {
                klient = BazaDanych.WyszukajKlienta(idKlienta);
                Zamowienie zamowienie = new Zamowienie(klient, pojazd, "ZLOZONO", DateTime.Now, data, cena, "NIE");
                BazaDanych.DodajZamowienie(zamowienie);
                MessageBox.Show("Zamówienie zostało dodane!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać zamówienia", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
