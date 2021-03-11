
namespace ZakładTransportowy
{
    partial class DodawaniePojazdu
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
            this.tbNumerRejestracyjny = new System.Windows.Forms.TextBox();
            this.cbRodzaj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbRodzaj);
            this.panel1.Controls.Add(this.tbNumerRejestracyjny);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 389);
            this.panel1.TabIndex = 0;
            // 
            // tbNumerRejestracyjny
            // 
            this.tbNumerRejestracyjny.Location = new System.Drawing.Point(237, 96);
            this.tbNumerRejestracyjny.Name = "tbNumerRejestracyjny";
            this.tbNumerRejestracyjny.Size = new System.Drawing.Size(174, 23);
            this.tbNumerRejestracyjny.TabIndex = 0;
            this.tbNumerRejestracyjny.TextChanged += new System.EventHandler(this.tbNumerRejestracyjny_TextChanged);
            // 
            // cbRodzaj
            // 
            this.cbRodzaj.FormattingEnabled = true;
            this.cbRodzaj.Items.AddRange(new object[] {
            "BUS",
            "TIR",
            "CIĘŻARÓWKA",
            "CYSTERNA",
            "OSOBÓWKA"});
            this.cbRodzaj.Location = new System.Drawing.Point(237, 152);
            this.cbRodzaj.Name = "cbRodzaj";
            this.cbRodzaj.Size = new System.Drawing.Size(174, 26);
            this.cbRodzaj.TabIndex = 1;
            this.cbRodzaj.SelectedIndexChanged += new System.EventHandler(this.cbRodzaj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer rejestracyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rodzaj";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(237, 233);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(113, 44);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // DodawaniePojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 389);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "DodawaniePojazdu";
            this.Text = "Dodaj pojazd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRodzaj;
        private System.Windows.Forms.TextBox tbNumerRejestracyjny;
    }
}