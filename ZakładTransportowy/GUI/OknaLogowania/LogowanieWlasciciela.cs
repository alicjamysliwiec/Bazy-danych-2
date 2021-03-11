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
    public partial class LogowanieWlasciciela : Form
    {
        bool logowanie;
        String login;
        String haslo;

        public LogowanieWlasciciela()
        {
            InitializeComponent();
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {
            login = loginText.Text;
        }

        private void hasloText_TextChanged(object sender, EventArgs e)
        {
            haslo = hasloText.Text;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            logowanie = BazaDanych.LogowanieWlasciciel(login, haslo);
            if (!logowanie)
            {
                MessageBox.Show("Nie udało się zalogować.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                ZalogowanyWlasciciel z = new ZalogowanyWlasciciel();
                z.ShowDialog();
            }
        }
    }
}
