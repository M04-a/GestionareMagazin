namespace Gestionare_produse
{
    partial class Autentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.ComboBox();
            this.textParola = new System.Windows.Forms.TextBox();
            this.btn_aut = new System.Windows.Forms.Button();
            this.btn_inreg = new System.Windows.Forms.Button();
            this.btn_iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // textNume
            // 
            this.textNume.BackColor = System.Drawing.SystemColors.Menu;
            this.textNume.Cursor = System.Windows.Forms.Cursors.Help;
            this.textNume.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNume.FormattingEnabled = true;
            this.textNume.Location = new System.Drawing.Point(139, 112);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(221, 25);
            this.textNume.TabIndex = 2;
            this.textNume.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textParola
            // 
            this.textParola.BackColor = System.Drawing.SystemColors.Menu;
            this.textParola.Cursor = System.Windows.Forms.Cursors.Help;
            this.textParola.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textParola.Location = new System.Drawing.Point(139, 148);
            this.textParola.Name = "textParola";
            this.textParola.PasswordChar = '*';
            this.textParola.Size = new System.Drawing.Size(221, 25);
            this.textParola.TabIndex = 3;
            this.textParola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_aut
            // 
            this.btn_aut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_aut.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_aut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aut.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aut.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_aut.Location = new System.Drawing.Point(20, 221);
            this.btn_aut.Name = "btn_aut";
            this.btn_aut.Size = new System.Drawing.Size(164, 27);
            this.btn_aut.TabIndex = 4;
            this.btn_aut.Text = "Autentificare";
            this.btn_aut.UseVisualStyleBackColor = false;
            this.btn_aut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_inreg
            // 
            this.btn_inreg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inreg.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_inreg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inreg.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inreg.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_inreg.Location = new System.Drawing.Point(218, 221);
            this.btn_inreg.Name = "btn_inreg";
            this.btn_inreg.Size = new System.Drawing.Size(164, 27);
            this.btn_inreg.TabIndex = 5;
            this.btn_inreg.Text = "Inregistrare";
            this.btn_inreg.UseVisualStyleBackColor = false;
            this.btn_inreg.Click += new System.EventHandler(this.btn_inreg_Click);
            // 
            // btn_iesire
            // 
            this.btn_iesire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_iesire.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_iesire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iesire.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iesire.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_iesire.Location = new System.Drawing.Point(401, 221);
            this.btn_iesire.Name = "btn_iesire";
            this.btn_iesire.Size = new System.Drawing.Size(164, 27);
            this.btn_iesire.TabIndex = 6;
            this.btn_iesire.Text = "Iesire";
            this.btn_iesire.UseVisualStyleBackColor = false;
            this.btn_iesire.Click += new System.EventHandler(this.btn_iesire_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.btn_iesire);
            this.Controls.Add(this.btn_inreg);
            this.Controls.Add(this.btn_aut);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox textNume;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Button btn_aut;
        private System.Windows.Forms.Button btn_inreg;
        private System.Windows.Forms.Button btn_iesire;
    }
}

