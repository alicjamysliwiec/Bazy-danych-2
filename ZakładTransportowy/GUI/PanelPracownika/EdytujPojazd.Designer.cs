
namespace ZakładTransportowy
{
    partial class EdytujPojazd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPojazd = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.dtpDataPrzegladu = new System.Windows.Forms.DateTimePicker();
            this.cbStanTechniczny = new System.Windows.Forms.ComboBox();
            this.lbRodzaj = new System.Windows.Forms.Label();
            this.lbNumerRejestracyjny = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbPojazd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPojazd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 506);
            this.panel1.TabIndex = 0;
            // 
            // gbPojazd
            // 
            this.gbPojazd.BackColor = System.Drawing.Color.White;
            this.gbPojazd.Controls.Add(this.btOK);
            this.gbPojazd.Controls.Add(this.dtpDataPrzegladu);
            this.gbPojazd.Controls.Add(this.cbStanTechniczny);
            this.gbPojazd.Controls.Add(this.lbRodzaj);
            this.gbPojazd.Controls.Add(this.lbNumerRejestracyjny);
            this.gbPojazd.Controls.Add(this.lbID);
            this.gbPojazd.Controls.Add(this.label5);
            this.gbPojazd.Controls.Add(this.label4);
            this.gbPojazd.Controls.Add(this.label3);
            this.gbPojazd.Controls.Add(this.label2);
            this.gbPojazd.Controls.Add(this.label1);
            this.gbPojazd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPojazd.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPojazd.Location = new System.Drawing.Point(0, 0);
            this.gbPojazd.Name = "gbPojazd";
            this.gbPojazd.Size = new System.Drawing.Size(800, 506);
            this.gbPojazd.TabIndex = 0;
            this.gbPojazd.TabStop = false;
            this.gbPojazd.Text = "Dane";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(312, 368);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(132, 43);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dtpDataPrzegladu
            // 
            this.dtpDataPrzegladu.Location = new System.Drawing.Point(323, 166);
            this.dtpDataPrzegladu.Name = "dtpDataPrzegladu";
            this.dtpDataPrzegladu.Size = new System.Drawing.Size(291, 23);
            this.dtpDataPrzegladu.TabIndex = 9;
            this.dtpDataPrzegladu.ValueChanged += new System.EventHandler(this.dtpDataPrzegladu_ValueChanged);
            // 
            // cbStanTechniczny
            // 
            this.cbStanTechniczny.FormattingEnabled = true;
            this.cbStanTechniczny.Items.AddRange(new object[] {
            "SPRAWNY",
            "DO NAPRAWY",
            "W NAPRAWIE",
            "POTRZEBNY PRZEGLAD"});
            this.cbStanTechniczny.Location = new System.Drawing.Point(323, 224);
            this.cbStanTechniczny.Name = "cbStanTechniczny";
            this.cbStanTechniczny.Size = new System.Drawing.Size(291, 26);
            this.cbStanTechniczny.TabIndex = 8;
            this.cbStanTechniczny.SelectedIndexChanged += new System.EventHandler(this.cbStanTechniczny_SelectedIndexChanged);
            // 
            // lbRodzaj
            // 
            this.lbRodzaj.AutoSize = true;
            this.lbRodzaj.Location = new System.Drawing.Point(319, 285);
            this.lbRodzaj.Name = "lbRodzaj";
            this.lbRodzaj.Size = new System.Drawing.Size(52, 19);
            this.lbRodzaj.TabIndex = 7;
            this.lbRodzaj.Text = "label6";
            // 
            // lbNumerRejestracyjny
            // 
            this.lbNumerRejestracyjny.AutoSize = true;
            this.lbNumerRejestracyjny.Location = new System.Drawing.Point(319, 120);
            this.lbNumerRejestracyjny.Name = "lbNumerRejestracyjny";
            this.lbNumerRejestracyjny.Size = new System.Drawing.Size(52, 19);
            this.lbNumerRejestracyjny.TabIndex = 6;
            this.lbNumerRejestracyjny.Text = "label6";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(319, 73);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(52, 19);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rodzaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stan techniczny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data ostatniego przeglądu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numer rejestracyjny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EdytujPojazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EdytujPojazd";
            this.Text = "EdytujPojazd";
            this.panel1.ResumeLayout(false);
            this.gbPojazd.ResumeLayout(false);
            this.gbPojazd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPojazd;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DateTimePicker dtpDataPrzegladu;
        private System.Windows.Forms.ComboBox cbStanTechniczny;
        private System.Windows.Forms.Label lbRodzaj;
        private System.Windows.Forms.Label lbNumerRejestracyjny;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}