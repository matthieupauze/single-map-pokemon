namespace TP2.Vue
{
    partial class PkmFriendly
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
            this.picPokemon.Location = new System.Drawing.Point(3, 0);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(266, 234);
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
            this.grpStats.Location = new System.Drawing.Point(285, 3);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(384, 228);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.UseCompatibleTextRendering = true;
            // 
            // barHp
            // 
            this.barHp.Location = new System.Drawing.Point(46, 161);
            this.barHp.Name = "barHp";
            this.barHp.Size = new System.Drawing.Size(142, 15);
            this.barHp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHp.TabIndex = 9;
            // 
            // lblHp
            // 
            this.lblHp.Location = new System.Drawing.Point(194, 152);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(124, 31);
            this.lblHp.TabIndex = 8;
            this.lblHp.Text = "? / ?";
            this.lblHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHp.UseCompatibleTextRendering = true;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(268, 85);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 31);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "M";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGender.UseCompatibleTextRendering = true;
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(59, 85);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(167, 31);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level:";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(355, 65);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "TODODILE";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // PkmFriendly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.picPokemon);
            this.Name = "PkmFriendly";
            this.Size = new System.Drawing.Size(672, 234);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar barHp;
    }
}
