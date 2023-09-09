using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Diagnostics;
using System.Reflection;
using FreeSpaceUnowhy___WPF.MVVM.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            var hyperlink = (Hyperlink)sender;
            Process.Start(new ProcessStartInfo(hyperlink.NavigateUri.AbsoluteUri));
            e.Handled = true;
        }

        private void OnAboutButtonClick(object sender, MouseButtonEventArgs e)
        {

            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName();
            string version = assemblyName.Version.ToString();
            string author = "FGAMER768";
            MessageBox.Show($"Version: {version}\nAuthor: {author}", "FreeSpaceUnowhy - A propos de l'application");
        }

        private void OnRepoClick(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FGAMER768");
        }

        

    }

}
