using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;

namespace ProjetIHM
{

    public partial class Form1 : Form
    {
        public class BoutonEchec : Button
        {
            int numeroLigne;
            int numeroColonne;

            public int getLigne()
            {
                return numeroLigne;
            }
            public int getColonne()
            {
                return numeroColonne;
            }
            public BoutonEchec(int numeroLigne, int numeroColonne)
            {
                this.numeroColonne = numeroColonne;
                this.numeroLigne = numeroLigne;
            }
            public String toCSV()
            {
                String s = "";
                s += Enabled ? "1" : "0";
                s += "," + Text + "," + numeroLigne + "," + numeroColonne;
                return s;
            }
            public void fromCSV(String CSV)
            {
                String[] values = CSV.Split(',');
                Enabled = values[0].Equals("1") ? true : false;
                Text = values[1];
            }
        }




        
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        BoutonEchec[,] echec;
        int compteur;
        int vies;
        Color blanc = Properties.Settings.Default.CouleurClaire;
        Color noir = Properties.Settings.Default.CouleurFoncée;
        Stack<BoutonEchec> coupsJouées;
        Image cavalier;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {               
            echec = new BoutonEchec[12, 12];
            compteur = 0;
            vies = 5;
            afficherVies();
            coupsJouées = new Stack<BoutonEchec>();
            cavalier = Image.FromFile("images\\Cheval par défaut.png");
            button2.Visible = false;
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                {
                    BoutonEchec b = new BoutonEchec(i, j);
                    if (i < 2 | i > 9 | j < 2 | j > 9)
                    {
                        b.Enabled = false;
                    }
                    else
                    {
                        this.Controls.Add(b);
                        Point p = new Point(90 + 50 * i, 90 + 50 * j);
                        b.Location = p;
                        Size s = new Size(50, 50);
                        b.Size = s;
                        //b.Text = i +"" + j;
                        b.Click += new EventHandler(this.Boutons_Click);
                        Boolean claire;
                        claire = i % 2 == j % 2 ? true : false;
                        b.BackColor = claire ? blanc : noir;
                        b.Font = new Font("Impact", 15);



                    }
                    echec[i, j] = b;
                }
            WindowState = FormWindowState.Maximized;

        }

        private void effacerCouleur()
        {
            if (coupsJouées.Count == 0)
                return;
            BoutonEchec b = coupsJouées.Peek();
            int ligne = b.getLigne();
            int col = b.getColonne();
            b.BackgroundImage = null;
            Boolean claire = b.BackColor.Equals(blanc);
            for (int l = 0; l < depj.Length; ++l)
            {
                BoutonEchec next = echec[ligne + depi[l], col + depj[l]];
                if (next.Enabled)
                    next.BackColor = claire ? noir : blanc;
            }
        }
        private void montrerCasesPossibles()
        {
            BoutonEchec b = coupsJouées.Peek();
            int ligne = b.getLigne();
            int col = b.getColonne();
            int n = 0;
            for (int l = 0; l < depj.Length; ++l)
            {
                BoutonEchec next = echec[ligne + depi[l], col + depj[l]];
                if (next.Enabled)
                {
                    next.BackColor = Color.Red;
                    ++n;
                }          
            }
            if (n == 0)
            {
                String s = compteur != 64 ? "Vous avez perdu :(" : this.Text.Equals("Tricheur !") ? "Vous n'avez aucun mérite ... ":"BRAVO ! ";
                MessageBox.Show(s, "Fin de partie.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //Clique sur une case de l'échiquier
        private void Boutons_Click(object sender, EventArgs e)
        {
            BoutonEchec b = sender as BoutonEchec;
            if (!b.BackColor.Equals(Color.Red) && compteur != 0)   
                return;
            if (coupsJouées.Count != 0)
            {//On affiche le compteur sur la case précédente, pour éviter de superposer image et texte.
                effacerCouleur();
                BoutonEchec précédent = coupsJouées.Peek();
                précédent.Text = compteur.ToString();

            }
            button3.Visible = false;
            button2.Visible = true;
            ++compteur;
            coupsJouées.Push(b);
            //b.Text = compteur.ToString();
            b.BackgroundImage = cavalier;
            b.Enabled = false;
            montrerCasesPossibles();
        }

        private void CasesClairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(compteur > 0)
            {
                MessageBox.Show("Vous ne pouvez pas faire ça en cours de partie.");
                return;
            }
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            if (c.Color.Equals(Color.Red))
            {
                MessageBox.Show("Le rouge est déjà utilisé pour discriminer les cases jouables, choix refusé");
                return;
            }
            blanc = c.Color;
            for (int i = 2; i <= 9; ++i)
            {
                for (int j = 2; j <= 9; ++j)
                {
                    BoutonEchec b = echec[i, j];
                    Boolean claire;
                    claire = i % 2 == j % 2 ? true : false;
                    b.BackColor = claire ? blanc : noir;
                }
            }
        }

        private void CasesFonceésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (compteur > 0)
            {
                MessageBox.Show("Vous ne pouvez pas faire ça en cours de partie.");
                return;
            }
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            if (c.Color.Equals(Color.Red))
            {
                MessageBox.Show("Le rouge est déjà utilisé pour discriminer les cases jouables, choix refusé");
                return;
            }
            noir = c.Color;
            for (int i = 2; i <= 9; ++i)
            {
                for (int j = 2; j <= 9; ++j)
                {
                    BoutonEchec b = echec[i, j];
                    Boolean claire;
                    claire = i % 2 == j % 2 ? true : false;
                    b.BackColor = claire ? blanc : noir;
                }
            }
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous vraiment quitter (vous pouvez sauvegarder votre partie depuis le menu) ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
                this.Close();

        }
        // Boutons pour revenir en arrière.
        private void Button1_Click(object sender, EventArgs e)
        {
            // S'il l'user n'as pas encore joué ou qu'il n'as plus de vies, on ne peut pas annuler son dernier coup
            if (coupsJouées.Count == 0 || vies == 0)
                return;
            vies--;
            afficherVies();
            if (vies == 0)
                button1.Visible = false;
            effacerCouleur();//Enlever les cases rouges actuelles
            BoutonEchec b = coupsJouées.Pop();//récupérer le dernier bouton joué
            b.Enabled = true;//le réactiver et effacer son texte
            b.Text = "";      
            --compteur;//le compteur passe a compteur - 1
            if (coupsJouées.Count == 0)//Si il n'y a plus d'éléments dans la pile on s'arrête là.
            {
                button3.Visible = true;
                button2.Visible = false;
                return;
            }
            b = coupsJouées.Pop();// on récupère le bouton d'il y a 2 tour pour recliquer dessus
            Color c = b.BackColor;
            b.Enabled = true;
            --compteur;
            b.Text = "";
            b.BackColor = Color.Red;
            b.PerformClick();
            b.BackColor = c;       
        }

        private void ReplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coupsJouées.Count() != 0)
            {
                effacerCouleur();
                while (coupsJouées.Count() != 0)
                {
                    BoutonEchec b = coupsJouées.Pop();
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            compteur = 0;
            vies = 5;
            afficherVies();
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
        }

        void afficherVies()
        {
            label1.Text = vies > 1 ? "Vies -> " + vies : vies == 1 ? "Il vous reste une vie." : "Vous avez épuisé vos chances\nAlt + R pour rejouer.";
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeu du cavalier\nClasse année spéciale\nPromotion 2019/2020","Projet IHM",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void RèglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le problème du cavalier (ou encore polygraphie ou algorithme du cavalier ou cavalier d'Euler) est un problème mathématico-logique fondé sur les déplacements du cavalier du jeu d'échecs (une case partageant un côté commun puis une case en diagonale dans la même direction). Un cavalier posé sur une case quelconque d'un échiquier doit en visiter toutes les cases sans passer deux fois sur la même.","Informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ArcticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            string path = t.Text;
            cavalier = Image.FromFile("images\\"+path + ".png");
            if (coupsJouées.Count != 0)
            {
                BoutonEchec b = coupsJouées.Peek();
                b.BackgroundImage = cavalier;
            }
        }
        //choix random
        private void Button3_Click(object sender, EventArgs e)
        {
            if (compteur != 0)
            {
                MessageBox.Show("Vous ne pouvez choisir cette option que pour le premier coup.","Action invalide",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Random r = new Random();
            int ligne = r.Next(2, 10);
            int colonne = r.Next(2, 10);
            echec[ligne, colonne].PerformClick();

        }

        //Montrer solution
        private void Button2_Click(object sender, EventArgs e)
        {
            if (coupsJouées.Count == 0)
                return;
            DialogResult r = MessageBox.Show("Souhaitez vous voir la simulation complète (avec la même case de départ que celle que vous avez utilisée) ?","Abandonner",MessageBoxButtons.YesNoCancel);
            if (r == DialogResult.Yes)
            {
                BoutonEchec b = coupsJouées.Last();
                Form2 f = new Form2(b.getLigne(),b.getColonne());
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            if(r == DialogResult.No)
                replayToolStripMenuItem.PerformClick();
        }

        private void ViesIllimitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vies = int.MaxValue;
            afficherVies();
            this.Text = "Tricheur !";
        }

        private void SauvegarderCouleursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CouleurClaire = blanc;
            Properties.Settings.Default.CouleurFoncée = noir;
            Properties.Settings.Default.Save();
        }

     
        private void SauvegarderEtQuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.InfoBoutons.Clear();       
            for (int i = 2; i <= 9; ++i)
                for (int j = 2; j <= 9; ++j)
                {
                    Properties.Settings.Default.InfoBoutons.Add(echec[i, j].toCSV());
                }
            Properties.Settings.Default.Pile.Clear();
            if (coupsJouées.Count() >= 0)
            {
                List<BoutonEchec> copie = coupsJouées.ToList();
                for (int i = copie.Count() - 1; i >= 0; --i)
                    Properties.Settings.Default.Pile.Add(copie[i].toCSV());
            }
            Properties.Settings.Default.Vie = vies.ToString();
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ChargerPartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.InfoBoutons[0].Equals("Init")) return;
            replayToolStripMenuItem.PerformClick();
            StringCollection save = Properties.Settings.Default.InfoBoutons;
            int k = 0;
            for (int i = 2; i <= 9; ++i)
                for (int j = 2; j <= 9; ++j)
                {
                    BoutonEchec b = echec[i, j];
                    String p = save[k++];
                    b.fromCSV(p);
                }
            if (coupsJouées.Count() != 0)
                coupsJouées.Clear();
            foreach (String param in Properties.Settings.Default.Pile)
            {
                String[] values = param.Split(',');
                int i = int.Parse(values[2]);
                int j = int.Parse(values[3]);
                coupsJouées.Push(echec[i, j]);
            }
            if (coupsJouées.Count() == 0)
            {
                compteur = 0;
                return;
            }
            BoutonEchec reprise = coupsJouées.Pop();
            reprise.Enabled = true;
            if(coupsJouées.Count() > 0)
                reprise.BackColor = Color.Red;
            compteur = coupsJouées.Count() == 0 ? 0 : int.Parse(coupsJouées.Peek().Text);
            reprise.PerformClick();
            vies = int.Parse(Properties.Settings.Default.Vie);
            afficherVies();
        }
    }
}
