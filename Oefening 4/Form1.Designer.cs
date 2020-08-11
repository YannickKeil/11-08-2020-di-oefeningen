namespace Oefening_4
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
            this.lbNotitieboekje = new System.Windows.Forms.ListBox();
            this.lblNotitieBoekje = new System.Windows.Forms.Label();
            this.lblNotitie = new System.Windows.Forms.Label();
            this.tbBijschrijven = new System.Windows.Forms.TextBox();
            this.lblBijschrijven = new System.Windows.Forms.Label();
            this.btnUitscheuren = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnBijschrijven = new System.Windows.Forms.Button();
            this.btnLamineren = new System.Windows.Forms.Button();
            this.tbNotities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNotitieboekje
            // 
            this.lbNotitieboekje.FormattingEnabled = true;
            this.lbNotitieboekje.ItemHeight = 20;
            this.lbNotitieboekje.Location = new System.Drawing.Point(54, 55);
            this.lbNotitieboekje.Name = "lbNotitieboekje";
            this.lbNotitieboekje.Size = new System.Drawing.Size(237, 384);
            this.lbNotitieboekje.TabIndex = 0;
            this.lbNotitieboekje.SelectedIndexChanged += new System.EventHandler(this.lbNotitieboekje_SelectedIndexChanged);
            // 
            // lblNotitieBoekje
            // 
            this.lblNotitieBoekje.AutoSize = true;
            this.lblNotitieBoekje.Location = new System.Drawing.Point(50, 13);
            this.lblNotitieBoekje.Name = "lblNotitieBoekje";
            this.lblNotitieBoekje.Size = new System.Drawing.Size(101, 20);
            this.lblNotitieBoekje.TabIndex = 1;
            this.lblNotitieBoekje.Text = "Notitieboekje";
            // 
            // lblNotitie
            // 
            this.lblNotitie.AutoSize = true;
            this.lblNotitie.Location = new System.Drawing.Point(293, 13);
            this.lblNotitie.Name = "lblNotitie";
            this.lblNotitie.Size = new System.Drawing.Size(54, 20);
            this.lblNotitie.TabIndex = 2;
            this.lblNotitie.Text = "Notitie";
            // 
            // tbBijschrijven
            // 
            this.tbBijschrijven.Location = new System.Drawing.Point(220, 483);
            this.tbBijschrijven.Name = "tbBijschrijven";
            this.tbBijschrijven.Size = new System.Drawing.Size(263, 26);
            this.tbBijschrijven.TabIndex = 4;
            // 
            // lblBijschrijven
            // 
            this.lblBijschrijven.AutoSize = true;
            this.lblBijschrijven.Location = new System.Drawing.Point(216, 460);
            this.lblBijschrijven.Name = "lblBijschrijven";
            this.lblBijschrijven.Size = new System.Drawing.Size(85, 20);
            this.lblBijschrijven.TabIndex = 5;
            this.lblBijschrijven.Text = "bijschrijven";
            // 
            // btnUitscheuren
            // 
            this.btnUitscheuren.Location = new System.Drawing.Point(68, 537);
            this.btnUitscheuren.Name = "btnUitscheuren";
            this.btnUitscheuren.Size = new System.Drawing.Size(137, 41);
            this.btnUitscheuren.TabIndex = 6;
            this.btnUitscheuren.Text = "Scheur notitie uit";
            this.btnUitscheuren.UseVisualStyleBackColor = true;
            this.btnUitscheuren.Click += new System.EventHandler(this.btnUitscheuren_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(68, 483);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(137, 40);
            this.btnToevoegen.TabIndex = 7;
            this.btnToevoegen.Text = "Voeg notitie toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnBijschrijven
            // 
            this.btnBijschrijven.Location = new System.Drawing.Point(504, 480);
            this.btnBijschrijven.Name = "btnBijschrijven";
            this.btnBijschrijven.Size = new System.Drawing.Size(46, 29);
            this.btnBijschrijven.TabIndex = 8;
            this.btnBijschrijven.Text = "->";
            this.btnBijschrijven.UseVisualStyleBackColor = true;
            this.btnBijschrijven.Click += new System.EventHandler(this.btnBijschrijven_Click);
            // 
            // btnLamineren
            // 
            this.btnLamineren.Location = new System.Drawing.Point(332, 537);
            this.btnLamineren.Name = "btnLamineren";
            this.btnLamineren.Size = new System.Drawing.Size(218, 41);
            this.btnLamineren.TabIndex = 9;
            this.btnLamineren.Text = "Lamineren";
            this.btnLamineren.UseVisualStyleBackColor = true;
            this.btnLamineren.Click += new System.EventHandler(this.btnLamineren_Click);
            // 
            // tbNotities
            // 
            this.tbNotities.Enabled = false;
            this.tbNotities.Location = new System.Drawing.Point(297, 55);
            this.tbNotities.Multiline = true;
            this.tbNotities.Name = "tbNotities";
            this.tbNotities.Size = new System.Drawing.Size(253, 392);
            this.tbNotities.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 999);
            this.Controls.Add(this.tbNotities);
            this.Controls.Add(this.btnLamineren);
            this.Controls.Add(this.btnBijschrijven);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnUitscheuren);
            this.Controls.Add(this.lblBijschrijven);
            this.Controls.Add(this.tbBijschrijven);
            this.Controls.Add(this.lblNotitie);
            this.Controls.Add(this.lblNotitieBoekje);
            this.Controls.Add(this.lbNotitieboekje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotitieboekje;
        private System.Windows.Forms.Label lblNotitieBoekje;
        private System.Windows.Forms.Label lblNotitie;
        private System.Windows.Forms.TextBox tbBijschrijven;
        private System.Windows.Forms.Label lblBijschrijven;
        private System.Windows.Forms.Button btnUitscheuren;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnBijschrijven;
        private System.Windows.Forms.Button btnLamineren;
        private System.Windows.Forms.TextBox tbNotities;
    }
}

