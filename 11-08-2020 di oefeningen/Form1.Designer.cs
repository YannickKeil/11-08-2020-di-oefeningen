namespace _11_08_2020_di_oefeningen
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
            this.cbMijnCheckbox = new System.Windows.Forms.CheckBox();
            this.cblbMijnList = new System.Windows.Forms.CheckedListBox();
            this.rbGeslacht1 = new System.Windows.Forms.RadioButton();
            this.rbGeslacht2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGeslacht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMijnCheckbox
            // 
            this.cbMijnCheckbox.AutoSize = true;
            this.cbMijnCheckbox.Location = new System.Drawing.Point(107, 57);
            this.cbMijnCheckbox.Name = "cbMijnCheckbox";
            this.cbMijnCheckbox.Size = new System.Drawing.Size(107, 24);
            this.cbMijnCheckbox.TabIndex = 0;
            this.cbMijnCheckbox.Text = "Check mij!";
            this.cbMijnCheckbox.UseVisualStyleBackColor = true;
            this.cbMijnCheckbox.CheckedChanged += new System.EventHandler(this.cbCheckbox_CheckedChanged);
            // 
            // cblbMijnList
            // 
            this.cblbMijnList.FormattingEnabled = true;
            this.cblbMijnList.Location = new System.Drawing.Point(233, 57);
            this.cblbMijnList.Name = "cblbMijnList";
            this.cblbMijnList.Size = new System.Drawing.Size(120, 96);
            this.cblbMijnList.TabIndex = 1;
            this.cblbMijnList.SelectedValueChanged += new System.EventHandler(this.cblbMijnList_SelectedValueChanged);
            // 
            // rbGeslacht1
            // 
            this.rbGeslacht1.AutoSize = true;
            this.rbGeslacht1.Location = new System.Drawing.Point(20, 25);
            this.rbGeslacht1.Name = "rbGeslacht1";
            this.rbGeslacht1.Size = new System.Drawing.Size(65, 24);
            this.rbGeslacht1.TabIndex = 2;
            this.rbGeslacht1.TabStop = true;
            this.rbGeslacht1.Text = "man";
            this.rbGeslacht1.UseVisualStyleBackColor = true;
            // 
            // rbGeslacht2
            // 
            this.rbGeslacht2.AutoSize = true;
            this.rbGeslacht2.Location = new System.Drawing.Point(20, 55);
            this.rbGeslacht2.Name = "rbGeslacht2";
            this.rbGeslacht2.Size = new System.Drawing.Size(75, 24);
            this.rbGeslacht2.TabIndex = 3;
            this.rbGeslacht2.TabStop = true;
            this.rbGeslacht2.Text = "vrouw";
            this.rbGeslacht2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(355, 247);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "single";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(355, 277);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 24);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "taken";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbGeslacht1);
            this.gbGeslacht.Controls.Add(this.rbGeslacht2);
            this.gbGeslacht.Location = new System.Drawing.Point(107, 222);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 100);
            this.gbGeslacht.TabIndex = 6;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(13, 382);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(775, 34);
            this.pbProgress.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(484, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 318);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.cblbMijnList);
            this.Controls.Add(this.cbMijnCheckbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMijnCheckbox;
        private System.Windows.Forms.CheckedListBox cblbMijnList;
        private System.Windows.Forms.RadioButton rbGeslacht1;
        private System.Windows.Forms.RadioButton rbGeslacht2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

