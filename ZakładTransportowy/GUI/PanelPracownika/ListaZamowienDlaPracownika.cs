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
    public partial class ListaZamowienDlaPracownika : Form
    {
        Pracownik pracownik;
        IList<WidokZamowienie> zamowienia = new List<WidokZamowienie>();
        public ListaZamowienDlaPracownika(Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
            zamowienia = BazaDanych.ListaZamowien();
            bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
            dgvZamowienia.DataSource = bsZamowienia;
        }

        private void btOplacZamowienie_Click(object sender, EventArgs e)
        {
            if(zamowienia.Count != 0)
            {
                int zamowienieID = Convert.ToInt32(dgvZamowienia.CurrentRow.Cells["IdKolumna"].Value);
                String oplacone = BazaDanych.SprawdzCzyOplacone(BazaDanych.WyszukajZamowienie(zamowienieID));
                if (oplacone == "TAK")
                {
                    MessageBox.Show("Zamówienie jest już opłacone", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        RozliczenieZamowienia myform = new RozliczenieZamowienia(BazaDanych.WyszukajZamowienie(zamowienieID), pracownik);
                        myform.ShowDialog();
                        BazaDanych.ZmienStatusOplacenia(BazaDanych.WyszukajZamowienie(zamowienieID));
                        MessageBox.Show("Zamówienie zostało opłacone", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        zamowienia = BazaDanych.ListaZamowien();
                        bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
                        dgvZamowienia.DataSource = bsZamowienia;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się opłacić zamówienia", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Lista zamówień jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btEdytujZamowienie_Click(object sender, EventArgs e)
        {
            if(zamowienia.Count != 0)
            {
                int zamowienieID = Convert.ToInt32(dgvZamowienia.CurrentRow.Cells["IdKolumna"].Value);
                Zamowienie zamowienie = BazaDanych.WyszukajZamowienie(zamowienieID);
                WybierzDate myform = new WybierzDate(zamowienie);
                myform.ShowDialog();
                zamowienia = BazaDanych.ListaZamowien();
                bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
                dgvZamowienia.DataSource = bsZamowienia;
            }
            else
            {
                MessageBox.Show("Lista zamówień jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btUsunZamowienie_Click(object sender, EventArgs e)
        {
            if(zamowienia.Count != 0)
            {
                int zamowienieID = Convert.ToInt32(dgvZamowienia.CurrentRow.Cells["IdKolumna"].Value);
                try
                {
                    BazaDanych.UsunZamowienie(BazaDanych.WyszukajZamowienie(zamowienieID));
                    MessageBox.Show("Zamówienie zostało usunięte", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zamowienia = BazaDanych.ListaZamowien();
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
                MessageBox.Show("Lista zamówień jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btDodajZamowienie_Click(object sender, EventArgs e)
        {
            DodawanieZamowienia myform = new DodawanieZamowienia();
            myform.ShowDialog();
            zamowienia = BazaDanych.ListaZamowien();
            bsZamowienia.DataSource = new BindingList<WidokZamowienie>(zamowienia);
            dgvZamowienia.DataSource = bsZamowienia;
        }
    }
}
