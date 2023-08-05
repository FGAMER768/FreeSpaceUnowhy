using FreeSpaceUnowhy___WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
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



    }
}

