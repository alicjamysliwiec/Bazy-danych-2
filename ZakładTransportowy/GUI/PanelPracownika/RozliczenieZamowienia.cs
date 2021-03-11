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
    public partial class RozliczenieZamowienia : Form
    {
        Pracownik pracownik;
        Zamowienie zamowienie;
        String forma_rozliczenia;
        String forma_platnosci;
        
        public RozliczenieZamowienia(Zamowienie zamowienie, Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
            this.zamowienie = zamowienie;
        }

        private void cbFormaPlatnosci_SelectedIndexChanged(object sender, EventArgs e)
        {
            forma_platnosci = cbFormaPlatnosci.Text;
        }

        private void cbFormaRozliczenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            forma_rozliczenia = cbFormaRozliczenia.Text;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            BazaDanych.RozliczZamowienie(zamowienie, forma_rozliczenia, forma_platnosci, pracownik);
            this.Close();
        }
    }
}
