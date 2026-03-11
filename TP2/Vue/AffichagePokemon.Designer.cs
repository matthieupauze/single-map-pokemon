namespace TP2.Vue
{
    partial class AffichagePokemon
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
            this.lblPokedexNo = new System.Windows.Forms.Label();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picFoot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPokedexNo
            // 
            this.lblPokedexNo.Location = new System.Drawing.Point(4, 162);
            this.lblPokedexNo.Name = "lblPokedexNo";
            this.lblPokedexNo.Size = new System.Drawing.Size(155, 22);
            this.lblPokedexNo.TabIndex = 1;
            this.lblPokedexNo.Text = "No. ";
            this.lblPokedexNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPokedexNo.UseCompatibleTextRendering = true;
            // 
            // picPokemon
            // 
            this.picPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.picPokemon.Location = new System.Drawing.Point(0, 0);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(159, 159);
            this.picPokemon.TabIndex = 0;
            this.picPokemon.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(0, 202);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(330, 128);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblFamily);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(166, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(6, 147);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(149, 20);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "WT";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeight.UseCompatibleTextRendering = true;
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(6, 106);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(149, 17);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "HT";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeight.UseCompatibleTextRendering = true;
            // 
            // lblFamily
            // 
            this.lblFamily.Location = new System.Drawing.Point(6, 45);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(149, 31);
            this.lblFamily.TabIndex = 7;
            this.lblFamily.Text = "Family";
            this.lblFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFamily.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name Here";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // picFoot
            // 
            this.picFoot.Location = new System.Drawing.Point(133, 158);
            this.picFoot.Name = "picFoot";
            this.picFoot.Size = new System.Drawing.Size(26, 26);
            this.picFoot.TabIndex = 8;
            this.picFoot.TabStop = false;
            // 
            // AffichagePokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picFoot);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPokedexNo);
            this.Controls.Add(this.picPokemon);
            this.Name = "AffichagePokemon";
            this.Size = new System.Drawing.Size(330, 330);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Label lblPokedexNo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picFoot;
    }
}
