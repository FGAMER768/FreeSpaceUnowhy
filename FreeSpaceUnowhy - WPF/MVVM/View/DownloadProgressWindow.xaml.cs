using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    public partial class DownloadProgressWindow : Window
    {
        private readonly string[] setupFiles = {
            "thonny.exe",
            "LibManuels.exe",
            "educadhoc_installer_v9.0.21.exe",
            "Lelivrescolaire.fr.setup_64.exe",
            "VSCodeSetup-x64.exe"
        };

        private readonly string tempFolderPath = Environment.GetEnvironmentVariable("TEMP");

        public DownloadProgressWindow()
        {
            InitializeComponent();
            CheckSetupFiles();
        }

        private async void CheckSetupFiles()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    bool allProcessesFinished = true;

                    foreach (string setupFile in setupFiles)
                    {
                        string setupFilePath = Path.Combine(tempFolderPath, setupFile);

                        if (File.Exists(setupFilePath))
                        {
                            FileInfo fileInfo = new FileInfo(setupFilePath);
                            long previousFileSize = fileInfo.Length;

                            await Task.Delay(3000); // Attendre 3 secondes

                            fileInfo.Refresh();
                            long currentFileSize = fileInfo.Length;

                            if (previousFileSize != currentFileSize)
                            {
                                allProcessesFinished = false;
                                break; // Sort de la boucle dès qu'un fichier change de taille
                            }
                        }
                    }

                    if (allProcessesFinished)
                    {
                        Dispatcher.Invoke(() => Close());
                        break; // Sort de la boucle principale
                    }

                    await Task.Delay(3000); // Attendre 3 secondes avant de vérifier à nouveau
                }
            });
        }
    }
}
