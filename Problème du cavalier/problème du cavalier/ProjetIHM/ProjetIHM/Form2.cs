using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjetIHM
{
    public partial class Form2 : Form
    {
        Button[,] grille = new Button[8, 8];
        int[,] echec = new int[12, 12];
        Timer myTimer;
        int nbrePas = 1;
        static readonly int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static readonly int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        int[] ligne;
        int[] col;
        int nb_fuite, min_fuite, lmin_fuite = 0;
        int k;
        int starti, startj;
        Boolean abandon;
        Color claire;
        Color foncé;
        Boolean resetPossible;
        Boolean enCours;
        Image cavalier = Image.FromFile("images\\Cheval par défaut.png");

        private void Button1_Click(object sender, EventArgs e)
        {
            //Mode aléatoire
            myTimer.Enabled = true;
            button1.Enabled = false;
            Random random = new Random();
            int ii = random.Next(0, 7);
            int jj = random.Next(0, 7);
            lancerSimulation(ii, jj);
        }
        private void lancerSimulation(int ii, int jj)
        {
            resetPossible = true;
            enCours = true;
            int i, j;
            for (i = 0; i < 12; i++)
                for (j = 0; j < 12; j++)
                    echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);
            i = ii + 2; j = jj + 2;
            ligne[0] = ii;
            col[0] = jj;
            echec[i, j] = 1;


            for (k = 2; k <= 64; k++)
            {
                for (int l = 0, min_fuite = 11; l < 8; l++)
                {
                    ii = i + depi[l]; jj = j + depj[l];

                    nb_fuite = ((echec[ii, jj] != 0) ? 10 : fuite(ii, jj));

                    if (nb_fuite < min_fuite)
                    {
                        min_fuite = nb_fuite; lmin_fuite = l;
                    }
                }
                if (min_fuite == 9 & k != 64)
                {
                    MessageBox.Show("IMPASSE");
                    break;
                }
                i += depi[lmin_fuite]; j += depj[lmin_fuite];
                echec[i, j] = k;
                ligne[k - 1] = i - 2;
                col[k - 1] = j - 2;
            }
            k = 0;
            myTimer.Start();
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int i, int j)
        {
            InitializeComponent();
            //La grille de Form1 a un décalage de 2 par rapport à celle ci !
            starti = i - 2;
            startj = j - 2;
            abandon = true;// le joueur a lancé la simu via le bouton abandon du form1
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!resetPossible)
                return;
            myTimer.Stop();
            DialogResult r = MessageBox.Show("Voulez vous rejouer la dernière simulation ?", "Reset", MessageBoxButtons.YesNoCancel);
            switch (r)
            {
                case DialogResult.Yes:
                    k = 0;
                    foreach (Button b in grille)
                    {
                        b.Text = "";
                        b.Image = null;
                    }
                    myTimer.Start();
                    break;
                case DialogResult.No:
                    foreach (Button b in grille)
                    {
                        b.Text = "";
                        b.Image = null;
                    }
                    button1.Enabled = true;
                    resetPossible = false;
                    enCours = false;
                    break;
                default:
                    myTimer.Start();
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {   this.BackgroundImage = Image.FromFile("images\\fondform2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            myTimer = new Timer();
            myTimer.Enabled = false;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            trackBar1.Value = trackBar1.Maximum / 2;
            myTimer.Interval = trackBar1.Maximum / 2;
            ligne = new int[64];
            col = new int[64];
            foncé = Color.Gray;
            claire = Color.White;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    Button b = new Button();
                    this.Controls.Add(b);
                    Point p = new Point(80 + 50 * i, 130 + 50 * j);
                    b.Location = p;
                    Size s = new Size(50, 50);
                    b.Size = s;
                    Boolean blanc;
                    b.Click += new EventHandler(this.ChoixCaseDépart);
                    blanc = i % 2 == j % 2 ? true : false;
                    b.BackColor = blanc ? claire : foncé;
                    b.Font = new Font("Impact", 15);
                    grille[i, j] = b;
                }
            if (abandon)//L'user a choisit de voir la solution à partir de la form1
            {
                lancerSimulation(starti, startj);
                button1.Enabled = false;
                return;
            }
            this.Show();
            this.Focus();
            MessageBox.Show("Cliquez sur une case pour commencer ou laissez le hasard choisir pour vous !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
        }

        private void Reprise_Click(object sender, EventArgs e)
        {
            if(enCours)
                myTimer.Start();
        }


        private void Pas_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbrePas = int.Parse(Pas.SelectedItem.ToString());
        }

        private void CouleurPoliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            Color choice = c.Color;
            foreach (Button b in grille)
                b.ForeColor = choice;
        }

        private void CasesClairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            claire = c.Color;
            colorierGrille();

        }
        private void colorierGrille()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Button b = grille[i, j];
                    Boolean color = i % 2 == j % 2 ? true : false;
                    b.BackColor = color ? claire : foncé;
                }
            }
        }
        private void CasesFoncéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            foncé = c.Color;
            colorierGrille();
        }

        private void AideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r =  MessageBox.Show("Voulez vous ouvrir la page internet d'explication ?", "Ouvrir page web", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;
            try
            {
                Process.Start("http://irem.univ-reunion.fr/IMG/pdf/knighttour.pdf");
            }
            catch 
            {

            }
        }

        private void UnPeuDhistoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous ouvrir la page internet menant au manuscrit d'Euler ?", "Ouvrir page web", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;
            try
            {
                Process.Start("http://eulerarchive.maa.org/docs/originals/E309.pdf");
            }
            catch
            {

            }
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            int v = (trackBar1.Maximum - trackBar1.Value) + 100;

            myTimer.Interval = v;
        }

        private void ChoixCaseDépart(Object sender, EventArgs e)
        {
            if (enCours)// Si la simulation est déjà en cours
                return;
            button1.Enabled = false;
            Button choix = sender as Button;
            for (int i = 0; i < 8; ++i)
                for (int j = 0; j < 8; ++j)
                {
                    if (grille[i, j].Equals(choix))
                    {
                        lancerSimulation(i, j);
                        return;
                    }
                }

        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (k >= ligne.Length || !enCours)
            {
                myTimer.Stop();
                return;
            }
            for (int n = 0; k < ligne.Length && n < nbrePas; ++n)
            {             
                int i = ligne[k];
                int j = col[k];               
                grille[i, j].Image = cavalier;       
                if (k != 0)
                {
                    i = ligne[k-1];
                    j = col[k-1];
                    grille[i, j].Image = null;
                    grille[i, j].Text = k.ToString();
                }
                ++k;
            }
        }
        private int fuite(int i, int j)
        {
            int n, l;

            for (l = 0, n = 8; l < 8; l++)
                if (echec[i + depi[l], j + depj[l]] != 0) n--;

            return (n == 0) ? 9 : n;
        }
    }
}
