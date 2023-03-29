using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSpaceForUnowhy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Verrouiller le formulaire en grande fenêtre
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Incrémenter la valeur de la barre de progression
            progressBar1.Value++;


            // Si la valeur atteint la valeur maximale, arrêter le timer
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Mettre la valeur maximale de la barre de progression
            progressBar1.Maximum = 100;

            // Mettre la valeur actuelle de la barre de progression
            progressBar1.Value = 50;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mettre fin à l'application lorsque le formulaire se ferme
            Application.Exit();
        }


    }


}

