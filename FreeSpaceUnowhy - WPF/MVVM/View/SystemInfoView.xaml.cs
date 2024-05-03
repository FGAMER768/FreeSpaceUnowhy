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