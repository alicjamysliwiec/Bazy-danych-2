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
    public partial class LogowanieKlienta : Form
    {
        public Klient klient { get; set; }
        String login;
        String haslo;

        public LogowanieKlienta()
        {
            InitializeComponent();
           
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            login = Login.Text;
        }

        private void Haslo_TextChanged(object sender, EventArgs e)
        {
            haslo = Haslo.Text;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                klient = BazaDanych.LogowanieKlient(login, haslo);
                if (klient == null)
                {
                    MessageBox.Show("Niepoprawne dane!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ZalogowanyKlient z = new ZalogowanyKlient(klient);
                    z.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

    }
}
