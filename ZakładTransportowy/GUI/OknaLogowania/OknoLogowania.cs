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
    public partial class OknoLogowania : Form
    {
        public OknoLogowania()
        {
            InitializeComponent();

        }

        private void Przycisk_Click(object sender, EventArgs e)
        {
            PanelKlienta p = new PanelKlienta();
            p.ShowDialog();
        }


        private void btnKlient_Click(object sender, EventArgs e)
        {
            BazaDanych.Wyloguj();
            this.pOkno.Controls.Clear();
            PanelKlienta myForm = new PanelKlienta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnPracownik_Click(object sender, EventArgs e)
        {
            BazaDanych.Wyloguj();
            this.pOkno.Controls.Clear();
            LogowaniePracownika myForm = new LogowaniePracownika() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnWlasciciel_Click(object sender, EventArgs e)
        {
            BazaDanych.Wyloguj();
            this.pOkno.Controls.Clear();
            LogowanieWlasciciela myForm = new LogowanieWlasciciela() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void pOkno_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
