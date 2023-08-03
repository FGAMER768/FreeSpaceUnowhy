using FreeSpaceUnowhy___WPF.Core;
using System;

namespace FreeSpaceUnowhy___WPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand FreeSpaceViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public FreeSpaceViewModel FreeSpaceVM { get; set; }

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

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FreeSpaceVM = new FreeSpaceViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o=>
            {
                CurrentView = HomeVM;
            });

        FreeSpaceViewCommand = new RelayCommand(o=>
            {
            CurrentView = FreeSpaceVM;
        });
            
            Username = Environment.UserName;
        }
    }
}
