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
    public partial class Pracownicy : Form
    {
        IList<WidokPracownik> pracownicy = new List<WidokPracownik>();

        public Pracownicy()

        {
            InitializeComponent();
            pracownicy = BazaDanych.ListaPracownikow();
            bsPracownicy.DataSource = new BindingList<WidokPracownik>(pracownicy);
            dgvPracownicy.DataSource = bsPracownicy;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDodajPracownika_Click(object sender, EventArgs e)
        {
            TworzeniePracownika myform = new TworzeniePracownika();
            myform.ShowDialog();
            pracownicy = BazaDanych.ListaPracownikow();
            bsPracownicy.DataSource = new BindingList<WidokPracownik>(pracownicy);
            dgvPracownicy.DataSource = bsPracownicy;
        }

        private void btUsunPracownika_Click(object sender, EventArgs e)
        {
            if(pracownicy.Count != 0)
            {
                int pracownikID = Convert.ToInt32(dgvPracownicy.CurrentRow.Cells["IdPracownikKolumna"].Value);

                try
                {
                    BazaDanych.UsunKontoPracownika(BazaDanych.WyszukajPracownika(pracownikID));
                    MessageBox.Show("Udało się usunąć kontro pracownika.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pracownicy = BazaDanych.ListaPracownikow();
                    bsPracownicy.DataSource = new BindingList<WidokPracownik>(pracownicy);
                    dgvPracownicy.DataSource = bsPracownicy;

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się usunąć konta pracownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista pracowników jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModyfikujDane_Click(object sender, EventArgs e)
        {
            if(pracownicy.Count != 0)
            {
                int pracownikID = Convert.ToInt32(dgvPracownicy.CurrentRow.Cells["IdPracownikKolumna"].Value);
                Pracownik pracownik = BazaDanych.WyszukajPracownika(pracownikID);
                TworzeniePracownika myform = new TworzeniePracownika(pracownik);
                myform.ShowDialog();
                pracownicy = BazaDanych.ListaPracownikow();
                bsPracownicy.DataSource = new BindingList<WidokPracownik>(pracownicy);
                dgvPracownicy.DataSource = bsPracownicy;
            }
            else
            {
                MessageBox.Show("Lista pracowników jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
