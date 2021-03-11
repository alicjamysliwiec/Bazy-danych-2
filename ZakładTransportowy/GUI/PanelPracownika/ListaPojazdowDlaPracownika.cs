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

    public partial class ListaPojazdowDlaPracownika : Form
    {
        IList<Pojazd> pojazdy = new List<Pojazd>();
        Pojazd pojazd;

        public ListaPojazdowDlaPracownika()
        {
            InitializeComponent();
            pojazdy = BazaDanych.ListaPojazdow();
            bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazd ;
        }

        private void btnDodajPojazd_Click(object sender, EventArgs e)
        {
            DodawaniePojazdu d = new DodawaniePojazdu();
            d.ShowDialog();
            pojazdy = BazaDanych.ListaPojazdow();
            bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
            dgvPojazdy.DataSource = bsPojazd;
        }

        private void btModyfikuj_Click(object sender, EventArgs e)
        {
            if(pojazdy.Count != 0)
            {
                int pojazdID = Convert.ToInt32(dgvPojazdy.CurrentRow.Cells["dgvIDPojazd"].Value);
                pojazd = BazaDanych.WyszukajPojazd(pojazdID);
                EdytujPojazd myform = new EdytujPojazd(pojazd);
                myform.ShowDialog();
                pojazdy = BazaDanych.ListaPojazdow();
                bsPojazd.DataSource = new BindingList<Pojazd>(pojazdy);
                dgvPojazdy.DataSource = bsPojazd;
            }
            else
            {
                       
                MessageBox.Show("Lista pojazdów jest pusta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
