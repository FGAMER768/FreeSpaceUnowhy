using FreeSpaceUnowhy___WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            WV.Source = new System.Uri("https://htmlpreview.github.io/?https://github.com/FGAMER768/FreeSpaceUnowhy/blob/master/Ressources/changelog.html");
        }

        private void OnAboutButtonClick(object sender, MouseButtonEventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName();
            string version = assemblyName.Version.ToString();
            string author = "FGAMER768";
            MessageBox.Show($"Version: {version}\nAuthor: {author}", "FreeSpaceUnowhy - A propos de l'application");
        }

        private void OnLatestVersionButtonClick(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FGAMER768/FreeSpaceUnowhy/releases/latest");
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#AEBAF7", "#9600FF");
                AnimateZoomIn(border);
            }
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                AnimateButtonColor(border, "#9600FF", "#AEBAF7");
                AnimateZoomOut(border);
            }
        }

        private void AnimateZoomIn(UIElement element)
        {
            DoubleAnimation scaleX = new DoubleAnimation
            {
                To = 1,
                Duration = TimeSpan.FromSeconds(0.2)
            };

            DoubleAnimation scaleY = new DoubleAnimation
            {
                To = 1,
                Duration = TimeSpan.FromSeconds(0.2)
            };

            Storyboard.SetTarget(scaleX, element);
            Storyboard.SetTargetProperty(scaleX, new PropertyPath("RenderTransform.ScaleX"));

            Storyboard.SetTarget(scaleY, element);
            Storyboard.SetTargetProperty(scaleY, new PropertyPath("RenderTransform.ScaleY"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(scaleX);
            storyboard.Children.Add(scaleY);

            storyboard.Begin();
        }

        private void AnimateZoomOut(UIElement element)
        {
            DoubleAnimation scaleX = new DoubleAnimation
            {
                To = 1,
                Duration = TimeSpan.FromSeconds(0.2)
            };

            DoubleAnimation scaleY = new DoubleAnimation
            {
                To = 1,
                Duration = TimeSpan.FromSeconds(0.2)
            };

            Storyboard.SetTarget(scaleX, element);
            Storyboard.SetTargetProperty(scaleX, new PropertyPath("RenderTransform.ScaleX"));

            Storyboard.SetTarget(scaleY, element);
            Storyboard.SetTargetProperty(scaleY, new PropertyPath("RenderTransform.ScaleY"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(scaleX);
            storyboard.Children.Add(scaleY);

            storyboard.Begin();
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
