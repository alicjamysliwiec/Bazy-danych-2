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
    public partial class WyszukajZamowienie : Form

    {
        Zamowienie zamowienie;
        int id_zamowienia;
        public WyszukajZamowienie()
        {
            InitializeComponent();
        }

        private void WyszukajZamowienie_Load(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            id_zamowienia = Int32.Parse(ID.Text);
            zamowienie = BazaDanych.WyszukajZamowienie(id_zamowienia);
            //Wyswietlenie tego zamowienie mozna kazda wartosc w osobnym TextBox, ale nie wiem czy to optymalne ;)
        }
    }
}
