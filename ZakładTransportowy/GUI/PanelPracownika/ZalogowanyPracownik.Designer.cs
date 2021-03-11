
namespace ZakładTransportowy
{
    partial class ZalogowanyPracownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalogowanyPracownik));
            this.Powitanie = new System.Windows.Forms.Label();
            this.Klienci = new System.Windows.Forms.Button();
            this.Pojazdy = new System.Windows.Forms.Button();
            this.Zamowienia = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pOkno = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pOkno.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Powitanie
            // 
            this.Powitanie.AutoSize = true;
            this.Powitanie.Location = new System.Drawing.Point(156, 57);
            this.Powitanie.Name = "Powitanie";
            this.Powitanie.Size = new System.Drawing.Size(0, 19);
            this.Powitanie.TabIndex = 0;
            // 
            // Klienci
            // 
            this.Klienci.BackColor = System.Drawing.Color.White;
            this.Klienci.Image = ((System.Drawing.Image)(resources.GetObject("Klienci.Image")));
            this.Klienci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Klienci.Location = new System.Drawing.Point(355, 3);
            this.Klienci.Name = "Klienci";
            this.Klienci.Size = new System.Drawing.Size(170, 56);
            this.Klienci.TabIndex = 3;
            this.Klienci.Text = "Klienci";
            this.Klienci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Klienci.UseVisualStyleBackColor = false;
            this.Klienci.Click += new System.EventHandler(this.Klienci_Click);
            // 
            // Pojazdy
            // 
            this.Pojazdy.BackColor = System.Drawing.Color.White;
            this.Pojazdy.Image = ((System.Drawing.Image)(resources.GetObject("Pojazdy.Image")));
            this.Pojazdy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pojazdy.Location = new System.Drawing.Point(179, 4);
            this.Pojazdy.Name = "Pojazdy";
            this.Pojazdy.Size = new System.Drawing.Size(170, 56);
            this.Pojazdy.TabIndex = 4;
            this.Pojazdy.Text = "Pojazdy";
            this.Pojazdy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pojazdy.UseVisualStyleBackColor = false;
            this.Pojazdy.Click += new System.EventHandler(this.Pojazdy_Click);
            // 
            // Zamowienia
            // 
            this.Zamowienia.BackColor = System.Drawing.Color.White;
            this.Zamowienia.Image = ((System.Drawing.Image)(resources.GetObject("Zamowienia.Image")));
            this.Zamowienia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Zamowienia.Location = new System.Drawing.Point(3, 4);
            this.Zamowienia.Name = "Zamowienia";
            this.Zamowienia.Size = new System.Drawing.Size(170, 56);
            this.Zamowienia.TabIndex = 5;
            this.Zamowienia.Text = "Zamówienia";
            this.Zamowienia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zamowienia.UseVisualStyleBackColor = false;
            this.Zamowienia.Click += new System.EventHandler(this.Zamowienia_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 561);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Zamowienia);
            this.panel1.Controls.Add(this.Klienci);
            this.panel1.Controls.Add(this.Pojazdy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 62);
            this.panel1.TabIndex = 0;
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Controls.Add(this.statusStrip1);
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(3, 71);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(824, 487);
            this.pOkno.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1,
            this.label2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.Text = "Pracownik: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.Text = "toolStripStatusLabel1";
            // 
            // ZalogowanyPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Powitanie);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ZalogowanyPracownik";
            this.Text = "Witaj!";
            this.Load += new System.EventHandler(this.ZalogowanyPracownik_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pOkno.ResumeLayout(false);
            this.pOkno.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Powitanie;
        private System.Windows.Forms.Button Klienci;
        private System.Windows.Forms.Button Pojazdy;
        private System.Windows.Forms.Button Zamowienia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pOkno;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label1;
        private System.Windows.Forms.ToolStripStatusLabel label2;
    }
}