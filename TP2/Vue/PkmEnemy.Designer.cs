namespace TP2.Vue
{
    partial class PkmEnemy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.barHp = new System.Windows.Forms.ProgressBar();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPokemon
            // 
            this.picPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.picPokemon.Location = new System.Drawing.Point(389, 3);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(280, 231);
            this.picPokemon.TabIndex = 0;
            this.picPokemon.TabStop = false;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.barHp);
            this.grpStats.Controls.Add(this.lblHp);
            this.grpStats.Controls.Add(this.lblGender);
            this.grpStats.Controls.Add(this.lblLevel);
            this.grpStats.Controls.Add(this.lblName);
            this.grpStats.Location = new System.Drawing.Point(4, 4);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(370, 228);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.UseCompatibleTextRendering = true;
            // 
            // barHp
            // 
            this.barHp.Location = new System.Drawing.Point(38, 173);
            this.barHp.Name = "barHp";
            this.barHp.Size = new System.Drawing.Size(142, 15);
            this.barHp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHp.TabIndex = 14;
            // 
            // lblHp
            // 
            this.lblHp.Location = new System.Drawing.Point(186, 164);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(124, 31);
            this.lblHp.TabIndex = 13;
            this.lblHp.Text = "? / ?";
            this.lblHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHp.UseCompatibleTextRendering = true;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(260, 97);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 31);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "M";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGender.UseCompatibleTextRendering = true;
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(51, 97);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(167, 31);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "Level:";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(7, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(355, 65);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "TODODILE";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // PkmEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.picPokemon);
            this.Name = "PkmEnemy";
            this.Size = new System.Drawing.Size(672, 235);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.ProgressBar barHp;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
    }
}
