
namespace ZakładTransportowy
{
    partial class PanelKlienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelKlienta));
            this.tlpPanelKlienta = new System.Windows.Forms.TableLayoutPanel();
            this.pPanelKlienta = new System.Windows.Forms.Panel();
            this.btnZalogowanie = new System.Windows.Forms.Button();
            this.btnTworzenieKonta = new System.Windows.Forms.Button();
            this.pOkno = new System.Windows.Forms.Panel();
            this.tlpPanelKlienta.SuspendLayout();
            this.pPanelKlienta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPanelKlienta
            // 
            this.tlpPanelKlienta.ColumnCount = 1;
            this.tlpPanelKlienta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanelKlienta.Controls.Add(this.pPanelKlienta, 0, 0);
            this.tlpPanelKlienta.Controls.Add(this.pOkno, 0, 1);
            this.tlpPanelKlienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanelKlienta.Location = new System.Drawing.Point(0, 0);
            this.tlpPanelKlienta.Name = "tlpPanelKlienta";
            this.tlpPanelKlienta.RowCount = 2;
            this.tlpPanelKlienta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpPanelKlienta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanelKlienta.Size = new System.Drawing.Size(336, 604);
            this.tlpPanelKlienta.TabIndex = 0;
            // 
            // pPanelKlienta
            // 
            this.pPanelKlienta.Controls.Add(this.btnTworzenieKonta);
            this.pPanelKlienta.Controls.Add(this.btnZalogowanie);
            this.pPanelKlienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPanelKlienta.Location = new System.Drawing.Point(3, 3);
            this.pPanelKlienta.Name = "pPanelKlienta";
            this.pPanelKlienta.Size = new System.Drawing.Size(330, 54);
            this.pPanelKlienta.TabIndex = 0;
            // 
            // btnZalogowanie
            // 
            this.btnZalogowanie.BackColor = System.Drawing.Color.White;
            this.btnZalogowanie.Image = ((System.Drawing.Image)(resources.GetObject("btnZalogowanie.Image")));
            this.btnZalogowanie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZalogowanie.Location = new System.Drawing.Point(3, 3);
            this.btnZalogowanie.Name = "btnZalogowanie";
            this.btnZalogowanie.Size = new System.Drawing.Size(157, 48);
            this.btnZalogowanie.TabIndex = 0;
            this.btnZalogowanie.Text = "Zaloguj się";
            this.btnZalogowanie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZalogowanie.UseVisualStyleBackColor = false;
            this.btnZalogowanie.Click += new System.EventHandler(this.btnZalogowanie_Click);
            // 
            // btnTworzenieKonta
            // 
            this.btnTworzenieKonta.BackColor = System.Drawing.Color.White;
            this.btnTworzenieKonta.Image = ((System.Drawing.Image)(resources.GetObject("btnTworzenieKonta.Image")));
            this.btnTworzenieKonta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTworzenieKonta.Location = new System.Drawing.Point(166, 3);
            this.btnTworzenieKonta.Name = "btnTworzenieKonta";
            this.btnTworzenieKonta.Size = new System.Drawing.Size(155, 48);
            this.btnTworzenieKonta.TabIndex = 1;
            this.btnTworzenieKonta.Text = "Utwórz konto";
            this.btnTworzenieKonta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTworzenieKonta.UseVisualStyleBackColor = false;
            this.btnTworzenieKonta.Click += new System.EventHandler(this.btnTworzenieKonta_Click);
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(3, 63);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(330, 538);
            this.pOkno.TabIndex = 1;
            // 
            // PanelKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 604);
            this.Controls.Add(this.tlpPanelKlienta);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "PanelKlienta";
            this.Text = "Panel Klienta";
            this.tlpPanelKlienta.ResumeLayout(false);
            this.pPanelKlienta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPanelKlienta;
        private System.Windows.Forms.Panel pPanelKlienta;
        private System.Windows.Forms.Button btnTworzenieKonta;
        private System.Windows.Forms.Button btnZalogowanie;
        private System.Windows.Forms.Panel pOkno;
    }
}