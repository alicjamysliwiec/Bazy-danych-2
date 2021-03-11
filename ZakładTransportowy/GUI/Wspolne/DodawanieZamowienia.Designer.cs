
namespace ZakładTransportowy
{
    partial class DodawanieZamowienia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CenaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.IdKlientaText = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.idKlientaLabel = new System.Windows.Forms.Label();
            this.IdPojazdKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerRejestracyjnyKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPojazdy = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25391F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPojazdy, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idKlientaLabel);
            this.panel1.Controls.Add(this.cenaLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CenaText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.IdKlientaText);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 597);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybierz datę realizacji";
            // 
            // CenaText
            // 
            this.CenaText.Location = new System.Drawing.Point(245, 127);
            this.CenaText.Name = "CenaText";
            this.CenaText.Size = new System.Drawing.Size(135, 23);
            this.CenaText.TabIndex = 5;
            this.CenaText.TextChanged += new System.EventHandler(this.CenaText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena:";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(171, 499);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(148, 55);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // IdKlientaText
            // 
            this.IdKlientaText.Location = new System.Drawing.Point(245, 73);
            this.IdKlientaText.Name = "IdKlientaText";
            this.IdKlientaText.Size = new System.Drawing.Size(135, 23);
            this.IdKlientaText.TabIndex = 1;
            this.IdKlientaText.TextChanged += new System.EventHandler(this.IdKlientaText_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(90, 256);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer klienta:";
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.AllowUserToAddRows = false;
            this.dgvPojazdy.AllowUserToDeleteRows = false;
            this.dgvPojazdy.AutoGenerateColumns = false;
            this.dgvPojazdy.BackgroundColor = System.Drawing.Color.White;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPojazdKolumna,
            this.rodzajKolumna,
            this.numerRejestracyjnyKolumna});
            this.dgvPojazdy.DataSource = this.bsPojazdy;
            this.dgvPojazdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPojazdy.Location = new System.Drawing.Point(521, 3);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.RowHeadersVisible = false;
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPojazdy.Size = new System.Drawing.Size(563, 597);
            this.dgvPojazdy.TabIndex = 1;
            this.dgvPojazdy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazdy_CellContentClick);
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(241, 127);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(52, 19);
            this.cenaLabel.TabIndex = 7;
            this.cenaLabel.Text = "label4";
            // 
            // idKlientaLabel
            // 
            this.idKlientaLabel.AutoSize = true;
            this.idKlientaLabel.Location = new System.Drawing.Point(241, 77);
            this.idKlientaLabel.Name = "idKlientaLabel";
            this.idKlientaLabel.Size = new System.Drawing.Size(52, 19);
            this.idKlientaLabel.TabIndex = 8;
            this.idKlientaLabel.Text = "label4";
            // 
            // IdPojazdKolumna
            // 
            this.IdPojazdKolumna.DataPropertyName = "idPojazd";
            this.IdPojazdKolumna.HeaderText = "ID";
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
            // numerRejestracyjnyKolumna
            // 
            this.numerRejestracyjnyKolumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerRejestracyjnyKolumna.DataPropertyName = "numerRejestracyjny";
            this.numerRejestracyjnyKolumna.HeaderText = "Numer rejestracyjny";
            this.numerRejestracyjnyKolumna.MinimumWidth = 6;
            this.numerRejestracyjnyKolumna.Name = "numerRejestracyjnyKolumna";
            this.numerRejestracyjnyKolumna.ReadOnly = true;
            // 
            // bsPojazdy
            // 
            this.bsPojazdy.DataSource = typeof(ZakładTransportowy.Pojazd);
            // 
            // DodawanieZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "DodawanieZamowienia";
            this.Text = "Dodaj zamówienie";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazdy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPojazdKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerRejestracyjnyKolumna;
        private System.Windows.Forms.BindingSource bsPojazdy;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CenaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox IdKlientaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label idKlientaLabel;
    }
}