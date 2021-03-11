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
    public partial class ZalogowanyKlient : Form
    {
        Klient klient;

        public ZalogowanyKlient(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
            ZalogowanyUzytkownik.Text = "Użytkownik: " + klient.imie + " " + klient.nazwisko;
            IdklientaLabel.Text = "ID klienta: " + klient.idKlient.ToString();
        }




        private void ZalogowanyUzytkownik_Click(object sender, EventArgs e)
        {

        }

        private void btZamowienia_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            PrzegladanieZamowien myForm = new PrzegladanieZamowien(klient) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btTwojeDane_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            TworzenieKontaKlienta myForm = new TworzenieKontaKlienta(klient) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
