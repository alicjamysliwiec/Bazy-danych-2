
namespace ZakładTransportowy
{
    partial class RozliczenieZamowienia
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
            this.cbFormaPlatnosci = new System.Windows.Forms.ComboBox();
            this.cbFormaRozliczenia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFormaRozliczenia);
            this.panel1.Controls.Add(this.cbFormaPlatnosci);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 420);
            this.panel1.TabIndex = 0;
            // 
            // cbFormaPlatnosci
            // 
            this.cbFormaPlatnosci.FormattingEnabled = true;
            this.cbFormaPlatnosci.Items.AddRange(new object[] {
            "GOTOWKA",
            "KARTA PLATNICZA",
            "PRZELEW"});
            this.cbFormaPlatnosci.Location = new System.Drawing.Point(273, 88);
            this.cbFormaPlatnosci.Name = "cbFormaPlatnosci";
            this.cbFormaPlatnosci.Size = new System.Drawing.Size(182, 26);
            this.cbFormaPlatnosci.TabIndex = 0;
            this.cbFormaPlatnosci.SelectedIndexChanged += new System.EventHandler(this.cbFormaPlatnosci_SelectedIndexChanged);
            // 
            // cbFormaRozliczenia
            // 
            this.cbFormaRozliczenia.FormattingEnabled = true;
            this.cbFormaRozliczenia.Items.AddRange(new object[] {
            "PARAGON",
            "FAKTURA"});
            this.cbFormaRozliczenia.Location = new System.Drawing.Point(273, 202);
            this.cbFormaRozliczenia.Name = "cbFormaRozliczenia";
            this.cbFormaRozliczenia.Size = new System.Drawing.Size(182, 26);
            this.cbFormaRozliczenia.TabIndex = 1;
            this.cbFormaRozliczenia.SelectedIndexChanged += new System.EventHandler(this.cbFormaRozliczenia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz formę płatności";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz formę rozliczenia";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(208, 319);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(98, 41);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // RozliczenieZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 420);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "RozliczenieZamowienia";
            this.Text = "RozliczenieZamowienia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormaRozliczenia;
        private System.Windows.Forms.ComboBox cbFormaPlatnosci;
    }
}