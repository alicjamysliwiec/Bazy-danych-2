
namespace ZakładTransportowy
{
    partial class Pracownicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModyfikujDane = new System.Windows.Forms.Button();
            this.btUsunPracownika = new System.Windows.Forms.Button();
            this.btDodajPracownika = new System.Windows.Forms.Button();
            this.dgvPracownicy = new System.Windows.Forms.DataGridView();
            this.bsPracownicy = new System.Windows.Forms.BindingSource(this.components);
            this.IdPracownikKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKontaktKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImieKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UprawnieniaKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerTelefonuKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPracownicy, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModyfikujDane);
            this.panel1.Controls.Add(this.btUsunPracownika);
            this.panel1.Controls.Add(this.btDodajPracownika);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnModyfikujDane
            // 
            this.btnModyfikujDane.BackColor = System.Drawing.Color.White;
            this.btnModyfikujDane.Image = ((System.Drawing.Image)(resources.GetObject("btnModyfikujDane.Image")));
            this.btnModyfikujDane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModyfikujDane.Location = new System.Drawing.Point(441, 3);
            this.btnModyfikujDane.Name = "btnModyfikujDane";
            this.btnModyfikujDane.Size = new System.Drawing.Size(213, 56);
            this.btnModyfikujDane.TabIndex = 2;
            this.btnModyfikujDane.Text = "Modyfikuj dane";
            this.btnModyfikujDane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModyfikujDane.UseVisualStyleBackColor = false;
            this.btnModyfikujDane.Click += new System.EventHandler(this.btnModyfikujDane_Click);
            // 
            // btUsunPracownika
            // 
            this.btUsunPracownika.BackColor = System.Drawing.Color.White;
            this.btUsunPracownika.Image = ((System.Drawing.Image)(resources.GetObject("btUsunPracownika.Image")));
            this.btUsunPracownika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsunPracownika.Location = new System.Drawing.Point(222, 3);
            this.btUsunPracownika.Name = "btUsunPracownika";
            this.btUsunPracownika.Size = new System.Drawing.Size(213, 56);
            this.btUsunPracownika.TabIndex = 1;
            this.btUsunPracownika.Text = "Usuń pracownika";
            this.btUsunPracownika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsunPracownika.UseVisualStyleBackColor = false;
            this.btUsunPracownika.Click += new System.EventHandler(this.btUsunPracownika_Click);
            // 
            // btDodajPracownika
            // 
            this.btDodajPracownika.BackColor = System.Drawing.Color.White;
            this.btDodajPracownika.Image = ((System.Drawing.Image)(resources.GetObject("btDodajPracownika.Image")));
            this.btDodajPracownika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDodajPracownika.Location = new System.Drawing.Point(3, 3);
            this.btDodajPracownika.Name = "btDodajPracownika";
            this.btDodajPracownika.Size = new System.Drawing.Size(213, 56);
            this.btDodajPracownika.TabIndex = 0;
            this.btDodajPracownika.Text = "Dodaj pracownika";
            this.btDodajPracownika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDodajPracownika.UseVisualStyleBackColor = false;
            this.btDodajPracownika.Click += new System.EventHandler(this.btDodajPracownika_Click);
            // 
            // dgvPracownicy
            // 
            this.dgvPracownicy.AllowUserToAddRows = false;
            this.dgvPracownicy.AllowUserToDeleteRows = false;
            this.dgvPracownicy.AutoGenerateColumns = false;
            this.dgvPracownicy.BackgroundColor = System.Drawing.Color.White;
            this.dgvPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPracownikKolumna,
            this.IdKontaktKolumna,
            this.ImieKolumna,
            this.NazwiskoKolumna,
            this.UprawnieniaKolumna,
            this.NumerTelefonuKolumna,
            this.EmailKolumna});
            this.dgvPracownicy.DataSource = this.bsPracownicy;
            this.dgvPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPracownicy.Location = new System.Drawing.Point(3, 71);
            this.dgvPracownicy.Name = "dgvPracownicy";
            this.dgvPracownicy.ReadOnly = true;
            this.dgvPracownicy.RowHeadersVisible = false;
            this.dgvPracownicy.RowHeadersWidth = 51;
            this.dgvPracownicy.RowTemplate.Height = 24;
            this.dgvPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPracownicy.Size = new System.Drawing.Size(1072, 638);
            this.dgvPracownicy.TabIndex = 1;
            // 
            // bsPracownicy
            // 
            this.bsPracownicy.DataSource = typeof(ZakładTransportowy.WidokPracownik);
            // 
            // IdPracownikKolumna
            // 
            this.IdPracownikKolumna.DataPropertyName = "idPracownik";
            this.IdPracownikKolumna.HeaderText = "Numer pracownika";
            this.IdPracownikKolumna.MinimumWidth = 6;
            this.IdPracownikKolumna.Name = "IdPracownikKolumna";
            this.IdPracownikKolumna.ReadOnly = true;
            this.IdPracownikKolumna.Width = 125;
            // 
            // IdKontaktKolumna
            // 
            this.IdKontaktKolumna.DataPropertyName = "idKontakt";
            this.IdKontaktKolumna.HeaderText = "ID Kontaktu";
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
            // UprawnieniaKolumna
            // 
            this.UprawnieniaKolumna.DataPropertyName = "UPRAWNIENIA";
            this.UprawnieniaKolumna.HeaderText = "Stanowisko";
            this.UprawnieniaKolumna.MinimumWidth = 6;
            this.UprawnieniaKolumna.Name = "UprawnieniaKolumna";
            this.UprawnieniaKolumna.ReadOnly = true;
            this.UprawnieniaKolumna.Width = 125;
            // 
            // NumerTelefonuKolumna
            // 
            this.NumerTelefonuKolumna.DataPropertyName = "NUMER_TELEFONU";
            this.NumerTelefonuKolumna.HeaderText = "Numer telefonu";
            this.NumerTelefonuKolumna.MinimumWidth = 6;
            this.NumerTelefonuKolumna.Name = "NumerTelefonuKolumna";
            this.NumerTelefonuKolumna.ReadOnly = true;
            this.NumerTelefonuKolumna.Width = 125;
            // 
            // EmailKolumna
            // 
            this.EmailKolumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailKolumna.DataPropertyName = "EMAIL";
            this.EmailKolumna.HeaderText = "E - mail";
            this.EmailKolumna.MinimumWidth = 6;
            this.EmailKolumna.Name = "EmailKolumna";
            this.EmailKolumna.ReadOnly = true;
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Pracownicy";
            this.Text = "Pracownicy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModyfikujDane;
        private System.Windows.Forms.Button btUsunPracownika;
        private System.Windows.Forms.Button btDodajPracownika;
        private System.Windows.Forms.DataGridView dgvPracownicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PensjaKolumna;
        private System.Windows.Forms.BindingSource bsPracownicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPracownikKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKontaktKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn UprawnieniaKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerTelefonuKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailKolumna;
    }
}