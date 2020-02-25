namespace ProjetIHM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerCouleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDesCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesClairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesFonceésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderCouleursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerCavalierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chevalParDéfautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tricheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viesIllimitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderEtQuitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerPartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerCouleurToolStripMenuItem,
            this.changerCavalierToolStripMenuItem,
            this.tricheToolStripMenuItem,
            this.replayToolStripMenuItem,
            this.sauvegarderEtQuitterToolStripMenuItem,
            this.chargerPartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changerCouleurToolStripMenuItem
            // 
            this.changerCouleurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurDesCasesToolStripMenuItem,
            this.sauvegarderCouleursToolStripMenuItem});
            this.changerCouleurToolStripMenuItem.Name = "changerCouleurToolStripMenuItem";
            this.changerCouleurToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.changerCouleurToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changerCouleurToolStripMenuItem.Text = "Changer couleur";
            // 
            // couleurDesCasesToolStripMenuItem
            // 
            this.couleurDesCasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesClairesToolStripMenuItem,
            this.casesFonceésToolStripMenuItem});
            this.couleurDesCasesToolStripMenuItem.Name = "couleurDesCasesToolStripMenuItem";
            this.couleurDesCasesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.couleurDesCasesToolStripMenuItem.Text = "Couleur des cases";
            // 
            // casesClairesToolStripMenuItem
            // 
            this.casesClairesToolStripMenuItem.Name = "casesClairesToolStripMenuItem";
            this.casesClairesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casesClairesToolStripMenuItem.Text = "Cases claires";
            this.casesClairesToolStripMenuItem.Click += new System.EventHandler(this.CasesClairesToolStripMenuItem_Click);
            // 
            // casesFonceésToolStripMenuItem
            // 
            this.casesFonceésToolStripMenuItem.Name = "casesFonceésToolStripMenuItem";
            this.casesFonceésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casesFonceésToolStripMenuItem.Text = "Cases foncées";
            this.casesFonceésToolStripMenuItem.Click += new System.EventHandler(this.CasesFonceésToolStripMenuItem_Click);
            // 
            // sauvegarderCouleursToolStripMenuItem
            // 
            this.sauvegarderCouleursToolStripMenuItem.Name = "sauvegarderCouleursToolStripMenuItem";
            this.sauvegarderCouleursToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sauvegarderCouleursToolStripMenuItem.Text = "Sauvegarder couleurs";
            this.sauvegarderCouleursToolStripMenuItem.Click += new System.EventHandler(this.SauvegarderCouleursToolStripMenuItem_Click);
            // 
            // changerCavalierToolStripMenuItem
            // 
            this.changerCavalierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neoToolStripMenuItem,
            this.arcticToolStripMenuItem,
            this.chevalParDéfautToolStripMenuItem});
            this.changerCavalierToolStripMenuItem.Name = "changerCavalierToolStripMenuItem";
            this.changerCavalierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.changerCavalierToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changerCavalierToolStripMenuItem.Text = "Changer cavalier";
            // 
            // neoToolStripMenuItem
            // 
            this.neoToolStripMenuItem.Name = "neoToolStripMenuItem";
            this.neoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.neoToolStripMenuItem.Text = "Cheval rigolo";
            this.neoToolStripMenuItem.Click += new System.EventHandler(this.ArcticToolStripMenuItem_Click);
            // 
            // arcticToolStripMenuItem
            // 
            this.arcticToolStripMenuItem.Name = "arcticToolStripMenuItem";
            this.arcticToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.arcticToolStripMenuItem.Text = "Fer à cheval";
            this.arcticToolStripMenuItem.Click += new System.EventHandler(this.ArcticToolStripMenuItem_Click);
            // 
            // chevalParDéfautToolStripMenuItem
            // 
            this.chevalParDéfautToolStripMenuItem.Name = "chevalParDéfautToolStripMenuItem";
            this.chevalParDéfautToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chevalParDéfautToolStripMenuItem.Text = "Cheval par défaut";
            this.chevalParDéfautToolStripMenuItem.Click += new System.EventHandler(this.ArcticToolStripMenuItem_Click);
            // 
            // tricheToolStripMenuItem
            // 
            this.tricheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viesIllimitésToolStripMenuItem});
            this.tricheToolStripMenuItem.Name = "tricheToolStripMenuItem";
            this.tricheToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tricheToolStripMenuItem.Text = "Triche";
            // 
            // viesIllimitésToolStripMenuItem
            // 
            this.viesIllimitésToolStripMenuItem.Name = "viesIllimitésToolStripMenuItem";
            this.viesIllimitésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D9)));
            this.viesIllimitésToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viesIllimitésToolStripMenuItem.Text = "Vies illimités";
            this.viesIllimitésToolStripMenuItem.Click += new System.EventHandler(this.ViesIllimitésToolStripMenuItem_Click);
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.replayToolStripMenuItem.Text = "Recommencer";
            this.replayToolStripMenuItem.Click += new System.EventHandler(this.ReplayToolStripMenuItem_Click);
            // 
            // sauvegarderEtQuitterToolStripMenuItem
            // 
            this.sauvegarderEtQuitterToolStripMenuItem.Name = "sauvegarderEtQuitterToolStripMenuItem";
            this.sauvegarderEtQuitterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sauvegarderEtQuitterToolStripMenuItem.Text = "Sauvegarder et quitter";
            this.sauvegarderEtQuitterToolStripMenuItem.Click += new System.EventHandler(this.SauvegarderEtQuitterToolStripMenuItem_Click);
            // 
            // chargerPartieToolStripMenuItem
            // 
            this.chargerPartieToolStripMenuItem.Name = "chargerPartieToolStripMenuItem";
            this.chargerPartieToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.chargerPartieToolStripMenuItem.Text = "Charger partie";
            this.chargerPartieToolStripMenuItem.Click += new System.EventHandler(this.ChargerPartieToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.règlesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // règlesToolStripMenuItem
            // 
            this.règlesToolStripMenuItem.Name = "règlesToolStripMenuItem";
            this.règlesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.règlesToolStripMenuItem.Text = "Règles";
            this.règlesToolStripMenuItem.Click += new System.EventHandler(this.RèglesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Charlemagne Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(754, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Annuler un coup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Charlemagne Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(754, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Abandonner et voir solution";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Charlemagne Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(754, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Choix d\'une case de depart aleatoirement";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(754, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Problème du cavalier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerCouleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDesCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesClairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesFonceésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerCavalierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neoToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem chevalParDéfautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tricheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viesIllimitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderCouleursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderEtQuitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerPartieToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

