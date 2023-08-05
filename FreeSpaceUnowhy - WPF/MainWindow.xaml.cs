using FreeSpaceUnowhy___WPF.MVVM.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FreeSpaceUnowhy___WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            Username = System.Environment.UserName;
        }

        private void OnCloseButtonClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            Application.Current.Shutdown();
        }
        private void OnMinimizeButtonClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

    }
}
