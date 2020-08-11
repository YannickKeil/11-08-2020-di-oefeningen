namespace oefening_2
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
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbStraat = new System.Windows.Forms.MaskedTextBox();
            this.gbNaam = new System.Windows.Forms.GroupBox();
            this.lVoornaam = new System.Windows.Forms.Label();
            this.lAchternaam = new System.Windows.Forms.Label();
            this.gbAdress = new System.Windows.Forms.GroupBox();
            this.lStraat = new System.Windows.Forms.Label();
            this.lPostcode = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.lNummer = new System.Windows.Forms.Label();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.tbGemeente = new System.Windows.Forms.TextBox();
            this.lGemeente = new System.Windows.Forms.Label();
            this.nudLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.lLeeftijd = new System.Windows.Forms.Label();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.gbProvincie = new System.Windows.Forms.GroupBox();
            this.rbAntwerpen = new System.Windows.Forms.RadioButton();
            this.rbLimburg = new System.Windows.Forms.RadioButton();
            this.rbOostVlaanderen = new System.Windows.Forms.RadioButton();
            this.rbVlaamsBrabant = new System.Windows.Forms.RadioButton();
            this.rbWestVlaanderen = new System.Windows.Forms.RadioButton();
            this.rbWaalsBrabant = new System.Windows.Forms.RadioButton();
            this.rbHenegouwen = new System.Windows.Forms.RadioButton();
            this.rbLuik = new System.Windows.Forms.RadioButton();
            this.rbLuxemburg = new System.Windows.Forms.RadioButton();
            this.rbNamen = new System.Windows.Forms.RadioButton();
            this.btnIndienen = new System.Windows.Forms.Button();
            this.gbNaam.SuspendLayout();
            this.gbAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeeftijd)).BeginInit();
            this.gbGeslacht.SuspendLayout();
            this.gbProvincie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(11, 50);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(100, 26);
            this.tbVoornaam.TabIndex = 0;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(141, 50);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 26);
            this.tbAchternaam.TabIndex = 1;
            // 
            // tbStraat
            // 
            this.tbStraat.Location = new System.Drawing.Point(11, 53);
            this.tbStraat.Name = "tbStraat";
            this.tbStraat.Size = new System.Drawing.Size(202, 26);
            this.tbStraat.TabIndex = 2;
            // 
            // gbNaam
            // 
            this.gbNaam.Controls.Add(this.lAchternaam);
            this.gbNaam.Controls.Add(this.tbVoornaam);
            this.gbNaam.Controls.Add(this.lVoornaam);
            this.gbNaam.Controls.Add(this.tbAchternaam);
            this.gbNaam.Location = new System.Drawing.Point(27, 12);
            this.gbNaam.Name = "gbNaam";
            this.gbNaam.Size = new System.Drawing.Size(247, 87);
            this.gbNaam.TabIndex = 3;
            this.gbNaam.TabStop = false;
            this.gbNaam.Text = "Naam";
            // 
            // lVoornaam
            // 
            this.lVoornaam.AutoSize = true;
            this.lVoornaam.Location = new System.Drawing.Point(11, 22);
            this.lVoornaam.Name = "lVoornaam";
            this.lVoornaam.Size = new System.Drawing.Size(83, 20);
            this.lVoornaam.TabIndex = 4;
            this.lVoornaam.Text = "Voornaam";
            // 
            // lAchternaam
            // 
            this.lAchternaam.AutoSize = true;
            this.lAchternaam.Location = new System.Drawing.Point(137, 22);
            this.lAchternaam.Name = "lAchternaam";
            this.lAchternaam.Size = new System.Drawing.Size(96, 20);
            this.lAchternaam.TabIndex = 5;
            this.lAchternaam.Text = "Achternaam";
            // 
            // gbAdress
            // 
            this.gbAdress.Controls.Add(this.lGemeente);
            this.gbAdress.Controls.Add(this.tbGemeente);
            this.gbAdress.Controls.Add(this.tbNummer);
            this.gbAdress.Controls.Add(this.lNummer);
            this.gbAdress.Controls.Add(this.tbPostcode);
            this.gbAdress.Controls.Add(this.lPostcode);
            this.gbAdress.Controls.Add(this.lStraat);
            this.gbAdress.Controls.Add(this.tbStraat);
            this.gbAdress.Location = new System.Drawing.Point(27, 105);
            this.gbAdress.Name = "gbAdress";
            this.gbAdress.Size = new System.Drawing.Size(397, 483);
            this.gbAdress.TabIndex = 4;
            this.gbAdress.TabStop = false;
            this.gbAdress.Text = "Adress";
            // 
            // lStraat
            // 
            this.lStraat.AutoSize = true;
            this.lStraat.Location = new System.Drawing.Point(7, 30);
            this.lStraat.Name = "lStraat";
            this.lStraat.Size = new System.Drawing.Size(53, 20);
            this.lStraat.TabIndex = 3;
            this.lStraat.Text = "Straat";
            // 
            // lPostcode
            // 
            this.lPostcode.AutoSize = true;
            this.lPostcode.Location = new System.Drawing.Point(7, 91);
            this.lPostcode.Name = "lPostcode";
            this.lPostcode.Size = new System.Drawing.Size(76, 20);
            this.lPostcode.TabIndex = 4;
            this.lPostcode.Text = "Postcode";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(11, 114);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(71, 26);
            this.tbPostcode.TabIndex = 5;
            // 
            // lNummer
            // 
            this.lNummer.AutoSize = true;
            this.lNummer.Location = new System.Drawing.Point(238, 30);
            this.lNummer.Name = "lNummer";
            this.lNummer.Size = new System.Drawing.Size(29, 20);
            this.lNummer.TabIndex = 8;
            this.lNummer.Text = "Nr.";
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(242, 53);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(55, 26);
            this.tbNummer.TabIndex = 9;
            // 
            // tbGemeente
            // 
            this.tbGemeente.Location = new System.Drawing.Point(105, 114);
            this.tbGemeente.Name = "tbGemeente";
            this.tbGemeente.Size = new System.Drawing.Size(184, 26);
            this.tbGemeente.TabIndex = 10;
            // 
            // lGemeente
            // 
            this.lGemeente.AutoSize = true;
            this.lGemeente.Location = new System.Drawing.Point(101, 91);
            this.lGemeente.Name = "lGemeente";
            this.lGemeente.Size = new System.Drawing.Size(85, 20);
            this.lGemeente.TabIndex = 11;
            this.lGemeente.Text = "Gemeente";
            // 
            // nudLeeftijd
            // 
            this.nudLeeftijd.Location = new System.Drawing.Point(38, 625);
            this.nudLeeftijd.Name = "nudLeeftijd";
            this.nudLeeftijd.Size = new System.Drawing.Size(120, 26);
            this.nudLeeftijd.TabIndex = 5;
            // 
            // lLeeftijd
            // 
            this.lLeeftijd.AutoSize = true;
            this.lLeeftijd.Location = new System.Drawing.Point(34, 602);
            this.lLeeftijd.Name = "lLeeftijd";
            this.lLeeftijd.Size = new System.Drawing.Size(61, 20);
            this.lLeeftijd.TabIndex = 6;
            this.lLeeftijd.Text = "Leeftijd";
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Location = new System.Drawing.Point(27, 671);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 92);
            this.gbGeslacht.TabIndex = 7;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(11, 25);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(65, 24);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(11, 55);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(79, 24);
            this.rbVrouw.TabIndex = 1;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // gbProvincie
            // 
            this.gbProvincie.Controls.Add(this.rbNamen);
            this.gbProvincie.Controls.Add(this.rbLuxemburg);
            this.gbProvincie.Controls.Add(this.rbLuik);
            this.gbProvincie.Controls.Add(this.rbHenegouwen);
            this.gbProvincie.Controls.Add(this.rbWaalsBrabant);
            this.gbProvincie.Controls.Add(this.rbWestVlaanderen);
            this.gbProvincie.Controls.Add(this.rbVlaamsBrabant);
            this.gbProvincie.Controls.Add(this.rbOostVlaanderen);
            this.gbProvincie.Controls.Add(this.rbLimburg);
            this.gbProvincie.Controls.Add(this.rbAntwerpen);
            this.gbProvincie.Location = new System.Drawing.Point(27, 261);
            this.gbProvincie.Name = "gbProvincie";
            this.gbProvincie.Size = new System.Drawing.Size(318, 327);
            this.gbProvincie.TabIndex = 8;
            this.gbProvincie.TabStop = false;
            this.gbProvincie.Text = "Provincie";
            // 
            // rbAntwerpen
            // 
            this.rbAntwerpen.AutoSize = true;
            this.rbAntwerpen.Location = new System.Drawing.Point(11, 25);
            this.rbAntwerpen.Name = "rbAntwerpen";
            this.rbAntwerpen.Size = new System.Drawing.Size(111, 24);
            this.rbAntwerpen.TabIndex = 0;
            this.rbAntwerpen.TabStop = true;
            this.rbAntwerpen.Text = "Antwerpen";
            this.rbAntwerpen.UseVisualStyleBackColor = true;
            // 
            // rbLimburg
            // 
            this.rbLimburg.AutoSize = true;
            this.rbLimburg.Location = new System.Drawing.Point(11, 55);
            this.rbLimburg.Name = "rbLimburg";
            this.rbLimburg.Size = new System.Drawing.Size(91, 24);
            this.rbLimburg.TabIndex = 1;
            this.rbLimburg.TabStop = true;
            this.rbLimburg.Text = "Limburg";
            this.rbLimburg.UseVisualStyleBackColor = true;
            // 
            // rbOostVlaanderen
            // 
            this.rbOostVlaanderen.AutoSize = true;
            this.rbOostVlaanderen.Location = new System.Drawing.Point(11, 85);
            this.rbOostVlaanderen.Name = "rbOostVlaanderen";
            this.rbOostVlaanderen.Size = new System.Drawing.Size(155, 24);
            this.rbOostVlaanderen.TabIndex = 2;
            this.rbOostVlaanderen.TabStop = true;
            this.rbOostVlaanderen.Text = "Oost-Vlaanderen";
            this.rbOostVlaanderen.UseVisualStyleBackColor = true;
            // 
            // rbVlaamsBrabant
            // 
            this.rbVlaamsBrabant.AutoSize = true;
            this.rbVlaamsBrabant.Location = new System.Drawing.Point(11, 115);
            this.rbVlaamsBrabant.Name = "rbVlaamsBrabant";
            this.rbVlaamsBrabant.Size = new System.Drawing.Size(149, 24);
            this.rbVlaamsBrabant.TabIndex = 3;
            this.rbVlaamsBrabant.TabStop = true;
            this.rbVlaamsBrabant.Text = "Vlaams-Brabant";
            this.rbVlaamsBrabant.UseVisualStyleBackColor = true;
            // 
            // rbWestVlaanderen
            // 
            this.rbWestVlaanderen.AutoSize = true;
            this.rbWestVlaanderen.Location = new System.Drawing.Point(11, 145);
            this.rbWestVlaanderen.Name = "rbWestVlaanderen";
            this.rbWestVlaanderen.Size = new System.Drawing.Size(158, 24);
            this.rbWestVlaanderen.TabIndex = 4;
            this.rbWestVlaanderen.TabStop = true;
            this.rbWestVlaanderen.Text = "West-Vlaanderen";
            this.rbWestVlaanderen.UseVisualStyleBackColor = true;
            // 
            // rbWaalsBrabant
            // 
            this.rbWaalsBrabant.AutoSize = true;
            this.rbWaalsBrabant.Location = new System.Drawing.Point(11, 175);
            this.rbWaalsBrabant.Name = "rbWaalsBrabant";
            this.rbWaalsBrabant.Size = new System.Drawing.Size(140, 24);
            this.rbWaalsBrabant.TabIndex = 5;
            this.rbWaalsBrabant.TabStop = true;
            this.rbWaalsBrabant.Text = "Waals-Brabant";
            this.rbWaalsBrabant.UseVisualStyleBackColor = true;
            // 
            // rbHenegouwen
            // 
            this.rbHenegouwen.AutoSize = true;
            this.rbHenegouwen.Location = new System.Drawing.Point(11, 205);
            this.rbHenegouwen.Name = "rbHenegouwen";
            this.rbHenegouwen.Size = new System.Drawing.Size(129, 24);
            this.rbHenegouwen.TabIndex = 6;
            this.rbHenegouwen.TabStop = true;
            this.rbHenegouwen.Text = "Henegouwen";
            this.rbHenegouwen.UseVisualStyleBackColor = true;
            // 
            // rbLuik
            // 
            this.rbLuik.AutoSize = true;
            this.rbLuik.Location = new System.Drawing.Point(11, 235);
            this.rbLuik.Name = "rbLuik";
            this.rbLuik.Size = new System.Drawing.Size(63, 24);
            this.rbLuik.TabIndex = 7;
            this.rbLuik.TabStop = true;
            this.rbLuik.Text = "Luik";
            this.rbLuik.UseVisualStyleBackColor = true;
            // 
            // rbLuxemburg
            // 
            this.rbLuxemburg.AutoSize = true;
            this.rbLuxemburg.Location = new System.Drawing.Point(11, 265);
            this.rbLuxemburg.Name = "rbLuxemburg";
            this.rbLuxemburg.Size = new System.Drawing.Size(113, 24);
            this.rbLuxemburg.TabIndex = 8;
            this.rbLuxemburg.TabStop = true;
            this.rbLuxemburg.Text = "Luxemburg";
            this.rbLuxemburg.UseVisualStyleBackColor = true;
            // 
            // rbNamen
            // 
            this.rbNamen.AutoSize = true;
            this.rbNamen.Location = new System.Drawing.Point(11, 295);
            this.rbNamen.Name = "rbNamen";
            this.rbNamen.Size = new System.Drawing.Size(85, 24);
            this.rbNamen.TabIndex = 9;
            this.rbNamen.TabStop = true;
            this.rbNamen.Text = "Namen";
            this.rbNamen.UseVisualStyleBackColor = true;
            // 
            // btnIndienen
            // 
            this.btnIndienen.Location = new System.Drawing.Point(38, 809);
            this.btnIndienen.Name = "btnIndienen";
            this.btnIndienen.Size = new System.Drawing.Size(100, 35);
            this.btnIndienen.TabIndex = 9;
            this.btnIndienen.Text = "indienen";
            this.btnIndienen.UseVisualStyleBackColor = true;
            this.btnIndienen.Click += new System.EventHandler(this.btnIndienen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 884);
            this.Controls.Add(this.btnIndienen);
            this.Controls.Add(this.gbProvincie);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.lLeeftijd);
            this.Controls.Add(this.nudLeeftijd);
            this.Controls.Add(this.gbAdress);
            this.Controls.Add(this.gbNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNaam.ResumeLayout(false);
            this.gbNaam.PerformLayout();
            this.gbAdress.ResumeLayout(false);
            this.gbAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeeftijd)).EndInit();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbProvincie.ResumeLayout(false);
            this.gbProvincie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.MaskedTextBox tbStraat;
        private System.Windows.Forms.GroupBox gbNaam;
        private System.Windows.Forms.Label lAchternaam;
        private System.Windows.Forms.Label lVoornaam;
        private System.Windows.Forms.GroupBox gbAdress;
        private System.Windows.Forms.Label lGemeente;
        private System.Windows.Forms.TextBox tbGemeente;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.Label lNummer;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.Label lPostcode;
        private System.Windows.Forms.Label lStraat;
        private System.Windows.Forms.NumericUpDown nudLeeftijd;
        private System.Windows.Forms.Label lLeeftijd;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox gbProvincie;
        private System.Windows.Forms.RadioButton rbNamen;
        private System.Windows.Forms.RadioButton rbLuxemburg;
        private System.Windows.Forms.RadioButton rbLuik;
        private System.Windows.Forms.RadioButton rbHenegouwen;
        private System.Windows.Forms.RadioButton rbWaalsBrabant;
        private System.Windows.Forms.RadioButton rbWestVlaanderen;
        private System.Windows.Forms.RadioButton rbVlaamsBrabant;
        private System.Windows.Forms.RadioButton rbOostVlaanderen;
        private System.Windows.Forms.RadioButton rbLimburg;
        private System.Windows.Forms.RadioButton rbAntwerpen;
        private System.Windows.Forms.Button btnIndienen;
    }
}

