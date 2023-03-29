using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSpaceForUnowhy
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Programs", "Unowhy");
            


            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Unowhy a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Unowhy : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Unowhy n'existe pas sur cet ordinateur.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Audacity");


            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Audacity a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Audacity : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Unowhy n'existe pas sur cet ordinateur.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
