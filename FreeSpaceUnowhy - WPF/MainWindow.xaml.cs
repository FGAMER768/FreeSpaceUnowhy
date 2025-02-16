﻿using FreeSpaceUnowhy___WPF.MVVM.ViewModel;
using FreeSpaceUnowhy___WPF.MVVM.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

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

        
       

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnCalculatorButtonClick(object sender, RoutedEventArgs e)
        {
            
            Numworks numworksWindow = new Numworks();
            numworksWindow.Show();
        }
    }
}
