using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour FreeSpaceView.xaml
    /// </summary>
    public partial class FreeSpaceView : UserControl
    {
        public FreeSpaceView()
        {
            InitializeComponent();
        }

        private void OnTempButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string tempFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier %temp% et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(tempFolderPath, true);
                    MessageBox.Show("Le dossier %temp% a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnGeogebraButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string geogebraLocalFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GeoGebra_6");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier Geogebra et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(geogebraLocalFolderPath, true);
                    MessageBox.Show("Le dossier Geogebra a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnThonnyButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string thonnyLocalFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Thonny");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier Thonny et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(thonnyLocalFolderPath, true);
                    MessageBox.Show("Le dossier Thonny a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnLibManuelsButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string libManuelsLocalFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "LibManuels");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier LibManuels et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(libManuelsLocalFolderPath, true);
                    MessageBox.Show("Le dossier LibManuels a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnEducadhocButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string hachetteFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Hachette");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier Hachette (Educadhoc) et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(hachetteFolderPath, true);
                    MessageBox.Show("Le dossier Hachette (Educadhoc) a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnLLScolaireButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string llscolaireFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Lelivrescolaire.fr");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier LeLivreScolaire et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(llscolaireFolderPath, true);
                    MessageBox.Show("Le dossier LeLivreScolaire a été supprimé avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnVSCodeButtonClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string vsCodeFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Microsoft VS Code");

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le dossier Microsoft VS Code et son contenu?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Directory.Delete(vsCodeFolderPath, true);
                    MessageBox.Show("Le dossier Microsoft VS Code a été supprimé avec succès! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression : " + ex.Message);
            }
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#AEBAF7", "#9600FF");
            }
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#9600FF", "#AEBAF7");
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