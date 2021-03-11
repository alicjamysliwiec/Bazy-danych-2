
namespace ZakładTransportowy
{
    partial class OknoLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoLogowania));
            this.tlpInterfejs = new System.Windows.Forms.TableLayoutPanel();
            this.pInterfejs = new System.Windows.Forms.Panel();
            this.btnKlient = new System.Windows.Forms.Button();
            this.btnPracownik = new System.Windows.Forms.Button();
            this.btnWlasciciel = new System.Windows.Forms.Button();
            this.pOkno = new System.Windows.Forms.Panel();
            this.tlpInterfejs.SuspendLayout();
            this.pInterfejs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpInterfejs
            // 
            this.tlpInterfejs.ColumnCount = 1;
            this.tlpInterfejs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInterfejs.Controls.Add(this.pInterfejs, 0, 0);
            this.tlpInterfejs.Controls.Add(this.pOkno, 0, 1);
            this.tlpInterfejs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInterfejs.Location = new System.Drawing.Point(0, 0);
            this.tlpInterfejs.Name = "tlpInterfejs";
            this.tlpInterfejs.RowCount = 2;
            this.tlpInterfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpInterfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInterfejs.Size = new System.Drawing.Size(465, 445);
            this.tlpInterfejs.TabIndex = 0;
            // 
            // pInterfejs
            // 
            this.pInterfejs.Controls.Add(this.btnWlasciciel);
            this.pInterfejs.Controls.Add(this.btnPracownik);
            this.pInterfejs.Controls.Add(this.btnKlient);
            this.pInterfejs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInterfejs.Location = new System.Drawing.Point(3, 3);
            this.pInterfejs.Name = "pInterfejs";
            this.pInterfejs.Size = new System.Drawing.Size(459, 62);
            this.pInterfejs.TabIndex = 0;
            // 
            // btnKlient
            // 
            this.btnKlient.BackColor = System.Drawing.Color.White;
            this.btnKlient.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlient.Image = ((System.Drawing.Image)(resources.GetObject("btnKlient.Image")));
            this.btnKlient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlient.Location = new System.Drawing.Point(3, 3);
            this.btnKlient.Name = "btnKlient";
            this.btnKlient.Size = new System.Drawing.Size(146, 54);
            this.btnKlient.TabIndex = 0;
            this.btnKlient.Text = "Klient";
            this.btnKlient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKlient.UseVisualStyleBackColor = false;
            this.btnKlient.Click += new System.EventHandler(this.btnKlient_Click);
            // 
            // btnPracownik
            // 
            this.btnPracownik.BackColor = System.Drawing.Color.White;
            this.btnPracownik.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownik.Image = ((System.Drawing.Image)(resources.GetObject("btnPracownik.Image")));
            this.btnPracownik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracownik.Location = new System.Drawing.Point(155, 3);
            this.btnPracownik.Name = "btnPracownik";
            this.btnPracownik.Size = new System.Drawing.Size(146, 54);
            this.btnPracownik.TabIndex = 1;
            this.btnPracownik.Text = "Pracownik";
            this.btnPracownik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPracownik.UseVisualStyleBackColor = false;
            this.btnPracownik.Click += new System.EventHandler(this.btnPracownik_Click);
            // 
            // btnWlasciciel
            // 
            this.btnWlasciciel.BackColor = System.Drawing.Color.White;
            this.btnWlasciciel.Image = ((System.Drawing.Image)(resources.GetObject("btnWlasciciel.Image")));
            this.btnWlasciciel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWlasciciel.Location = new System.Drawing.Point(307, 3);
            this.btnWlasciciel.Name = "btnWlasciciel";
            this.btnWlasciciel.Size = new System.Drawing.Size(146, 54);
            this.btnWlasciciel.TabIndex = 2;
            this.btnWlasciciel.Text = "Właściciel";
            this.btnWlasciciel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWlasciciel.UseVisualStyleBackColor = false;
            this.btnWlasciciel.Click += new System.EventHandler(this.btnWlasciciel_Click);
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(3, 71);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(459, 371);
            this.pOkno.TabIndex = 1;
            this.pOkno.Paint += new System.Windows.Forms.PaintEventHandler(this.pOkno_Paint);
            // 
            // OknoLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 445);
            this.Controls.Add(this.tlpInterfejs);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "OknoLogowania";
            this.Text = "Witamy!";
            this.tlpInterfejs.ResumeLayout(false);
            this.pInterfejs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInterfejs;
        private System.Windows.Forms.Panel pInterfejs;
        private System.Windows.Forms.Button btnWlasciciel;
        private System.Windows.Forms.Button btnPracownik;
        private System.Windows.Forms.Button btnKlient;
        private System.Windows.Forms.Panel pOkno;
    }
}