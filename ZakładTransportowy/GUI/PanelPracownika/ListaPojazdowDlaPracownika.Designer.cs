
namespace ZakładTransportowy
{
    partial class ListaPojazdowDlaPracownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPojazdowDlaPracownika));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bsPojazd = new System.Windows.Forms.BindingSource(this.components);
            this.btModyfikuj = new System.Windows.Forms.Button();
            this.pojazdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStanTechniczny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumerRejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdPojazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPojazdy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.AllowUserToAddRows = false;
            this.dgvPojazdy.AllowUserToDeleteRows = false;
            this.dgvPojazdy.AutoGenerateColumns = false;
            this.dgvPojazdy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPojazdy.BackgroundColor = System.Drawing.Color.White;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdPojazd,
            this.dgvNumerRejestracyjny,
            this.dgvRodzaj,
            this.dgvData,
            this.dgvStanTechniczny});
            this.dgvPojazdy.DataSource = this.pojazdBindingSource;
            this.dgvPojazdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPojazdy.Location = new System.Drawing.Point(3, 63);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.RowHeadersVisible = false;
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPojazdy.Size = new System.Drawing.Size(967, 515);
            this.dgvPojazdy.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btModyfikuj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 54);
            this.panel1.TabIndex = 1;
            // 
            // btModyfikuj
            // 
            this.btModyfikuj.BackColor = System.Drawing.Color.White;
            this.btModyfikuj.Image = ((System.Drawing.Image)(resources.GetObject("btModyfikuj.Image")));
            this.btModyfikuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModyfikuj.Location = new System.Drawing.Point(3, 3);
            this.btModyfikuj.Name = "btModyfikuj";
            this.btModyfikuj.Size = new System.Drawing.Size(192, 48);
            this.btModyfikuj.TabIndex = 0;
            this.btModyfikuj.Text = "Modyfikuj";
            this.btModyfikuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModyfikuj.UseVisualStyleBackColor = false;
            this.btModyfikuj.Click += new System.EventHandler(this.btModyfikuj_Click);
            // 
            // pojazdBindingSource
            // 
            this.pojazdBindingSource.DataSource = typeof(ZakładTransportowy.Pojazd);
            // 
            // dgvStanTechniczny
            // 
            this.dgvStanTechniczny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvStanTechniczny.DataPropertyName = "stanTechniczny";
            this.dgvStanTechniczny.HeaderText = "Stan techniczny";
            this.dgvStanTechniczny.MinimumWidth = 6;
            this.dgvStanTechniczny.Name = "dgvStanTechniczny";
            this.dgvStanTechniczny.ReadOnly = true;
            // 
            // dgvData
            // 
            this.dgvData.DataPropertyName = "dataOstatneigoPrzegladu";
            this.dgvData.HeaderText = "Data ostatniego przeglądu";
            this.dgvData.MinimumWidth = 6;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            // 
            // dgvRodzaj
            // 
            this.dgvRodzaj.DataPropertyName = "rodzaj";
            this.dgvRodzaj.HeaderText = "Rodzaj";
            this.dgvRodzaj.MinimumWidth = 6;
            this.dgvRodzaj.Name = "dgvRodzaj";
            this.dgvRodzaj.ReadOnly = true;
            // 
            // dgvNumerRejestracyjny
            // 
            this.dgvNumerRejestracyjny.DataPropertyName = "numerRejestracyjny";
            this.dgvNumerRejestracyjny.HeaderText = "Numer rejestracyjny";
            this.dgvNumerRejestracyjny.MinimumWidth = 6;
            this.dgvNumerRejestracyjny.Name = "dgvNumerRejestracyjny";
            this.dgvNumerRejestracyjny.ReadOnly = true;
            // 
            // dgvIdPojazd
            // 
            this.dgvIdPojazd.DataPropertyName = "idPojazd";
            this.dgvIdPojazd.HeaderText = "ID";
            this.dgvIdPojazd.MinimumWidth = 6;
            this.dgvIdPojazd.Name = "dgvIdPojazd";
            this.dgvIdPojazd.ReadOnly = true;
            // 
            // ListaPojazdowDlaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ListaPojazdowDlaPracownika";
            this.Text = "ListaPojazdowDlaPracownika";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPojazd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsPojazd;
        private System.Windows.Forms.BindingSource pojazdBindingSource;
        private System.Windows.Forms.Button btModyfikuj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdPojazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumerRejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStanTechniczny;
    }
}