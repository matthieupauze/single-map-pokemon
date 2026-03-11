namespace TP2.Vue
{
    partial class Battle
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
            this.msgAttacks = new TP2.Vue.Message();
            this.btnFuire = new System.Windows.Forms.Button();
            this.btnPokeball = new System.Windows.Forms.Button();
            this.grpAttaques = new System.Windows.Forms.GroupBox();
            this.btnAttaque4 = new System.Windows.Forms.Button();
            this.btnAttaque2 = new System.Windows.Forms.Button();
            this.btnAttaque3 = new System.Windows.Forms.Button();
            this.btnAttaque1 = new System.Windows.Forms.Button();
            this.pkmFriendly1 = new TP2.Vue.PkmFriendly();
            this.msgInfosBattle = new TP2.Vue.Message();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pkmEnemy1 = new TP2.Vue.PkmEnemy();
            this.msgAttacks.SuspendLayout();
            this.grpAttaques.SuspendLayout();
            this.msgInfosBattle.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgAttacks
            // 
            this.msgAttacks.BackColor = System.Drawing.SystemColors.Control;
            this.msgAttacks.Controls.Add(this.btnFuire);
            this.msgAttacks.Controls.Add(this.btnPokeball);
            this.msgAttacks.Controls.Add(this.grpAttaques);
            this.msgAttacks.Location = new System.Drawing.Point(283, 468);
            this.msgAttacks.Name = "msgAttacks";
            this.msgAttacks.Size = new System.Drawing.Size(388, 204);
            this.msgAttacks.TabIndex = 1;
            // 
            // btnFuire
            // 
            this.btnFuire.Location = new System.Drawing.Point(215, 140);
            this.btnFuire.Name = "btnFuire";
            this.btnFuire.Size = new System.Drawing.Size(112, 37);
            this.btnFuire.TabIndex = 2;
            this.btnFuire.Text = "Fuire";
            this.btnFuire.UseCompatibleTextRendering = true;
            this.btnFuire.UseVisualStyleBackColor = true;
            this.btnFuire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFuir_Click);
            // 
            // btnPokeball
            // 
            this.btnPokeball.Location = new System.Drawing.Point(62, 140);
            this.btnPokeball.Name = "btnPokeball";
            this.btnPokeball.Size = new System.Drawing.Size(112, 37);
            this.btnPokeball.TabIndex = 1;
            this.btnPokeball.Text = "Lancer pokéball";
            this.btnPokeball.UseCompatibleTextRendering = true;
            this.btnPokeball.UseVisualStyleBackColor = true;
            this.btnPokeball.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdCapturer_MouseClick);
            // 
            // grpAttaques
            // 
            this.grpAttaques.Controls.Add(this.btnAttaque4);
            this.grpAttaques.Controls.Add(this.btnAttaque2);
            this.grpAttaques.Controls.Add(this.btnAttaque3);
            this.grpAttaques.Controls.Add(this.btnAttaque1);
            this.grpAttaques.Location = new System.Drawing.Point(31, 17);
            this.grpAttaques.Name = "grpAttaques";
            this.grpAttaques.Size = new System.Drawing.Size(328, 117);
            this.grpAttaques.TabIndex = 0;
            this.grpAttaques.TabStop = false;
            this.grpAttaques.Text = "Attaques";
            this.grpAttaques.UseCompatibleTextRendering = true;
            // 
            // btnAttaque4
            // 
            this.btnAttaque4.Location = new System.Drawing.Point(184, 72);
            this.btnAttaque4.Name = "btnAttaque4";
            this.btnAttaque4.Size = new System.Drawing.Size(112, 37);
            this.btnAttaque4.TabIndex = 3;
            this.btnAttaque4.Text = "atk4";
            this.btnAttaque4.UseCompatibleTextRendering = true;
            this.btnAttaque4.UseVisualStyleBackColor = true;
            this.btnAttaque4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Attack_Event);
            // 
            // btnAttaque2
            // 
            this.btnAttaque2.Location = new System.Drawing.Point(184, 17);
            this.btnAttaque2.Name = "btnAttaque2";
            this.btnAttaque2.Size = new System.Drawing.Size(112, 37);
            this.btnAttaque2.TabIndex = 1;
            this.btnAttaque2.Text = "atk2";
            this.btnAttaque2.UseCompatibleTextRendering = true;
            this.btnAttaque2.UseVisualStyleBackColor = true;
            this.btnAttaque2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Attack_Event);
            // 
            // btnAttaque3
            // 
            this.btnAttaque3.Location = new System.Drawing.Point(31, 72);
            this.btnAttaque3.Name = "btnAttaque3";
            this.btnAttaque3.Size = new System.Drawing.Size(112, 37);
            this.btnAttaque3.TabIndex = 2;
            this.btnAttaque3.Text = "atk3";
            this.btnAttaque3.UseCompatibleTextRendering = true;
            this.btnAttaque3.UseVisualStyleBackColor = true;
            this.btnAttaque3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Attack_Event);
            // 
            // btnAttaque1
            // 
            this.btnAttaque1.Location = new System.Drawing.Point(31, 17);
            this.btnAttaque1.Name = "btnAttaque1";
            this.btnAttaque1.Size = new System.Drawing.Size(112, 37);
            this.btnAttaque1.TabIndex = 0;
            this.btnAttaque1.Text = "atk1";
            this.btnAttaque1.UseCompatibleTextRendering = true;
            this.btnAttaque1.UseVisualStyleBackColor = true;
            this.btnAttaque1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Attack_Event);
            // 
            // pkmFriendly1
            // 
            this.pkmFriendly1.BackColor = System.Drawing.SystemColors.Control;
            this.pkmFriendly1.Location = new System.Drawing.Point(0, 235);
            this.pkmFriendly1.Name = "pkmFriendly1";
            this.pkmFriendly1.Size = new System.Drawing.Size(672, 233);
            this.pkmFriendly1.TabIndex = 2;
            // 
            // msgInfosBattle
            // 
            this.msgInfosBattle.BackColor = System.Drawing.SystemColors.Control;
            this.msgInfosBattle.Controls.Add(this.lblMessage);
            this.msgInfosBattle.Location = new System.Drawing.Point(0, 468);
            this.msgInfosBattle.Name = "msgInfosBattle";
            this.msgInfosBattle.Size = new System.Drawing.Size(672, 204);
            this.msgInfosBattle.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMessage.Location = new System.Drawing.Point(31, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(611, 151);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // pkmEnemy1
            // 
            this.pkmEnemy1.BackColor = System.Drawing.SystemColors.Control;
            this.pkmEnemy1.Location = new System.Drawing.Point(0, 0);
            this.pkmEnemy1.Name = "pkmEnemy1";
            this.pkmEnemy1.Size = new System.Drawing.Size(672, 235);
            this.pkmEnemy1.TabIndex = 3;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.msgAttacks);
            this.Controls.Add(this.pkmFriendly1);
            this.Controls.Add(this.msgInfosBattle);
            this.Controls.Add(this.pkmEnemy1);
            this.Name = "Battle";
            this.Size = new System.Drawing.Size(672, 672);
            this.msgAttacks.ResumeLayout(false);
            this.grpAttaques.ResumeLayout(false);
            this.msgInfosBattle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Message msgInfosBattle;
        private Message msgAttacks;
        private PkmFriendly pkmFriendly1;
        private PkmEnemy pkmEnemy1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnFuire;
        private System.Windows.Forms.Button btnPokeball;
        private System.Windows.Forms.GroupBox grpAttaques;
        private System.Windows.Forms.Button btnAttaque4;
        private System.Windows.Forms.Button btnAttaque2;
        private System.Windows.Forms.Button btnAttaque3;
        private System.Windows.Forms.Button btnAttaque1;
    }
}
