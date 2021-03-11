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
    public partial class Pojazdy : Form
    {
        IList<Pojazd> pojazdy = new List<Pojazd>();

        public Pojazdy()
        {
            InitializeComponent();
            pojazdy = BazaDanych.ListaPojazdow();
            bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazd;
        }

        private void btnUsunPojazd_Click(object sender, EventArgs e)
        {
            if(pojazdy.Count != 0)
            {
                int pojazdID = Convert.ToInt32(dgvPojazdy.CurrentRow.Cells["dgvIDPojazd"].Value);

                try
                {
                    BazaDanych.UsunPojazd(BazaDanych.WyszukajPojazd(pojazdID));
                    MessageBox.Show("Udało się usunąć pojazd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pojazdy = BazaDanych.ListaPojazdow();
                    bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
                    dgvPojazdy.DataSource = bsPojazd;

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się usunąć pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista pojazdów jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnDodajPojazd_Click(object sender, EventArgs e)
        {
            DodawaniePojazdu d = new DodawaniePojazdu();
            d.ShowDialog();
            pojazdy = BazaDanych.ListaPojazdow();
            bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazd;
        }
    }
}
