using FreeSpaceUnowhy___WPF.Core;
using System;
using System.IO;

namespace FreeSpaceUnowhy___WPF.MVVM.ViewModel
{
    class SystemInfoViewModel : ObservableObject
    {
        public string WindowsVersion => GetWindowsVersion();

        private string GetWindowsVersion()
        {
            Version version = Environment.OSVersion.Version;

            if (version.Major == 11)
            {
                return "Windows 11";
            }
            else if (version.Major == 10)
            {
                return "Windows 10";
            }

            return "Inconnu";
        }

        public SystemInfoViewModel()
        {
            CalculateDiskSpace();
        }

        private void CalculateDiskSpace()
        {
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory));
            double availableSpaceGB = drive.AvailableFreeSpace / (1024 * 1024 * 1024.0);
            double totalSpaceGB = drive.TotalSize / (1024 * 1024 * 1024.0);

            AvailableSpaceFormatted = $"{availableSpaceGB:F2} GB";
            TotalSpaceFormatted = $"{totalSpaceGB:F2} GB";
        }

        private string _availableSpaceFormatted;
        public string AvailableSpaceFormatted
        {
            get { return _availableSpaceFormatted; }
            set
            {
                _availableSpaceFormatted = value;
                OnPropertyChanged();
            }
        }

        private string _totalSpaceFormatted;
        public string TotalSpaceFormatted
        {
            get { return _totalSpaceFormatted; }
            set
            {
                _totalSpaceFormatted = value;
                OnPropertyChanged();
            }
        }

        
    }
}

