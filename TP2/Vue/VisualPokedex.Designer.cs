namespace TP2.Vue
{
    partial class VisualPokedex
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPokemon = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.affichagePokemon1 = new TP2.Vue.AffichagePokemon();
            this.SuspendLayout();
            // 
            // listPokemon
            // 
            this.listPokemon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listPokemon.ItemHeight = 16;
            this.listPokemon.Location = new System.Drawing.Point(339, 3);
            this.listPokemon.Name = "listPokemon";
            this.listPokemon.Size = new System.Drawing.Size(330, 644);
            this.listPokemon.TabIndex = 1;
            this.listPokemon.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listPokemon_DrawItem);
            this.listPokemon.SelectedIndexChanged += new System.EventHandler(this.listPokemon_SelectedIndexChanged);
            this.listPokemon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPokemon_KeyDown);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(83, 597);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(154, 72);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer le pokédex";
            this.btnFermer.UseCompatibleTextRendering = true;
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // affichagePokemon1
            // 
            this.affichagePokemon1.BackColor = System.Drawing.SystemColors.Control;
            this.affichagePokemon1.Location = new System.Drawing.Point(3, 3);
            this.affichagePokemon1.Name = "affichagePokemon1";
            this.affichagePokemon1.Size = new System.Drawing.Size(330, 330);
            this.affichagePokemon1.TabIndex = 0;
            // 
            // VisualPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.listPokemon);
            this.Controls.Add(this.affichagePokemon1);
            this.Name = "VisualPokedex";
            this.Size = new System.Drawing.Size(672, 672);
            this.ResumeLayout(false);

        }

        #endregion

        private AffichagePokemon affichagePokemon1;
        private System.Windows.Forms.ListBox listPokemon;
        private System.Windows.Forms.Button btnFermer;
    }
}
