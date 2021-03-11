
namespace ZakładTransportowy
{
    partial class Pojazdy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pojazdy));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsunPojazd = new System.Windows.Forms.Button();
            this.btnDodajPojazd = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.dgvIDPojazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumerRejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPojazd = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPojazdy, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsunPojazd);
            this.panel1.Controls.Add(this.btnDodajPojazd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnUsunPojazd
            // 
            this.btnUsunPojazd.BackColor = System.Drawing.Color.White;
            this.btnUsunPojazd.Image = ((System.Drawing.Image)(resources.GetObject("btnUsunPojazd.Image")));
            this.btnUsunPojazd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsunPojazd.Location = new System.Drawing.Point(195, 3);
            this.btnUsunPojazd.Name = "btnUsunPojazd";
            this.btnUsunPojazd.Size = new System.Drawing.Size(186, 56);
            this.btnUsunPojazd.TabIndex = 1;
            this.btnUsunPojazd.Text = "Usuń pojazd";
            this.btnUsunPojazd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsunPojazd.UseVisualStyleBackColor = false;
            this.btnUsunPojazd.Click += new System.EventHandler(this.btnUsunPojazd_Click);
            // 
            // btnDodajPojazd
            // 
            this.btnDodajPojazd.BackColor = System.Drawing.Color.White;
            this.btnDodajPojazd.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajPojazd.Image")));
            this.btnDodajPojazd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPojazd.Location = new System.Drawing.Point(3, 3);
            this.btnDodajPojazd.Name = "btnDodajPojazd";
            this.btnDodajPojazd.Size = new System.Drawing.Size(186, 56);
            this.btnDodajPojazd.TabIndex = 0;
            this.btnDodajPojazd.Text = "Dodaj pojazd";
            this.btnDodajPojazd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPojazd.UseVisualStyleBackColor = false;
            this.btnDodajPojazd.Click += new System.EventHandler(this.btnDodajPojazd_Click);
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.AllowUserToAddRows = false;
            this.dgvPojazdy.AllowUserToDeleteRows = false;
            this.dgvPojazdy.AutoGenerateColumns = false;
            this.dgvPojazdy.BackgroundColor = System.Drawing.Color.White;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDPojazd,
            this.dgvNumerRejestracyjny,
            this.dgvRodzaj,
            this.dgvData,
            this.dgvStan});
            this.dgvPojazdy.DataSource = this.bsPojazd;
            this.dgvPojazdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPojazdy.Location = new System.Drawing.Point(3, 71);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.RowHeadersVisible = false;
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPojazdy.Size = new System.Drawing.Size(1177, 456);
            this.dgvPojazdy.TabIndex = 1;
            // 
            // dgvIDPojazd
            // 
            this.dgvIDPojazd.DataPropertyName = "idPojazd";
            this.dgvIDPojazd.HeaderText = "ID";
            this.dgvIDPojazd.MinimumWidth = 6;
            this.dgvIDPojazd.Name = "dgvIDPojazd";
            this.dgvIDPojazd.ReadOnly = true;
            this.dgvIDPojazd.Width = 125;
            // 
            // dgvNumerRejestracyjny
            // 
            this.dgvNumerRejestracyjny.DataPropertyName = "numerRejestracyjny";
            this.dgvNumerRejestracyjny.HeaderText = "Numer rejestracyjny";
            this.dgvNumerRejestracyjny.MinimumWidth = 100;
            this.dgvNumerRejestracyjny.Name = "dgvNumerRejestracyjny";
            this.dgvNumerRejestracyjny.ReadOnly = true;
            this.dgvNumerRejestracyjny.Width = 250;
            // 
            // dgvRodzaj
            // 
            this.dgvRodzaj.DataPropertyName = "rodzaj";
            this.dgvRodzaj.HeaderText = "Rodzaj";
            this.dgvRodzaj.MinimumWidth = 100;
            this.dgvRodzaj.Name = "dgvRodzaj";
            this.dgvRodzaj.ReadOnly = true;
            this.dgvRodzaj.Width = 125;
            // 
            // dgvData
            // 
            this.dgvData.DataPropertyName = "dataOstatneigoPrzegladu";
            this.dgvData.HeaderText = "Data ostatniego przeglądu";
            this.dgvData.MinimumWidth = 100;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Width = 350;
            // 
            // dgvStan
            // 
            this.dgvStan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvStan.DataPropertyName = "stanTechniczny";
            this.dgvStan.HeaderText = "Stan techniczny";
            this.dgvStan.MinimumWidth = 100;
            this.dgvStan.Name = "dgvStan";
            this.dgvStan.ReadOnly = true;
            // 
            // bsPojazd
            // 
            this.bsPojazd.DataSource = typeof(ZakładTransportowy.Pojazd);
            // 
            // Pojazdy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pojazdy";
            this.Text = "Pojazdy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsunPojazd;
        private System.Windows.Forms.Button btnDodajPojazd;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.BindingSource bsPojazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDPojazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumerRejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStan;
    }
}