
namespace ZakładTransportowy
{
    partial class LogowanieKlienta
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Podanie_loginu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.niepoprawneDane = new System.Windows.Forms.Label();
            this.pOkno = new System.Windows.Forms.Panel();
            this.pOkno.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(151, 117);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(295, 23);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Podanie_loginu
            // 
            this.Podanie_loginu.AutoSize = true;
            this.Podanie_loginu.Location = new System.Drawing.Point(34, 120);
            this.Podanie_loginu.Name = "Podanie_loginu";
            this.Podanie_loginu.Size = new System.Drawing.Size(87, 19);
            this.Podanie_loginu.TabIndex = 1;
            this.Podanie_loginu.Text = "Podaj login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wpisz hasło";
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(151, 176);
            this.Haslo.Name = "Haslo";
            this.Haslo.PasswordChar = '*';
            this.Haslo.Size = new System.Drawing.Size(295, 23);
            this.Haslo.TabIndex = 3;
            this.Haslo.TextChanged += new System.EventHandler(this.Haslo_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(181, 239);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 46);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // niepoprawneDane
            // 
            this.niepoprawneDane.AutoSize = true;
            this.niepoprawneDane.Location = new System.Drawing.Point(177, 428);
            this.niepoprawneDane.Name = "niepoprawneDane";
            this.niepoprawneDane.Size = new System.Drawing.Size(0, 19);
            this.niepoprawneDane.TabIndex = 5;
            // 
            // pOkno
            // 
            this.pOkno.BackColor = System.Drawing.Color.White;
            this.pOkno.Controls.Add(this.Login);
            this.pOkno.Controls.Add(this.Haslo);
            this.pOkno.Controls.Add(this.OK);
            this.pOkno.Controls.Add(this.Podanie_loginu);
            this.pOkno.Controls.Add(this.label1);
            this.pOkno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOkno.Location = new System.Drawing.Point(0, 0);
            this.pOkno.Name = "pOkno";
            this.pOkno.Size = new System.Drawing.Size(497, 380);
            this.pOkno.TabIndex = 6;
            // 
            // LogowanieKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 380);
            this.Controls.Add(this.pOkno);
            this.Controls.Add(this.niepoprawneDane);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "LogowanieKlienta";
            this.Text = "Logowanie";
            this.pOkno.ResumeLayout(false);
            this.pOkno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Podanie_loginu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label niepoprawneDane;
        private System.Windows.Forms.Panel pOkno;
    }
}