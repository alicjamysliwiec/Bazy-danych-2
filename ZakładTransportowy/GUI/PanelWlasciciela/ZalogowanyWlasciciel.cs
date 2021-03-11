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
    public partial class ZalogowanyWlasciciel : Form
    {
        public ZalogowanyWlasciciel()
        {
            InitializeComponent();
        }

        private void Pracownicy_Click(object sender, EventArgs e)
        {
            Pracownicy p = new Pracownicy();
            p.ShowDialog();
        }


        private void btnPojazdy_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            Pojazdy myForm = new Pojazdy() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_Pojazdy_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            Statystyki myForm = new Statystyki() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            Pracownicy myForm = new Pracownicy() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
