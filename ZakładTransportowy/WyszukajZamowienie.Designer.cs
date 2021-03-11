
namespace ZakładTransportowy
{
    partial class WyszukajZamowienie
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj ID zamówienia";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(156, 21);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(242, 22);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // WyszukajZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 216);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "WyszukajZamowienie";
            this.Text = "Wyszukaj zamówienie";
            this.Load += new System.EventHandler(this.WyszukajZamowienie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
    }
}