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
    public partial class EdytujPojazd : Form
    {
        Pojazd pojazd;
        DateTime data_przegladu;
        string stan_techniczny;
        public EdytujPojazd(Pojazd pojazd)
        { 
            InitializeComponent();
            this.pojazd = pojazd;
            lbID.Text = pojazd.idPojazd.ToString();
            lbNumerRejestracyjny.Text = pojazd.numerRejestracyjny;
            lbRodzaj.Text = pojazd.rodzaj;
            dtpDataPrzegladu.Value = pojazd.dataOstatneigoPrzegladu;
            cbStanTechniczny.Text = pojazd.stanTechniczny;
            
        }

        private void dtpDataPrzegladu_ValueChanged(object sender, EventArgs e)
        {
            data_przegladu = dtpDataPrzegladu.Value;
        }

        private void cbStanTechniczny_SelectedIndexChanged(object sender, EventArgs e)
        {
            stan_techniczny = cbStanTechniczny.Text;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                BazaDanych.ZmienStatusPojazdu(pojazd, stan_techniczny, data_przegladu);
                MessageBox.Show("Dane zostały zaktualizowane.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception)
            {
                MessageBox.Show("Nie udało się zaktualizować danych.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
