
namespace ZakładTransportowy.GUI.PanelPracownika
{
    partial class ListaKlientow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKlientow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModyfikujDane = new System.Windows.Forms.Button();
            this.btnUsunKlienta = new System.Windows.Forms.Button();
            this.btnDodajKlienta = new System.Windows.Forms.Button();
            this.dgvKlienci = new System.Windows.Forms.DataGridView();
            this.IdKlientKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKontaktKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImieKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsKlienci = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvKlienci, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModyfikujDane);
            this.panel1.Controls.Add(this.btnUsunKlienta);
            this.panel1.Controls.Add(this.btnDodajKlienta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnModyfikujDane
            // 
            this.btnModyfikujDane.BackColor = System.Drawing.Color.White;
            this.btnModyfikujDane.Image = ((System.Drawing.Image)(resources.GetObject("btnModyfikujDane.Image")));
            this.btnModyfikujDane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModyfikujDane.Location = new System.Drawing.Point(369, 3);
            this.btnModyfikujDane.Name = "btnModyfikujDane";
            this.btnModyfikujDane.Size = new System.Drawing.Size(177, 48);
            this.btnModyfikujDane.TabIndex = 2;
            this.btnModyfikujDane.Text = "Modyfikuj dane";
            this.btnModyfikujDane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModyfikujDane.UseVisualStyleBackColor = false;
            this.btnModyfikujDane.Click += new System.EventHandler(this.btnModyfikujDane_Click);
            // 
            // btnUsunKlienta
            // 
            this.btnUsunKlienta.BackColor = System.Drawing.Color.White;
            this.btnUsunKlienta.Image = ((System.Drawing.Image)(resources.GetObject("btnUsunKlienta.Image")));
            this.btnUsunKlienta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsunKlienta.Location = new System.Drawing.Point(186, 3);
            this.btnUsunKlienta.Name = "btnUsunKlienta";
            this.btnUsunKlienta.Size = new System.Drawing.Size(177, 48);
            this.btnUsunKlienta.TabIndex = 1;
            this.btnUsunKlienta.Text = "Usuń klienta";
            this.btnUsunKlienta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsunKlienta.UseVisualStyleBackColor = false;
            this.btnUsunKlienta.Click += new System.EventHandler(this.btnUsunKlienta_Click);
            // 
            // btnDodajKlienta
            // 
            this.btnDodajKlienta.BackColor = System.Drawing.Color.White;
            this.btnDodajKlienta.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajKlienta.Image")));
            this.btnDodajKlienta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKlienta.Location = new System.Drawing.Point(3, 3);
            this.btnDodajKlienta.Name = "btnDodajKlienta";
            this.btnDodajKlienta.Size = new System.Drawing.Size(177, 48);
            this.btnDodajKlienta.TabIndex = 0;
            this.btnDodajKlienta.Text = "Dodaj klienta";
            this.btnDodajKlienta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajKlienta.UseVisualStyleBackColor = false;
            this.btnDodajKlienta.Click += new System.EventHandler(this.btnDodajKlienta_Click);
            // 
            // dgvKlienci
            // 
            this.dgvKlienci.AllowUserToAddRows = false;
            this.dgvKlienci.AllowUserToDeleteRows = false;
            this.dgvKlienci.AutoGenerateColumns = false;
            this.dgvKlienci.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKlientKolumna,
            this.IdKontaktKolumna,
            this.ImieKolumna,
            this.NazwiskoKolumna,
            this.RodzajKolumna,
            this.NumerKolumna,
            this.EmailKolumna});
            this.dgvKlienci.DataSource = this.bsKlienci;
            this.dgvKlienci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlienci.Location = new System.Drawing.Point(3, 63);
            this.dgvKlienci.Name = "dgvKlienci";
            this.dgvKlienci.ReadOnly = true;
            this.dgvKlienci.RowHeadersVisible = false;
            this.dgvKlienci.RowHeadersWidth = 51;
            this.dgvKlienci.RowTemplate.Height = 24;
            this.dgvKlienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlienci.Size = new System.Drawing.Size(951, 469);
            this.dgvKlienci.TabIndex = 1;
            // 
            // IdKlientKolumna
            // 
            this.IdKlientKolumna.DataPropertyName = "idKlient";
            this.IdKlientKolumna.HeaderText = "Numer klienta";
            this.IdKlientKolumna.MinimumWidth = 6;
            this.IdKlientKolumna.Name = "IdKlientKolumna";
            this.IdKlientKolumna.ReadOnly = true;
            this.IdKlientKolumna.Width = 125;
            // 
            // IdKontaktKolumna
            // 
            this.IdKontaktKolumna.DataPropertyName = "idKontakt";
            this.IdKontaktKolumna.HeaderText = "ID Kontakt";
            this.IdKontaktKolumna.MinimumWidth = 6;
            this.IdKontaktKolumna.Name = "IdKontaktKolumna";
            this.IdKontaktKolumna.ReadOnly = true;
            this.IdKontaktKolumna.Width = 125;
            // 
            // ImieKolumna
            // 
            this.ImieKolumna.DataPropertyName = "IMIE";
            this.ImieKolumna.HeaderText = "Imię";
            this.ImieKolumna.MinimumWidth = 6;
            this.ImieKolumna.Name = "ImieKolumna";
            this.ImieKolumna.ReadOnly = true;
            this.ImieKolumna.Width = 125;
            // 
            // NazwiskoKolumna
            // 
            this.NazwiskoKolumna.DataPropertyName = "NAZWISKO";
            this.NazwiskoKolumna.HeaderText = "Nazwisko";
            this.NazwiskoKolumna.MinimumWidth = 6;
            this.NazwiskoKolumna.Name = "NazwiskoKolumna";
            this.NazwiskoKolumna.ReadOnly = true;
            this.NazwiskoKolumna.Width = 125;
            // 
            // RodzajKolumna
            // 
            this.RodzajKolumna.DataPropertyName = "RODZAJ_KLIENTA";
            this.RodzajKolumna.HeaderText = "Rodzaj klienta";
            this.RodzajKolumna.MinimumWidth = 6;
            this.RodzajKolumna.Name = "RodzajKolumna";
            this.RodzajKolumna.ReadOnly = true;
            this.RodzajKolumna.Width = 125;
            // 
            // NumerKolumna
            // 
            this.NumerKolumna.DataPropertyName = "NUMER_TELEFONU";
            this.NumerKolumna.HeaderText = "Numer telefonu";
            this.NumerKolumna.MinimumWidth = 6;
            this.NumerKolumna.Name = "NumerKolumna";
            this.NumerKolumna.ReadOnly = true;
            this.NumerKolumna.Width = 125;
            // 
            // EmailKolumna
            // 
            this.EmailKolumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailKolumna.DataPropertyName = "EMAIL";
            this.EmailKolumna.HeaderText = "Email";
            this.EmailKolumna.MinimumWidth = 6;
            this.EmailKolumna.Name = "EmailKolumna";
            this.EmailKolumna.ReadOnly = true;
            // 
            // bsKlienci
            // 
            this.bsKlienci.DataSource = typeof(ZakładTransportowy.Dostep_do_danych.ModeleDanych.WidokKlient);
            // 
            // ListaKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ListaKlientow";
            this.Text = "Klienci";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKlienci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModyfikujDane;
        private System.Windows.Forms.Button btnUsunKlienta;
        private System.Windows.Forms.Button btnDodajKlienta;
        private System.Windows.Forms.DataGridView dgvKlienci;
        private System.Windows.Forms.BindingSource bsKlienci;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlientKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKontaktKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailKolumna;
    }
}