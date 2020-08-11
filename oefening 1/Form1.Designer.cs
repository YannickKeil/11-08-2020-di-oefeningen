namespace oefening_1
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
            this.tbToevoegen = new System.Windows.Forms.TextBox();
            this.btnToevoegem = new System.Windows.Forms.Button();
            this.btnNaarActief = new System.Windows.Forms.Button();
            this.btnNaarInactief = new System.Windows.Forms.Button();
            this.lbInactief = new System.Windows.Forms.ListBox();
            this.lbActief = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbToevoegen
            // 
            this.tbToevoegen.Location = new System.Drawing.Point(42, 27);
            this.tbToevoegen.Name = "tbToevoegen";
            this.tbToevoegen.Size = new System.Drawing.Size(192, 26);
            this.tbToevoegen.TabIndex = 0;
            // 
            // btnToevoegem
            // 
            this.btnToevoegem.Location = new System.Drawing.Point(260, 23);
            this.btnToevoegem.Name = "btnToevoegem";
            this.btnToevoegem.Size = new System.Drawing.Size(103, 35);
            this.btnToevoegem.TabIndex = 1;
            this.btnToevoegem.Text = "Toevoegen";
            this.btnToevoegem.UseVisualStyleBackColor = true;
            this.btnToevoegem.Click += new System.EventHandler(this.btnToevoegem_Click);
            // 
            // btnNaarActief
            // 
            this.btnNaarActief.Location = new System.Drawing.Point(260, 118);
            this.btnNaarActief.Name = "btnNaarActief";
            this.btnNaarActief.Size = new System.Drawing.Size(92, 39);
            this.btnNaarActief.TabIndex = 2;
            this.btnNaarActief.Text = "=>";
            this.btnNaarActief.UseVisualStyleBackColor = true;
            this.btnNaarActief.Click += new System.EventHandler(this.btnNaarActief_Click);
            // 
            // btnNaarInactief
            // 
            this.btnNaarInactief.Location = new System.Drawing.Point(260, 179);
            this.btnNaarInactief.Name = "btnNaarInactief";
            this.btnNaarInactief.Size = new System.Drawing.Size(92, 35);
            this.btnNaarInactief.TabIndex = 3;
            this.btnNaarInactief.Text = "<=";
            this.btnNaarInactief.UseVisualStyleBackColor = true;
            this.btnNaarInactief.Click += new System.EventHandler(this.btnNaarInactief_Click);
            // 
            // lbInactief
            // 
            this.lbInactief.FormattingEnabled = true;
            this.lbInactief.ItemHeight = 20;
            this.lbInactief.Location = new System.Drawing.Point(42, 94);
            this.lbInactief.Name = "lbInactief";
            this.lbInactief.Size = new System.Drawing.Size(192, 304);
            this.lbInactief.TabIndex = 4;
            // 
            // lbActief
            // 
            this.lbActief.FormattingEnabled = true;
            this.lbActief.ItemHeight = 20;
            this.lbActief.Location = new System.Drawing.Point(382, 94);
            this.lbActief.Name = "lbActief";
            this.lbActief.Size = new System.Drawing.Size(187, 304);
            this.lbActief.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbActief);
            this.Controls.Add(this.lbInactief);
            this.Controls.Add(this.btnNaarInactief);
            this.Controls.Add(this.btnNaarActief);
            this.Controls.Add(this.btnToevoegem);
            this.Controls.Add(this.tbToevoegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToevoegen;
        private System.Windows.Forms.Button btnToevoegem;
        private System.Windows.Forms.Button btnNaarActief;
        private System.Windows.Forms.Button btnNaarInactief;
        private System.Windows.Forms.ListBox lbInactief;
        private System.Windows.Forms.ListBox lbActief;
    }
}

