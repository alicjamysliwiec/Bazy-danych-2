using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZakładTransportowy.Dostep_do_danych.ModeleDanych;

namespace ZakładTransportowy.GUI.PanelPracownika
{
    public partial class ListaKlientow : Form
    {
        IList<WidokKlient> klienci = new List<WidokKlient>();
        public ListaKlientow()
        {
            InitializeComponent();
            klienci = BazaDanych.ListaKlientow();
            bsKlienci.DataSource = new BindingList<WidokKlient>(klienci);
            dgvKlienci.DataSource = bsKlienci;
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            TworzenieKontaKlienta myform = new TworzenieKontaKlienta();
            myform.ShowDialog();
            klienci = BazaDanych.ListaKlientow();
            bsKlienci.DataSource = new BindingList<WidokKlient>(klienci);
            dgvKlienci.DataSource = bsKlienci;
        }

        private void btnUsunKlienta_Click(object sender, EventArgs e)
        {
            if(klienci.Count !=0)
            {
                try
                {
                    int klientId = Convert.ToInt32(dgvKlienci.CurrentRow.Cells["IdKlientKolumna"].Value);
                    BazaDanych.UsunKontoKlienta(BazaDanych.WyszukajKlienta(klientId));
                    MessageBox.Show("Udało się usunąć konto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    klienci = BazaDanych.ListaKlientow();
                    bsKlienci.DataSource = new BindingList<WidokKlient>(klienci);
                    dgvKlienci.DataSource = bsKlienci;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się usunąć konta", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista klientów jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModyfikujDane_Click(object sender, EventArgs e)
        {
            if(klienci.Count != 0)
            {
                int klientId = Convert.ToInt32(dgvKlienci.CurrentRow.Cells["IdKlientKolumna"].Value);
                Klient klient = BazaDanych.WyszukajKlienta(klientId);
                TworzenieKontaKlienta myform = new TworzenieKontaKlienta(klient);
                myform.ShowDialog();
                klienci = BazaDanych.ListaKlientow();
                bsKlienci.DataSource = new BindingList<WidokKlient>(klienci);
                dgvKlienci.DataSource = bsKlienci;
            }
            else
            {
                MessageBox.Show("Lista klientów jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
