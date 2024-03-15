using System.Threading.Tasks;
using System.Windows;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    public partial class InstallerDialog : Window
    {
        public InstallerDialog()
        {
            InitializeComponent();
        }

        private async void YesButton_Click(object sender, RoutedEventArgs e)
        {
            
            DialogResult = true;

            
            DownloadProgressWindow progressWindow = new DownloadProgressWindow();
            
            progressWindow.Show();

            
            await Task.Delay(500);

            
            Close();
        }


        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            
            DialogResult = false;
        }
    }
}
