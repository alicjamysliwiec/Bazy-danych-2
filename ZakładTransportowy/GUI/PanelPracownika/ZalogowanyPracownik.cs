using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZakładTransportowy.GUI.PanelPracownika;

namespace ZakładTransportowy
{
    public partial class ZalogowanyPracownik : Form
    {
        Pracownik pracownik;
        public ZalogowanyPracownik()
        {
            InitializeComponent();
        }

        public ZalogowanyPracownik(Pracownik pracownik)
        {          
            InitializeComponent();
            this.pracownik = pracownik;
            label1.Text = "Pracownik: " + pracownik.imie + " " + pracownik.nazwisko;
            label2.Text = "ID: " + pracownik.idPracownik.ToString();

        }

        private void ZalogowanyPracownik_Load(object sender, EventArgs e)
        {

        }

        private void Klienci_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            ListaKlientow myForm = new ListaKlientow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void Pojazdy_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            ListaPojazdowDlaPracownika myForm = new ListaPojazdowDlaPracownika() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void Zamowienia_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            ListaZamowienDlaPracownika myForm = new ListaZamowienDlaPracownika(pracownik) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

    }
}
