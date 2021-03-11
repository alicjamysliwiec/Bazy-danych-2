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
    public partial class PanelKlienta : Form
    {
        public PanelKlienta()
        {
            InitializeComponent();
        }

        private void btnZalogowanie_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            LogowanieKlienta myForm = new LogowanieKlienta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnTworzenieKonta_Click(object sender, EventArgs e)
        {
            this.pOkno.Controls.Clear();
            TworzenieKontaKlienta myForm = new TworzenieKontaKlienta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pOkno.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
