
namespace ZakładTransportowy
{
    partial class LogowaniePracownika
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
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.hasloText = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wprowadź hasło";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(173, 90);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(242, 23);
            this.loginText.TabIndex = 2;
            this.loginText.TextChanged += new System.EventHandler(this.loginText_TextChanged);
            // 
            // hasloText
            // 
            this.hasloText.Location = new System.Drawing.Point(173, 162);
            this.hasloText.Name = "hasloText";
            this.hasloText.PasswordChar = '*';
            this.hasloText.Size = new System.Drawing.Size(242, 23);
            this.hasloText.TabIndex = 3;
            this.hasloText.TextChanged += new System.EventHandler(this.hasloText_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(213, 233);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 46);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.hasloText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 351);
            this.panel1.TabIndex = 5;
            // 
            // LogowaniePracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "LogowaniePracownika";
            this.Text = "Zaloguj się";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox hasloText;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel panel1;
    }
}