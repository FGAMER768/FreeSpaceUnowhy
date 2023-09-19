using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Logique d'interaction pour SystemInfoView.xaml
    /// </summary>
    public partial class SystemInfoView : UserControl
    {
        private bool isEasterEggActivated = false;
        public SystemInfoView()
        {
            InitializeComponent();
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

        private void OnSecretTextBoxKeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {

                if (secretTextBox.Text == "FGAMER768x")
                {

                    MessageBox.Show("Easter Egg activé !");

                    isEasterEggActivated = true;
                }
            }
        }

        private void OnSecretTextBoxGotFocus(object sender, RoutedEventArgs e)
        {

            if (sender is TextBox textBox)
            {
                textBox.Text = string.Empty;
                textBox.GotFocus -= OnSecretTextBoxGotFocus;
            }
        }

        private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (isEasterEggActivated)
            {
                switch (e.Key)
                {
                    case Key.D1:
                        PlaySound("1Sound.wav");
                        break;

                    case Key.D2:
                        PlaySound("2Sound.wav");
                        break;

                    case Key.D3:
                        PlaySound("3Sound.wav");
                        break;

                    case Key.D4:
                        PlaySound("4Sound.wav");
                        break;
                    case Key.D5:
                        PlaySound("5Sound.wav");
                        break;

                    case Key.D6:
                        PlaySound("6Sound.wav");
                        break;

                    case Key.D7:
                        PlaySound("7Sound.wav");
                        break;

                    case Key.D8:
                        PlaySound("8Sound.wav");
                        break;

                    case Key.D9:
                        PlaySound("9Sound.wav");
                        break;
                }
            }
        }
        private void PlaySound(string soundFileName)
        {
            try
            {

                string basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Keys");


                string soundFilePath = System.IO.Path.Combine(basePath, soundFileName);


                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du son : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}