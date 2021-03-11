
namespace ZakładTransportowy
{
    partial class ListaZamowienDlaPracownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaZamowienDlaPracownika));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOplacZamowienie = new System.Windows.Forms.Button();
            this.btEdytujZamowienie = new System.Windows.Forms.Button();
            this.btUsunZamowienie = new System.Windows.Forms.Button();
            this.btDodajZamowienie = new System.Windows.Forms.Button();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.IdKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKlientaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPojazdKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataZlozeniaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRealizacjiKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyZaplaconoKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZamowienia = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvZamowienia, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOplacZamowienie);
            this.panel1.Controls.Add(this.btEdytujZamowienie);
            this.panel1.Controls.Add(this.btUsunZamowienie);
            this.panel1.Controls.Add(this.btDodajZamowienie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 62);
            this.panel1.TabIndex = 0;
            // 
            // btOplacZamowienie
            // 
            this.btOplacZamowienie.BackColor = System.Drawing.Color.White;
            this.btOplacZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btOplacZamowienie.Image")));
            this.btOplacZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOplacZamowienie.Location = new System.Drawing.Point(621, 3);
            this.btOplacZamowienie.Name = "btOplacZamowienie";
            this.btOplacZamowienie.Size = new System.Drawing.Size(200, 56);
            this.btOplacZamowienie.TabIndex = 3;
            this.btOplacZamowienie.Text = "Opłać zamówienie";
            this.btOplacZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOplacZamowienie.UseVisualStyleBackColor = false;
            this.btOplacZamowienie.Click += new System.EventHandler(this.btOplacZamowienie_Click);
            // 
            // btEdytujZamowienie
            // 
            this.btEdytujZamowienie.BackColor = System.Drawing.Color.White;
            this.btEdytujZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btEdytujZamowienie.Image")));
            this.btEdytujZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdytujZamowienie.Location = new System.Drawing.Point(415, 3);
            this.btEdytujZamowienie.Name = "btEdytujZamowienie";
            this.btEdytujZamowienie.Size = new System.Drawing.Size(200, 56);
            this.btEdytujZamowienie.TabIndex = 2;
            this.btEdytujZamowienie.Text = "Edytuj zamówienie";
            this.btEdytujZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdytujZamowienie.UseVisualStyleBackColor = false;
            this.btEdytujZamowienie.Click += new System.EventHandler(this.btEdytujZamowienie_Click);
            // 
            // btUsunZamowienie
            // 
            this.btUsunZamowienie.BackColor = System.Drawing.Color.White;
            this.btUsunZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btUsunZamowienie.Image")));
            this.btUsunZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsunZamowienie.Location = new System.Drawing.Point(209, 3);
            this.btUsunZamowienie.Name = "btUsunZamowienie";
            this.btUsunZamowienie.Size = new System.Drawing.Size(200, 56);
            this.btUsunZamowienie.TabIndex = 1;
            this.btUsunZamowienie.Text = "Usuń zamówienie";
            this.btUsunZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsunZamowienie.UseVisualStyleBackColor = false;
            this.btUsunZamowienie.Click += new System.EventHandler(this.btUsunZamowienie_Click);
            // 
            // btDodajZamowienie
            // 
            this.btDodajZamowienie.BackColor = System.Drawing.Color.White;
            this.btDodajZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btDodajZamowienie.Image")));
            this.btDodajZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDodajZamowienie.Location = new System.Drawing.Point(3, 3);
            this.btDodajZamowienie.Name = "btDodajZamowienie";
            this.btDodajZamowienie.Size = new System.Drawing.Size(200, 56);
            this.btDodajZamowienie.TabIndex = 0;
            this.btDodajZamowienie.Text = "Dodaj zamówienie";
            this.btDodajZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDodajZamowienie.UseVisualStyleBackColor = false;
            this.btDodajZamowienie.Click += new System.EventHandler(this.btDodajZamowienie_Click);
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AllowUserToAddRows = false;
            this.dgvZamowienia.AllowUserToDeleteRows = false;
            this.dgvZamowienia.AutoGenerateColumns = false;
            this.dgvZamowienia.BackgroundColor = System.Drawing.Color.White;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKolumna,
            this.IdKlientaKolumna,
            this.IdPojazdKolumna,
            this.rodzajKolumna,
            this.imieKolumna,
            this.nazwiskoKolumna,
            this.DataZlozeniaKolumna,
            this.DataRealizacjiKolumna,
            this.czyZaplaconoKolumna,
            this.CenaKolumna});
            this.dgvZamowienia.DataSource = this.bsZamowienia;
            this.dgvZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZamowienia.Location = new System.Drawing.Point(3, 71);
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.ReadOnly = true;
            this.dgvZamowienia.RowHeadersVisible = false;
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.RowTemplate.Height = 24;
            this.dgvZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamowienia.Size = new System.Drawing.Size(1147, 613);
            this.dgvZamowienia.TabIndex = 1;
            // 
            // IdKolumna
            // 
            this.IdKolumna.DataPropertyName = "idZamowienie";
            this.IdKolumna.HeaderText = "Numer zamówienia";
            this.IdKolumna.MinimumWidth = 6;
            this.IdKolumna.Name = "IdKolumna";
            this.IdKolumna.ReadOnly = true;
            this.IdKolumna.Width = 125;
            // 
            // IdKlientaKolumna
            // 
            this.IdKlientaKolumna.DataPropertyName = "idKlient";
            this.IdKlientaKolumna.HeaderText = "Numer klienta";
            this.IdKlientaKolumna.MinimumWidth = 6;
            this.IdKlientaKolumna.Name = "IdKlientaKolumna";
            this.IdKlientaKolumna.ReadOnly = true;
            this.IdKlientaKolumna.Width = 125;
            // 
            // IdPojazdKolumna
            // 
            this.IdPojazdKolumna.DataPropertyName = "idPojazd";
            this.IdPojazdKolumna.HeaderText = "Numer pojazdu";
            this.IdPojazdKolumna.MinimumWidth = 6;
            this.IdPojazdKolumna.Name = "IdPojazdKolumna";
            this.IdPojazdKolumna.ReadOnly = true;
            this.IdPojazdKolumna.Width = 125;
            // 
            // rodzajKolumna
            // 
            this.rodzajKolumna.DataPropertyName = "rodzaj";
            this.rodzajKolumna.HeaderText = "Rodzaj";
            this.rodzajKolumna.MinimumWidth = 6;
            this.rodzajKolumna.Name = "rodzajKolumna";
            this.rodzajKolumna.ReadOnly = true;
            this.rodzajKolumna.Width = 125;
            // 
            // imieKolumna
            // 
            this.imieKolumna.DataPropertyName = "imie";
            this.imieKolumna.HeaderText = "Imię";
            this.imieKolumna.MinimumWidth = 6;
            this.imieKolumna.Name = "imieKolumna";
            this.imieKolumna.ReadOnly = true;
            this.imieKolumna.Width = 125;
            // 
            // nazwiskoKolumna
            // 
            this.nazwiskoKolumna.DataPropertyName = "nazwisko";
            this.nazwiskoKolumna.HeaderText = "Nazwisko";
            this.nazwiskoKolumna.MinimumWidth = 6;
            this.nazwiskoKolumna.Name = "nazwiskoKolumna";
            this.nazwiskoKolumna.ReadOnly = true;
            this.nazwiskoKolumna.Width = 125;
            // 
            // DataZlozeniaKolumna
            // 
            this.DataZlozeniaKolumna.DataPropertyName = "data_zlozenia";
            this.DataZlozeniaKolumna.HeaderText = "Data złożenia";
            this.DataZlozeniaKolumna.MinimumWidth = 6;
            this.DataZlozeniaKolumna.Name = "DataZlozeniaKolumna";
            this.DataZlozeniaKolumna.ReadOnly = true;
            this.DataZlozeniaKolumna.Width = 125;
            // 
            // DataRealizacjiKolumna
            // 
            this.DataRealizacjiKolumna.DataPropertyName = "data_realizacji";
            this.DataRealizacjiKolumna.HeaderText = "Data realizacji";
            this.DataRealizacjiKolumna.MinimumWidth = 6;
            this.DataRealizacjiKolumna.Name = "DataRealizacjiKolumna";
            this.DataRealizacjiKolumna.ReadOnly = true;
            this.DataRealizacjiKolumna.Width = 125;
            // 
            // czyZaplaconoKolumna
            // 
            this.czyZaplaconoKolumna.DataPropertyName = "czy_Zaplacono";
            this.czyZaplaconoKolumna.HeaderText = "Czy zapłacono?";
            this.czyZaplaconoKolumna.MinimumWidth = 6;
            this.czyZaplaconoKolumna.Name = "czyZaplaconoKolumna";
            this.czyZaplaconoKolumna.ReadOnly = true;
            this.czyZaplaconoKolumna.Width = 144;
            // 
            // CenaKolumna
            // 
            this.CenaKolumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CenaKolumna.DataPropertyName = "cena";
            this.CenaKolumna.HeaderText = "Cena";
            this.CenaKolumna.MinimumWidth = 6;
            this.CenaKolumna.Name = "CenaKolumna";
            this.CenaKolumna.ReadOnly = true;
            // 
            // bsZamowienia
            // 
            this.bsZamowienia.DataSource = typeof(ZakładTransportowy.WidokZamowienie);
            // 
            // ListaZamowienDlaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ListaZamowienDlaPracownika";
            this.Text = "ListaZamowienDlaPracownika";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOplacZamowienie;
        private System.Windows.Forms.Button btEdytujZamowienie;
        private System.Windows.Forms.Button btUsunZamowienie;
        private System.Windows.Forms.Button btDodajZamowienie;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.BindingSource bsZamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlientaKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPojazdKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataZlozeniaKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRealizacjiKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn czyZaplaconoKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaKolumna;
    }
}