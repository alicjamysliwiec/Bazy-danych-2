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
    public partial class PrzegladanieZamowien : Form
    {
        Klient klient;
        IList<WidokZamowienie> zamowienia;
        public PrzegladanieZamowien(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
            zamowienia = BazaDanych.ListaZamowienDlaKlienta(klient);
            bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
            dgvZamowienia.DataSource = bsZamowienia;
        }

        private void PrzegladanieZamowien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ZamowieniaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDodajZamowienie_Click(object sender, EventArgs e)
        {
            DodawanieZamowienia myform = new DodawanieZamowienia(klient);
            myform.ShowDialog();
            zamowienia = BazaDanych.ListaZamowienDlaKlienta(klient);
            bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
            dgvZamowienia.DataSource = bsZamowienia;
        }

        private void btAnulujZamowienie_Click(object sender, EventArgs e)
        {
            if(zamowienia.Count != 0)
            {
                int zamowienieID = Convert.ToInt32(dgvZamowienia.CurrentRow.Cells["IdZamowienieKolumna"].Value);
                try
                {
                    BazaDanych.UsunZamowienie(BazaDanych.WyszukajZamowienie(zamowienieID));
                    MessageBox.Show("Zamówienie zostało usunięte", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zamowienia = BazaDanych.ListaZamowienDlaKlienta(klient);
                    bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
                    dgvZamowienia.DataSource = bsZamowienia;

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się usunąć zamówienia", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie posiadasz zamówień", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
