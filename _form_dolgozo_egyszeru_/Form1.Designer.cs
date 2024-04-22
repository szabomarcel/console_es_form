namespace _form_dolgozo_egyszeru_
{
    partial class Form1
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
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Reszleg = new System.Windows.Forms.TextBox();
            this.textBox_Neme = new System.Windows.Forms.TextBox();
            this.textBox_Belepesev = new System.Windows.Forms.TextBox();
            this.textBox_Ber = new System.Windows.Forms.TextBox();
            this.button_Feltoltes = new System.Windows.Forms.Button();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(12, 12);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(120, 290);
            this.listBox_Dolgozok.TabIndex = 0;
            this.listBox_Dolgozok.SelectedIndexChanged += new System.EventHandler(this.listBox_Dolgozok_SelectedIndexChanged);
            // 
            // button_Reset
            // 
            this.button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reset.Location = new System.Drawing.Point(12, 309);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(120, 23);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Neme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Részleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Belépésév:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bér:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(139, 30);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nev.TabIndex = 9;
            // 
            // textBox_Reszleg
            // 
            this.textBox_Reszleg.Location = new System.Drawing.Point(138, 80);
            this.textBox_Reszleg.Name = "textBox_Reszleg";
            this.textBox_Reszleg.Size = new System.Drawing.Size(100, 20);
            this.textBox_Reszleg.TabIndex = 10;
            // 
            // textBox_Neme
            // 
            this.textBox_Neme.Location = new System.Drawing.Point(260, 29);
            this.textBox_Neme.Name = "textBox_Neme";
            this.textBox_Neme.Size = new System.Drawing.Size(100, 20);
            this.textBox_Neme.TabIndex = 11;
            // 
            // textBox_Belepesev
            // 
            this.textBox_Belepesev.Location = new System.Drawing.Point(260, 80);
            this.textBox_Belepesev.Name = "textBox_Belepesev";
            this.textBox_Belepesev.Size = new System.Drawing.Size(100, 20);
            this.textBox_Belepesev.TabIndex = 12;
            // 
            // textBox_Ber
            // 
            this.textBox_Ber.Location = new System.Drawing.Point(138, 129);
            this.textBox_Ber.Name = "textBox_Ber";
            this.textBox_Ber.Size = new System.Drawing.Size(222, 20);
            this.textBox_Ber.TabIndex = 15;
            // 
            // button_Feltoltes
            // 
            this.button_Feltoltes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Feltoltes.Location = new System.Drawing.Point(138, 188);
            this.button_Feltoltes.Name = "button_Feltoltes";
            this.button_Feltoltes.Size = new System.Drawing.Size(222, 23);
            this.button_Feltoltes.TabIndex = 16;
            this.button_Feltoltes.Text = "Feltöltés";
            this.button_Feltoltes.UseVisualStyleBackColor = true;
            this.button_Feltoltes.Click += new System.EventHandler(this.button_Feltoltes_Click);
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Betoltes.Location = new System.Drawing.Point(138, 156);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(222, 23);
            this.button_Betoltes.TabIndex = 17;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 346);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.button_Feltoltes);
            this.Controls.Add(this.textBox_Ber);
            this.Controls.Add(this.textBox_Belepesev);
            this.Controls.Add(this.textBox_Neme);
            this.Controls.Add(this.textBox_Reszleg);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.listBox_Dolgozok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "dolgozo_vizsgaszeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dolgozok;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Reszleg;
        private System.Windows.Forms.TextBox textBox_Neme;
        private System.Windows.Forms.TextBox textBox_Belepesev;
        private System.Windows.Forms.TextBox textBox_Ber;
        private System.Windows.Forms.Button button_Feltoltes;
        private System.Windows.Forms.Button button_Betoltes;
    }
}

