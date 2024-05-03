using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Threading.Tasks;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    public partial class InstallerView : UserControl
    {
        public InstallerView()
        {
            InitializeComponent();
        }

        private async void OnGeogebraButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://download.geogebra.org/package/win-autoupdate", "geogebra.exe");
            }
        }

        private async void OnThonnyButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://github.com/thonny/thonny/releases/download/v4.1.4/thonny-4.1.4.exe", "thonny.exe");
            }
        }

        private async void OnLibManuelsButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://storage.libmanuels.fr/__RELEASES/latest/LibManuels.exe", "LibManuels.exe");
            }
        }

        private async void OnEducadhocButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://exobank.hachette-livre.fr/contents/download/educadhoc_installer_v9.0.21.exe", "educadhoc_installer_v9.0.21.exe");
            }
        }

        private async void OnLLScolaireButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://ci.lls.fr/build/latest/win/Lelivrescolaire.fr.setup_64.exe", "Lelivrescolaire.fr.setup_64.exe");
            }
        }

        private async void OnVSCodeButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (await ConfirmDownload())
            {
                InstallApplication("https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user", "vscode_setup.exe");
            }
        }

        private async Task<bool> ConfirmDownload()
        {
            InstallerDialog installerDialog = new InstallerDialog();
            bool? result = installerDialog.ShowDialog();
            return result.HasValue && result.Value;
        }


        private async void InstallApplication(string packageUrl, string desiredFileName)
        {
            try
            {
                string downloadPath = Path.Combine(Path.GetTempPath(), desiredFileName);

                using (WebClient webClient = new WebClient())
                {
                    await webClient.DownloadFileTaskAsync(new Uri(packageUrl), downloadPath);
                }

                if (File.Exists(downloadPath))
                {
                    await Task.Delay(3000);
                    Process.Start(downloadPath);
                }
                else
                {
                    MessageBox.Show("Le fichier d'installation n'a pas été trouvé.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'installation : " + ex.Message);
            }
        }


        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#4A90E2", "#00D4FF");
            }
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#002F6C", "#4A90E2");
            }
        }

        private void AnimateButtonColor(Border border, string fromColor, string toColor)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0.5);
            gradientBrush.EndPoint = new Point(1, 0.5);

            gradientBrush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString(fromColor), 0.0));
            gradientBrush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString(toColor), 1.0));

            border.Background = gradientBrush;

            ColorAnimation colorAnimationFrom = new ColorAnimation
            {
                To = (Color)ColorConverter.ConvertFromString(fromColor),
                Duration = TimeSpan.FromSeconds(0.2)
            };

            ColorAnimation colorAnimationTo = new ColorAnimation
            {
                To = (Color)ColorConverter.ConvertFromString(toColor),
                Duration = TimeSpan.FromSeconds(0.2)
            };

            Storyboard.SetTarget(colorAnimationFrom, gradientBrush.GradientStops[0]);
            Storyboard.SetTargetProperty(colorAnimationFrom, new PropertyPath("Color"));

            Storyboard.SetTarget(colorAnimationTo, gradientBrush.GradientStops[1]);
            Storyboard.SetTargetProperty(colorAnimationTo, new PropertyPath("Color"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(colorAnimationFrom);
            storyboard.Children.Add(colorAnimationTo);

            storyboard.Begin();
        }
    }
}
