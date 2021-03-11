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
    public partial class Statystyki : Form
    {
        public Statystyki()
        {
            InitializeComponent();
            if(BazaDanych.dochodDnia() == null)
            {
                lbDochodDnia.Text = "0";
            }
            else
            {
                lbDochodDnia.Text = BazaDanych.dochodDnia();
            }
            lbDochod.Text = BazaDanych.dochodCalkowity();
            lbSrednieZarobki.Text = BazaDanych.SrednieZarobki();
            lbSprawnepojazdy.Text = BazaDanych.IleSprawnychPojazdow().ToString();
        }
    }
}
