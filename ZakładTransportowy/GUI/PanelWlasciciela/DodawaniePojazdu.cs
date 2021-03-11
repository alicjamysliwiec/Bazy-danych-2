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
    public partial class DodawaniePojazdu : Form
    {
        Pojazd pojazd;
        string numer_rejestracyjny;
        string rodzaj;

        public DodawaniePojazdu()
        {
            InitializeComponent();
        }

        private void tbNumerRejestracyjny_TextChanged(object sender, EventArgs e)
        {
            numer_rejestracyjny = tbNumerRejestracyjny.Text;
        }

        private void cbRodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzaj = cbRodzaj.Text;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                pojazd = new Pojazd(numer_rejestracyjny, rodzaj, DateTime.Now, "SPRAWNY");
                BazaDanych.DodajPojazd(pojazd);
                MessageBox.Show("Pojazd został dodany", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać pojazdu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
