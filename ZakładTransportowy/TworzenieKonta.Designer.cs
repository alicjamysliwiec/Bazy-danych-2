
namespace ZakładTransportowy
{
    partial class TworzenieKonta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.llll = new System.Windows.Forms.Label();
            this.lllll = new System.Windows.Forms.Label();
            this.RodzajKlienta = new System.Windows.Forms.ComboBox();
            this.llllll = new System.Windows.Forms.Label();
            this.lllllll = new System.Windows.Forms.Label();
            this.imiee = new System.Windows.Forms.TextBox();
            this.nazwiskoo = new System.Windows.Forms.TextBox();
            this.loginn = new System.Windows.Forms.TextBox();
            this.hasloo = new System.Windows.Forms.TextBox();
            this.nipp = new System.Windows.Forms.TextBox();
            this.NazwaFirmy = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.numerTelefonu = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.llllllll = new System.Windows.Forms.Label();
            this.lllllllll = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.informacja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(91, 25);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(33, 17);
            this.l.TabIndex = 0;
            this.l.Text = "Imię";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(57, 66);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(67, 17);
            this.ll.TabIndex = 1;
            this.ll.Text = "Nazwisko";
            // 
            // lll
            // 
            this.lll.AutoSize = true;
            this.lll.Location = new System.Drawing.Point(81, 107);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(43, 17);
            this.lll.TabIndex = 2;
            this.lll.Text = "Login";
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.Location = new System.Drawing.Point(80, 150);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(44, 17);
            this.llll.TabIndex = 3;
            this.llll.Text = "Hasło";
            // 
            // lllll
            // 
            this.lllll.AutoSize = true;
            this.lllll.Location = new System.Drawing.Point(19, 194);
            this.lllll.Name = "lllll";
            this.lllll.Size = new System.Drawing.Size(105, 17);
            this.lllll.TabIndex = 4;
            this.lllll.Text = "Numer telefonu";
            // 
            // RodzajKlienta
            // 
            this.RodzajKlienta.FormattingEnabled = true;
            this.RodzajKlienta.Items.AddRange(new object[] {
            "OSOBA_FIZYCZNA",
            "FIRMA"});
            this.RodzajKlienta.Location = new System.Drawing.Point(143, 277);
            this.RodzajKlienta.Name = "RodzajKlienta";
            this.RodzajKlienta.Size = new System.Drawing.Size(189, 24);
            this.RodzajKlienta.TabIndex = 6;
            this.RodzajKlienta.SelectedIndexChanged += new System.EventHandler(this.RodzajKlienta_SelectedIndexChanged);
            // 
            // llllll
            // 
            this.llllll.AutoSize = true;
            this.llllll.Location = new System.Drawing.Point(76, 236);
            this.llllll.Name = "llllll";
            this.llllll.Size = new System.Drawing.Size(47, 17);
            this.llllll.TabIndex = 7;
            this.llllll.Text = "E-mail";
            this.llllll.Click += new System.EventHandler(this.label6_Click);
            // 
            // lllllll
            // 
            this.lllllll.AutoSize = true;
            this.lllllll.Location = new System.Drawing.Point(27, 280);
            this.lllllll.Name = "lllllll";
            this.lllllll.Size = new System.Drawing.Size(97, 17);
            this.lllllll.TabIndex = 8;
            this.lllllll.Text = "Rodzaj klienta";
            // 
            // imiee
            // 
            this.imiee.Location = new System.Drawing.Point(143, 22);
            this.imiee.Name = "imiee";
            this.imiee.Size = new System.Drawing.Size(189, 22);
            this.imiee.TabIndex = 9;
            this.imiee.TextChanged += new System.EventHandler(this.imie_TextChanged);
            // 
            // nazwiskoo
            // 
            this.nazwiskoo.Location = new System.Drawing.Point(143, 63);
            this.nazwiskoo.Name = "nazwiskoo";
            this.nazwiskoo.Size = new System.Drawing.Size(189, 22);
            this.nazwiskoo.TabIndex = 10;
            this.nazwiskoo.TextChanged += new System.EventHandler(this.nazwiskoo_TextChanged);
            // 
            // loginn
            // 
            this.loginn.Location = new System.Drawing.Point(143, 104);
            this.loginn.Name = "loginn";
            this.loginn.Size = new System.Drawing.Size(189, 22);
            this.loginn.TabIndex = 11;
            this.loginn.TextChanged += new System.EventHandler(this.loginn_TextChanged);
            // 
            // hasloo
            // 
            this.hasloo.Location = new System.Drawing.Point(143, 147);
            this.hasloo.Name = "hasloo";
            this.hasloo.Size = new System.Drawing.Size(189, 22);
            this.hasloo.TabIndex = 12;
            this.hasloo.TextChanged += new System.EventHandler(this.hasloo_TextChanged);
            // 
            // nipp
            // 
            this.nipp.Location = new System.Drawing.Point(143, 368);
            this.nipp.Name = "nipp";
            this.nipp.Size = new System.Drawing.Size(189, 22);
            this.nipp.TabIndex = 13;
            this.nipp.TextChanged += new System.EventHandler(this.nipp_TextChanged);
            // 
            // NazwaFirmy
            // 
            this.NazwaFirmy.Location = new System.Drawing.Point(143, 323);
            this.NazwaFirmy.Name = "NazwaFirmy";
            this.NazwaFirmy.Size = new System.Drawing.Size(189, 22);
            this.NazwaFirmy.TabIndex = 14;
            this.NazwaFirmy.TextChanged += new System.EventHandler(this.NazwaFirmy_TextChanged);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(143, 422);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(99, 47);
            this.ok.TabIndex = 15;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // numerTelefonu
            // 
            this.numerTelefonu.Location = new System.Drawing.Point(143, 191);
            this.numerTelefonu.Name = "numerTelefonu";
            this.numerTelefonu.Size = new System.Drawing.Size(189, 22);
            this.numerTelefonu.TabIndex = 16;
            this.numerTelefonu.TextChanged += new System.EventHandler(this.numerTelefonu_TextChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(143, 233);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(189, 22);
            this.mail.TabIndex = 17;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // llllllll
            // 
            this.llllllll.AutoSize = true;
            this.llllllll.Location = new System.Drawing.Point(40, 326);
            this.llllllll.Name = "llllllll";
            this.llllllll.Size = new System.Drawing.Size(84, 17);
            this.llllllll.TabIndex = 18;
            this.llllllll.Text = "Nazwa firmy";
            // 
            // lllllllll
            // 
            this.lllllllll.AutoSize = true;
            this.lllllllll.Location = new System.Drawing.Point(94, 371);
            this.lllllllll.Name = "lllllllll";
            this.lllllllll.Size = new System.Drawing.Size(30, 17);
            this.lllllllll.TabIndex = 19;
            this.lllllllll.Text = "NIP";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(173, 517);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            this.info.TabIndex = 20;
            // 
            // informacja
            // 
            this.informacja.AutoSize = true;
            this.informacja.Location = new System.Drawing.Point(40, 517);
            this.informacja.Name = "informacja";
            this.informacja.Size = new System.Drawing.Size(73, 17);
            this.informacja.TabIndex = 21;
            this.informacja.Text = "Informacja";
            // 
            // TworzenieKonta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 553);
            this.Controls.Add(this.informacja);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lllllllll);
            this.Controls.Add(this.llllllll);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.numerTelefonu);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.NazwaFirmy);
            this.Controls.Add(this.nipp);
            this.Controls.Add(this.hasloo);
            this.Controls.Add(this.loginn);
            this.Controls.Add(this.nazwiskoo);
            this.Controls.Add(this.imiee);
            this.Controls.Add(this.lllllll);
            this.Controls.Add(this.llllll);
            this.Controls.Add(this.RodzajKlienta);
            this.Controls.Add(this.lllll);
            this.Controls.Add(this.llll);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.l);
            this.Name = "TworzenieKonta";
            this.Text = "Utwórz konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Label lll;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.Label lllll;
        private System.Windows.Forms.ComboBox RodzajKlienta;
        private System.Windows.Forms.Label llllll;
        private System.Windows.Forms.Label lllllll;
        private System.Windows.Forms.TextBox imiee;
        private System.Windows.Forms.TextBox nazwiskoo;
        private System.Windows.Forms.TextBox loginn;
        private System.Windows.Forms.TextBox hasloo;
        private System.Windows.Forms.TextBox nipp;
        private System.Windows.Forms.TextBox NazwaFirmy;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox numerTelefonu;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label llllllll;
        private System.Windows.Forms.Label lllllllll;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label informacja;
    }
}