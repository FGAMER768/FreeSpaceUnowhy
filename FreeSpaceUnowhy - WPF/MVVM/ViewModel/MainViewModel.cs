using FreeSpaceUnowhy___WPF.Core;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace FreeSpaceUnowhy___WPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FreeSpaceViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand SystemInfoViewCommand { get; set; }
        public RelayCommand InstallerViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public FreeSpaceViewModel FreeSpaceVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public SystemInfoViewModel SystemInfoVM { get; set; }
        public InstallerViewModel InstallerVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string _currentTime;
        public string CurrentTime
        {
            get { return _currentTime; }
            set
            {
                _currentTime = value;
                OnPropertyChanged();
            }
        }

        private string _currentDate;
        public string CurrentDate
        {
            get { return _currentDate; }
            set
            {
                _currentDate = value;
                OnPropertyChanged();
            }
        }

        private string _windowsVersion;
        public string WindowsVersion
        {
            get { return _windowsVersion; }
            set
            {
                _windowsVersion = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FreeSpaceVM = new FreeSpaceViewModel();
            SettingsVM = new SettingsViewModel();
            SystemInfoVM = new SystemInfoViewModel();
            InstallerVM = new InstallerViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            FreeSpaceViewCommand = new RelayCommand(o =>
            {
                CurrentView = FreeSpaceVM;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
            SystemInfoViewCommand = new RelayCommand(o =>
            {
                CurrentView = SystemInfoVM;
            });
            InstallerViewCommand = new RelayCommand(o =>
            {
                CurrentView = InstallerVM;
            });

            Username = Environment.UserName;

            
            WindowsVersion = SystemInfoVM.WindowsVersion;

            UpdateTimeAndDate();
        }

        private void UpdateTimeAndDate()
        {
            CurrentTime = DateTime.Now.ToString("HH:mm:ss");
            CurrentDate = DateTime.Now.ToString("dd-MM-yyyy");

            Task.Delay(1000).ContinueWith(_ =>
            {
                UpdateTimeAndDate();
            });
        }
    }
}
