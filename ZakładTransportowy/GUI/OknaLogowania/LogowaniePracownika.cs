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
    public partial class LogowaniePracownika : Form
    {
        Pracownik pracownik;
        String login;
        String haslo;

        public LogowaniePracownika()
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
            try
            {
                pracownik = BazaDanych.LogowaniePracownik(login, haslo);
                if (pracownik == null)
                {
                    MessageBox.Show("Niepoprawne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ZalogowanyPracownik z = new ZalogowanyPracownik(pracownik);
                    z.ShowDialog();
                }

            } catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
