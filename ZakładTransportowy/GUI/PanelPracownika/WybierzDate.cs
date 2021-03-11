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
    public partial class WybierzDate : Form
    {
        Zamowienie zamowienie;
        DateTime data;
        public WybierzDate(Zamowienie zamowienie)
        {
            InitializeComponent();
            this.zamowienie = zamowienie;
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            data = monthCalendar1.SelectionStart;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                BazaDanych.ZmienDate(zamowienie, data);
                MessageBox.Show("Data realizacji została zmieniona", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
