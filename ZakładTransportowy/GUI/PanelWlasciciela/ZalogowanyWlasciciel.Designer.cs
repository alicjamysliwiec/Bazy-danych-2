
namespace ZakładTransportowy
{
    partial class ZalogowanyWlasciciel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalogowanyWlasciciel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Pojazdy = new System.Windows.Forms.Button();
            this.btnPojazdy = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.pOkno = new System.Windows.Forms.Panel();
            this.pojazdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 738);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Pojazdy);
            this.panel1.Controls.Add(this.btnPojazdy);
            this.panel1.Controls.Add(this.btnPracownicy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_Pojazdy
            // 
            this.btn_Pojazdy.BackColor = System.Drawing.Color.White;
            this.btn_Pojazdy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pojazdy.Image")));
            this.btn_Pojazdy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pojazdy.Location = new System.Drawing.Point(381, 3);
            this.btn_Pojazdy.Name = "btn_Pojazdy";
            this.btn_Pojazdy.Size = new System.Drawing.Size(183, 48);
            this.btn_Pojazdy.TabIndex = 2;
            this.btn_Pojazdy.Text = "Statystyki";
            this.btn_Pojazdy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pojazdy.UseVisualStyleBackColor = false;
            this.btn_Pojazdy.Click += new System.EventHandler(this.btn_Pojazdy_Click);
            // 
            // btnPojazdy
            // 
            this.btnPojazdy.BackColor = System.Drawing.Color.White;
            this.btnPojazdy.Image = ((System.Drawing.Image)(resources.GetObject("btnPojazdy.Image")));
            this.btnPojazdy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPojazdy.Location = new System.Drawing.Point(192, 3);
            this.btnPojazdy.Name = "btnPojazdy";
            this.btnPojazdy.Size = new System.Drawing.Size(183, 48);
            this.btnPojazdy.TabIndex = 1;
            this.btnPojazdy.Text = "Pojazdy";
            this.btnPojazdy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPojazdy.UseVisualStyleBackColor = false;
            this.btnPojazdy.Click += new System.EventHandler(this.btnPojazdy_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.BackColor = System.Drawing.Color.White;
            this.btnPracownicy.Image = ((System.Drawing.Image)(resources.GetObject("btnPracownicy.Image")));
            this.btnPracownicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracownicy.Location = new System.Drawing.Point(3, 3);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(183, 48);
            this.btnPracownicy.TabIndex = 0;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPracownicy.UseVisualStyleBackColor = false;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(3, 63);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(993, 672);
            this.pOkno.TabIndex = 1;
            // 
            // pojazdBindingSource
            // 
            this.pojazdBindingSource.DataSource = typeof(ZakładTransportowy.Pojazd);
            // 
            // ZalogowanyWlasciciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ZalogowanyWlasciciel";
            this.Text = "Witaj Janusz!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pojazdy;
        private System.Windows.Forms.Button btnPojazdy;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.BindingSource pojazdBindingSource;
        private System.Windows.Forms.Panel pOkno;
    }
}