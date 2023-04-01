using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management;



namespace FreeSpaceForUnowhy
{
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            // Verrouiller le formulaire en grande fenêtre
            this.WindowState = FormWindowState.Maximized;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Nom de la machine: {SystemInformation.ComputerName}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = $"Système d'exploitation: {Environment.OSVersion.VersionString}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = $"Nom d'utilisateur: {SystemInformation.UserName}";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Créer une requête pour récupérer le nom du processeur
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor");

            // Exécuter la requête et récupérer le premier objet de résultat
            ManagementObject obj = searcher.Get().Cast<ManagementObject>().FirstOrDefault();

            // Récupérer le nom du processeur à partir de l'objet résultat
            string cpuName = obj["Name"].ToString();

            // Afficher le nom du processeur dans le label
            label4.Text = $"Nom du CPU: {cpuName}";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = $"Mémoire RAM: {((new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024) / 1024)} Mo";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo("C");
            long availableSpace = drive.AvailableFreeSpace;
            long totalSpace = drive.TotalSize;
            label6.Text = $"Stockage total: {FormatBytes(totalSpace)}, Espace libre: {FormatBytes(availableSpace)}";
        }

        public static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 Bytes";
        }

        private void Form5FormClosing(object sender, FormClosingEventArgs e)
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

       
        }

}
