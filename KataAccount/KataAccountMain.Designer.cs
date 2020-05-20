namespace KataAccount
{
    partial class KataAccountMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.depot = new System.Windows.Forms.ToolStripMenuItem();
            this.retrait = new System.Windows.Forms.ToolStripMenuItem();
            this.historique = new System.Windows.Forms.ToolStripMenuItem();
            this.quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccount,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAccount
            // 
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depot,
            this.retrait,
            this.historique,
            this.quitter});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(50, 20);
            this.menuAccount.Text = "Menu";
            // 
            // depot
            // 
            this.depot.Name = "depot";
            this.depot.Size = new System.Drawing.Size(134, 22);
            this.depot.Text = "Dépots";
            this.depot.Click += new System.EventHandler(this.depot_Click);
            // 
            // retrait
            // 
            this.retrait.Name = "retrait";
            this.retrait.Size = new System.Drawing.Size(134, 22);
            this.retrait.Text = "Retraits";
            this.retrait.Click += new System.EventHandler(this.retrait_Click);
            // 
            // historique
            // 
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(134, 22);
            this.historique.Text = "Historiques";
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // quitter
            // 
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(134, 22);
            this.quitter.Text = "Quitter";
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // KataAccountMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 296);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KataAccountMain";
            this.Text = "Bank Account";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem depot;
        private System.Windows.Forms.ToolStripMenuItem retrait;
        private System.Windows.Forms.ToolStripMenuItem historique;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitter;
    }
}

