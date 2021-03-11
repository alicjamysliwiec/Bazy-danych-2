
namespace ZakładTransportowy
{
    partial class ZalogowanyKlient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalogowanyKlient));
            this.Powitanie = new System.Windows.Forms.Label();
            this.Pasek_stanu = new System.Windows.Forms.StatusStrip();
            this.ZalogowanyUzytkownik = new System.Windows.Forms.ToolStripStatusLabel();
            this.IdklientaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTwojeDane = new System.Windows.Forms.Button();
            this.btZamowienia = new System.Windows.Forms.Button();
            this.pOkno = new System.Windows.Forms.Panel();
            this.Pasek_stanu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Powitanie
            // 
            this.Powitanie.AutoSize = true;
            this.Powitanie.Location = new System.Drawing.Point(94, 57);
            this.Powitanie.Name = "Powitanie";
            this.Powitanie.Size = new System.Drawing.Size(0, 19);
            this.Powitanie.TabIndex = 0;
            // 
            // Pasek_stanu
            // 
            this.Pasek_stanu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Pasek_stanu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZalogowanyUzytkownik,
            this.IdklientaLabel});
            this.Pasek_stanu.Location = new System.Drawing.Point(0, 1029);
            this.Pasek_stanu.Name = "Pasek_stanu";
            this.Pasek_stanu.Size = new System.Drawing.Size(1133, 26);
            this.Pasek_stanu.TabIndex = 7;
            this.Pasek_stanu.Text = "statusStrip1";
            // 
            // ZalogowanyUzytkownik
            // 
            this.ZalogowanyUzytkownik.BackColor = System.Drawing.Color.White;
            this.ZalogowanyUzytkownik.Image = ((System.Drawing.Image)(resources.GetObject("ZalogowanyUzytkownik.Image")));
            this.ZalogowanyUzytkownik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZalogowanyUzytkownik.Name = "ZalogowanyUzytkownik";
            this.ZalogowanyUzytkownik.Size = new System.Drawing.Size(216, 20);
            this.ZalogowanyUzytkownik.Text = "Użytkownik: Alicja Myśliwiec";
            this.ZalogowanyUzytkownik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZalogowanyUzytkownik.Click += new System.EventHandler(this.ZalogowanyUzytkownik_Click);
            // 
            // IdklientaLabel
            // 
            this.IdklientaLabel.BackColor = System.Drawing.Color.White;
            this.IdklientaLabel.Name = "IdklientaLabel";
            this.IdklientaLabel.Size = new System.Drawing.Size(95, 20);
            this.IdklientaLabel.Text = "ID klienta: 12";
            this.IdklientaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pOkno, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 1029);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTwojeDane);
            this.panel1.Controls.Add(this.btZamowienia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 62);
            this.panel1.TabIndex = 0;
            // 
            // btTwojeDane
            // 
            this.btTwojeDane.BackColor = System.Drawing.Color.White;
            this.btTwojeDane.Image = ((System.Drawing.Image)(resources.GetObject("btTwojeDane.Image")));
            this.btTwojeDane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTwojeDane.Location = new System.Drawing.Point(204, 3);
            this.btTwojeDane.Name = "btTwojeDane";
            this.btTwojeDane.Size = new System.Drawing.Size(195, 56);
            this.btTwojeDane.TabIndex = 1;
            this.btTwojeDane.Text = "Twoje dane";
            this.btTwojeDane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTwojeDane.UseVisualStyleBackColor = false;
            this.btTwojeDane.Click += new System.EventHandler(this.btTwojeDane_Click);
            // 
            // btZamowienia
            // 
            this.btZamowienia.BackColor = System.Drawing.Color.White;
            this.btZamowienia.Image = ((System.Drawing.Image)(resources.GetObject("btZamowienia.Image")));
            this.btZamowienia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btZamowienia.Location = new System.Drawing.Point(3, 3);
            this.btZamowienia.Name = "btZamowienia";
            this.btZamowienia.Size = new System.Drawing.Size(195, 56);
            this.btZamowienia.TabIndex = 0;
            this.btZamowienia.Text = "Zamówienia";
            this.btZamowienia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btZamowienia.UseVisualStyleBackColor = false;
            this.btZamowienia.Click += new System.EventHandler(this.btZamowienia_Click);
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(3, 71);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(1127, 955);
            this.pOkno.TabIndex = 1;
            // 
            // ZalogowanyKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Pasek_stanu);
            this.Controls.Add(this.Powitanie);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ZalogowanyKlient";
            this.Text = "Witaj!";
            this.Pasek_stanu.ResumeLayout(false);
            this.Pasek_stanu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie;
        private System.Windows.Forms.StatusStrip Pasek_stanu;
        private System.Windows.Forms.ToolStripStatusLabel ZalogowanyUzytkownik;
        private System.Windows.Forms.ToolStripStatusLabel IdklientaLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTwojeDane;
        private System.Windows.Forms.Button btZamowienia;
        private System.Windows.Forms.Panel pOkno;
    }
}