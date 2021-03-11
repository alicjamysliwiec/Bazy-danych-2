
namespace ZakładTransportowy
{
    partial class PrzegladanieZamowien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzegladanieZamowien));
            this.ZamowieniaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gornyPanel = new System.Windows.Forms.Panel();
            this.btAnulujZamowienie = new System.Windows.Forms.Button();
            this.btDodajZamowienie = new System.Windows.Forms.Button();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.IdZamowienieKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPojazdKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRodzajKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataZlozeniaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRealizacjiKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyZaplaconoKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZamowienia = new System.Windows.Forms.BindingSource(this.components);
            this.ZamowieniaPanel.SuspendLayout();
            this.gornyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // ZamowieniaPanel
            // 
            this.ZamowieniaPanel.ColumnCount = 1;
            this.ZamowieniaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ZamowieniaPanel.Controls.Add(this.gornyPanel, 0, 0);
            this.ZamowieniaPanel.Controls.Add(this.dgvZamowienia, 0, 1);
            this.ZamowieniaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZamowieniaPanel.Location = new System.Drawing.Point(0, 0);
            this.ZamowieniaPanel.Name = "ZamowieniaPanel";
            this.ZamowieniaPanel.RowCount = 2;
            this.ZamowieniaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ZamowieniaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ZamowieniaPanel.Size = new System.Drawing.Size(1082, 808);
            this.ZamowieniaPanel.TabIndex = 0;
            this.ZamowieniaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ZamowieniaPanel_Paint);
            // 
            // gornyPanel
            // 
            this.gornyPanel.Controls.Add(this.btAnulujZamowienie);
            this.gornyPanel.Controls.Add(this.btDodajZamowienie);
            this.gornyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gornyPanel.Location = new System.Drawing.Point(3, 3);
            this.gornyPanel.Name = "gornyPanel";
            this.gornyPanel.Size = new System.Drawing.Size(1076, 54);
            this.gornyPanel.TabIndex = 0;
            // 
            // btAnulujZamowienie
            // 
            this.btAnulujZamowienie.BackColor = System.Drawing.Color.White;
            this.btAnulujZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btAnulujZamowienie.Image")));
            this.btAnulujZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnulujZamowienie.Location = new System.Drawing.Point(202, 3);
            this.btAnulujZamowienie.Name = "btAnulujZamowienie";
            this.btAnulujZamowienie.Size = new System.Drawing.Size(193, 48);
            this.btAnulujZamowienie.TabIndex = 1;
            this.btAnulujZamowienie.Text = "Anuluj zamówienie";
            this.btAnulujZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnulujZamowienie.UseVisualStyleBackColor = false;
            this.btAnulujZamowienie.Click += new System.EventHandler(this.btAnulujZamowienie_Click);
            // 
            // btDodajZamowienie
            // 
            this.btDodajZamowienie.BackColor = System.Drawing.Color.White;
            this.btDodajZamowienie.Image = ((System.Drawing.Image)(resources.GetObject("btDodajZamowienie.Image")));
            this.btDodajZamowienie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDodajZamowienie.Location = new System.Drawing.Point(3, 3);
            this.btDodajZamowienie.Name = "btDodajZamowienie";
            this.btDodajZamowienie.Size = new System.Drawing.Size(193, 48);
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
            this.IdZamowienieKolumna,
            this.IdPojazdKolumna,
            this.IdRodzajKolumna,
            this.DataZlozeniaKolumna,
            this.DataRealizacjiKolumna,
            this.CzyZaplaconoKolumna,
            this.CenaKolumna});
            this.dgvZamowienia.DataSource = this.bsZamowienia;
            this.dgvZamowienia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZamowienia.Location = new System.Drawing.Point(3, 63);
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.ReadOnly = true;
            this.dgvZamowienia.RowHeadersVisible = false;
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.RowTemplate.Height = 24;
            this.dgvZamowienia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamowienia.Size = new System.Drawing.Size(1076, 742);
            this.dgvZamowienia.TabIndex = 1;
            // 
            // IdZamowienieKolumna
            // 
            this.IdZamowienieKolumna.DataPropertyName = "idZamowienie";
            this.IdZamowienieKolumna.HeaderText = "Numer zamówienia";
            this.IdZamowienieKolumna.MinimumWidth = 6;
            this.IdZamowienieKolumna.Name = "IdZamowienieKolumna";
            this.IdZamowienieKolumna.ReadOnly = true;
            this.IdZamowienieKolumna.Width = 125;
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
            // IdRodzajKolumna
            // 
            this.IdRodzajKolumna.DataPropertyName = "rodzaj";
            this.IdRodzajKolumna.HeaderText = "Rodzaj";
            this.IdRodzajKolumna.MinimumWidth = 6;
            this.IdRodzajKolumna.Name = "IdRodzajKolumna";
            this.IdRodzajKolumna.ReadOnly = true;
            this.IdRodzajKolumna.Width = 125;
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
            // CzyZaplaconoKolumna
            // 
            this.CzyZaplaconoKolumna.DataPropertyName = "czy_Zaplacono";
            this.CzyZaplaconoKolumna.HeaderText = "Czy zapłacono?";
            this.CzyZaplaconoKolumna.MinimumWidth = 6;
            this.CzyZaplaconoKolumna.Name = "CzyZaplaconoKolumna";
            this.CzyZaplaconoKolumna.ReadOnly = true;
            this.CzyZaplaconoKolumna.Width = 125;
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
            // PrzegladanieZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 808);
            this.Controls.Add(this.ZamowieniaPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "PrzegladanieZamowien";
            this.Text = "Twoje zamówienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzegladanieZamowien_FormClosed);
            this.ZamowieniaPanel.ResumeLayout(false);
            this.gornyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ZamowieniaPanel;
        private System.Windows.Forms.Panel gornyPanel;
        private System.Windows.Forms.Button btAnulujZamowienie;
        private System.Windows.Forms.Button btDodajZamowienie;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZamowienieKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPojazdKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRodzajKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataZlozeniaKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRealizacjiKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyZaplaconoKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaKolumna;
        private System.Windows.Forms.BindingSource bsZamowienia;
    }
}