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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Verrouiller le formulaire en grande fenêtre
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Temp");

            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Temp a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Temp : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Temp n'existe pas sur cet ordinateur.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Programs", "LibManuels");
            string secondFolderPath = Path.Combine("C:", userProfile, "AppData", "Local", "libmanuels-updater");

            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier LibManuels a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier LibManuels : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier LibManuels n'existe pas sur cet ordinateur.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "GeoGebra_6");
            string secondFolderPath = Path.Combine("C:", userProfile, "AppData", "Roaming", "GeoGebra");

            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier GeoGebra a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier GeoGebra : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier GeoGebra n'existe pas sur cet ordinateur.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Programs", "Microsoft VS Code");
            string secondFolderPath = Path.Combine("C:", userProfile, "AppData", "Roaming", "Code");
            string thirdFolderPath = Path.Combine("C:", userProfile, ".vscode");

            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Visual Studio Code a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Visual Studio Code : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Visual Studio Code n'existe pas sur cet ordinateur.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Programs", "Thonny");
            string secondFolderPath = Path.Combine("C:", userProfile, "AppData", "Roaming", "Thonny");

            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Thonny a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Thonny : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Thonny n'existe pas sur cet ordinateur.");
            }


        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mettre fin à l'application lorsque le formulaire se ferme
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {

            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Local", "Programs", "Lelivrescolaire.fr");
            string secondFolderPath = Path.Combine("C:", userProfile, "AppData", "Local", "lelivrescolaire.fr-updater");




            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier Lelivrescolaire a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier Lelivrescolaire : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier Lelivrescolaire n'existe pas sur cet ordinateur.");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            string tempPath = Path.Combine("C:", userProfile, "AppData", "Roaming", "HiSqool");
            




            if (Directory.Exists(tempPath))
            {
                try
                {
                    Directory.Delete(tempPath, true);
                    MessageBox.Show("Le dossier HiSqool a été supprimé avec succès !");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossible de supprimer le dossier HiSqool : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le dossier HiSqool n'existe pas sur cet ordinateur.");
            }
        }
    }

}
