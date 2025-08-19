namespace VoteCraft
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
            this.components = new System.ComponentModel.Container();
            this.Site1BTN = new System.Windows.Forms.Button();
            this.Site2BTN = new System.Windows.Forms.Button();
            this.Site3BTN = new System.Windows.Forms.Button();
            this.Site4BTN = new System.Windows.Forms.Button();
            this.Site5BTN = new System.Windows.Forms.Button();
            this.VoteTotalLBL = new System.Windows.Forms.Label();
            this.NextLevelLBL = new System.Windows.Forms.Label();
            this.VoteTotalNUD = new System.Windows.Forms.NumericUpDown();
            this.NextLevelNUD = new System.Windows.Forms.NumericUpDown();
            this.DaysLBL = new System.Windows.Forms.Label();
            this.DaysTB = new System.Windows.Forms.TextBox();
            this.WikiBTN = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VoteTotalNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextLevelNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Site1BTN
            // 
            this.Site1BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Site1BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Site1BTN.Location = new System.Drawing.Point(12, 9);
            this.Site1BTN.Name = "Site1BTN";
            this.Site1BTN.Size = new System.Drawing.Size(242, 127);
            this.Site1BTN.TabIndex = 0;
            this.Site1BTN.UseVisualStyleBackColor = false;
            this.Site1BTN.Click += new System.EventHandler(this.Site1BTN_Click);
            // 
            // Site2BTN
            // 
            this.Site2BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Site2BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Site2BTN.Location = new System.Drawing.Point(281, 12);
            this.Site2BTN.Name = "Site2BTN";
            this.Site2BTN.Size = new System.Drawing.Size(242, 127);
            this.Site2BTN.TabIndex = 1;
            this.Site2BTN.UseVisualStyleBackColor = false;
            this.Site2BTN.Click += new System.EventHandler(this.Site2BTN_Click);
            // 
            // Site3BTN
            // 
            this.Site3BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Site3BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Site3BTN.Location = new System.Drawing.Point(550, 9);
            this.Site3BTN.Name = "Site3BTN";
            this.Site3BTN.Size = new System.Drawing.Size(242, 127);
            this.Site3BTN.TabIndex = 2;
            this.Site3BTN.UseVisualStyleBackColor = false;
            this.Site3BTN.Click += new System.EventHandler(this.Site3BTN_Click);
            // 
            // Site4BTN
            // 
            this.Site4BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Site4BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Site4BTN.Location = new System.Drawing.Point(12, 164);
            this.Site4BTN.Name = "Site4BTN";
            this.Site4BTN.Size = new System.Drawing.Size(242, 127);
            this.Site4BTN.TabIndex = 3;
            this.Site4BTN.UseVisualStyleBackColor = false;
            this.Site4BTN.Click += new System.EventHandler(this.Site4BTN_Click);
            // 
            // Site5BTN
            // 
            this.Site5BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Site5BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Site5BTN.Location = new System.Drawing.Point(281, 164);
            this.Site5BTN.Name = "Site5BTN";
            this.Site5BTN.Size = new System.Drawing.Size(242, 127);
            this.Site5BTN.TabIndex = 4;
            this.Site5BTN.UseVisualStyleBackColor = false;
            this.Site5BTN.Click += new System.EventHandler(this.Site5BTN_Click);
            // 
            // VoteTotalLBL
            // 
            this.VoteTotalLBL.AutoSize = true;
            this.VoteTotalLBL.Location = new System.Drawing.Point(829, 12);
            this.VoteTotalLBL.Name = "VoteTotalLBL";
            this.VoteTotalLBL.Size = new System.Drawing.Size(228, 48);
            this.VoteTotalLBL.TabIndex = 6;
            this.VoteTotalLBL.Text = "Vote &Total";
            // 
            // NextLevelLBL
            // 
            this.NextLevelLBL.AutoSize = true;
            this.NextLevelLBL.Location = new System.Drawing.Point(820, 118);
            this.NextLevelLBL.Name = "NextLevelLBL";
            this.NextLevelLBL.Size = new System.Drawing.Size(234, 48);
            this.NextLevelLBL.TabIndex = 8;
            this.NextLevelLBL.Text = "Next &Level";
            // 
            // VoteTotalNUD
            // 
            this.VoteTotalNUD.Location = new System.Drawing.Point(1123, 9);
            this.VoteTotalNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.VoteTotalNUD.Name = "VoteTotalNUD";
            this.VoteTotalNUD.Size = new System.Drawing.Size(298, 56);
            this.VoteTotalNUD.TabIndex = 7;
            this.VoteTotalNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VoteTotalNUD.ThousandsSeparator = true;
            this.VoteTotalNUD.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.VoteTotalNUD.ValueChanged += new System.EventHandler(this.VoteTotalNUD_ValueChanged);
            // 
            // NextLevelNUD
            // 
            this.NextLevelNUD.Location = new System.Drawing.Point(1123, 124);
            this.NextLevelNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NextLevelNUD.Name = "NextLevelNUD";
            this.NextLevelNUD.Size = new System.Drawing.Size(298, 56);
            this.NextLevelNUD.TabIndex = 9;
            this.NextLevelNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NextLevelNUD.ThousandsSeparator = true;
            this.NextLevelNUD.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NextLevelNUD.ValueChanged += new System.EventHandler(this.NextLevelNUD_ValueChanged);
            // 
            // DaysLBL
            // 
            this.DaysLBL.AutoSize = true;
            this.DaysLBL.Location = new System.Drawing.Point(814, 240);
            this.DaysLBL.Name = "DaysLBL";
            this.DaysLBL.Size = new System.Drawing.Size(239, 48);
            this.DaysLBL.TabIndex = 10;
            this.DaysLBL.Text = "&Days to Go";
            // 
            // DaysTB
            // 
            this.DaysTB.Location = new System.Drawing.Point(1123, 236);
            this.DaysTB.Name = "DaysTB";
            this.DaysTB.ReadOnly = true;
            this.DaysTB.Size = new System.Drawing.Size(298, 56);
            this.DaysTB.TabIndex = 11;
            // 
            // WikiBTN
            // 
            this.WikiBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WikiBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WikiBTN.Location = new System.Drawing.Point(550, 164);
            this.WikiBTN.Name = "WikiBTN";
            this.WikiBTN.Size = new System.Drawing.Size(242, 127);
            this.WikiBTN.TabIndex = 5;
            this.WikiBTN.UseVisualStyleBackColor = false;
            this.WikiBTN.Click += new System.EventHandler(this.WikiBTN_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Enabled = true;
            this.SaveFile.Interval = 5000;
            this.SaveFile.Tick += new System.EventHandler(this.SaveFile_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1451, 307);
            this.Controls.Add(this.WikiBTN);
            this.Controls.Add(this.DaysTB);
            this.Controls.Add(this.DaysLBL);
            this.Controls.Add(this.NextLevelNUD);
            this.Controls.Add(this.VoteTotalNUD);
            this.Controls.Add(this.NextLevelLBL);
            this.Controls.Add(this.VoteTotalLBL);
            this.Controls.Add(this.Site5BTN);
            this.Controls.Add(this.Site4BTN);
            this.Controls.Add(this.Site3BTN);
            this.Controls.Add(this.Site2BTN);
            this.Controls.Add(this.Site1BTN);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "MineCraft Voting List for Noob-Friendly";
            ((System.ComponentModel.ISupportInitialize)(this.VoteTotalNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextLevelNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Site1BTN;
        private System.Windows.Forms.Button Site2BTN;
        private System.Windows.Forms.Button Site3BTN;
        private System.Windows.Forms.Button Site4BTN;
        private System.Windows.Forms.Button Site5BTN;
        private System.Windows.Forms.Label VoteTotalLBL;
        private System.Windows.Forms.Label NextLevelLBL;
        private System.Windows.Forms.NumericUpDown VoteTotalNUD;
        private System.Windows.Forms.NumericUpDown NextLevelNUD;
        private System.Windows.Forms.Label DaysLBL;
        private System.Windows.Forms.TextBox DaysTB;
        private System.Windows.Forms.Button WikiBTN;
        private System.Windows.Forms.Timer SaveFile;
    }
}

