namespace judeteana_02
{
    partial class SpiralaForm
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chkMargini = new System.Windows.Forms.CheckBox();
            this.chkUmplere = new System.Windows.Forms.CheckBox();
            this.chkEtichete = new System.Windows.Forms.CheckBox();
            this.btnDeseneaza = new System.Windows.Forms.Button();
            this.btnReseteaza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(646, 9);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(106, 13);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Spirala lui Theodorus";
            // 
            // txtNumar
            // 
            this.txtNumar.Location = new System.Drawing.Point(649, 36);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(100, 20);
            this.txtNumar.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(134, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 3;
            // 
            // chkMargini
            // 
            this.chkMargini.AutoSize = true;
            this.chkMargini.Location = new System.Drawing.Point(649, 147);
            this.chkMargini.Name = "chkMargini";
            this.chkMargini.Size = new System.Drawing.Size(60, 17);
            this.chkMargini.TabIndex = 4;
            this.chkMargini.Text = "Margini";
            this.chkMargini.UseVisualStyleBackColor = true;
            // 
            // chkUmplere
            // 
            this.chkUmplere.AutoSize = true;
            this.chkUmplere.Location = new System.Drawing.Point(649, 103);
            this.chkUmplere.Name = "chkUmplere";
            this.chkUmplere.Size = new System.Drawing.Size(65, 17);
            this.chkUmplere.TabIndex = 5;
            this.chkUmplere.Text = "Umplere";
            this.chkUmplere.UseVisualStyleBackColor = true;
            // 
            // chkEtichete
            // 
            this.chkEtichete.AutoSize = true;
            this.chkEtichete.Location = new System.Drawing.Point(649, 192);
            this.chkEtichete.Name = "chkEtichete";
            this.chkEtichete.Size = new System.Drawing.Size(65, 17);
            this.chkEtichete.TabIndex = 6;
            this.chkEtichete.Text = "Etichete";
            this.chkEtichete.UseVisualStyleBackColor = true;
            // 
            // btnDeseneaza
            // 
            this.btnDeseneaza.Location = new System.Drawing.Point(625, 405);
            this.btnDeseneaza.Name = "btnDeseneaza";
            this.btnDeseneaza.Size = new System.Drawing.Size(75, 23);
            this.btnDeseneaza.TabIndex = 7;
            this.btnDeseneaza.Text = "Deseneaza";
            this.btnDeseneaza.UseVisualStyleBackColor = true;
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.Location = new System.Drawing.Point(723, 405);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(75, 23);
            this.btnReseteaza.TabIndex = 8;
            this.btnReseteaza.Text = "Reseteaza";
            this.btnReseteaza.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-7, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SpiralaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReseteaza);
            this.Controls.Add(this.btnDeseneaza);
            this.Controls.Add(this.chkEtichete);
            this.Controls.Add(this.chkUmplere);
            this.Controls.Add(this.chkMargini);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.lblTitlu);
            this.Name = "SpiralaForm";
            this.Text = "SpiralaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkMargini;
        private System.Windows.Forms.CheckBox chkUmplere;
        private System.Windows.Forms.CheckBox chkEtichete;
        private System.Windows.Forms.Button btnDeseneaza;
        private System.Windows.Forms.Button btnReseteaza;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}