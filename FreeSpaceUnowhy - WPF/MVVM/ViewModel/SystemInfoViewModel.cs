using FreeSpaceUnowhy___WPF.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Timers;

namespace FreeSpaceUnowhy___WPF.MVVM.ViewModel
{
    class SystemInfoViewModel : ObservableObject
    {
        public string WindowsVersion => GetWindowsVersion();
        public string AvailableSpaceFormatted { get; private set; }
        public string TotalSpaceFormatted { get; private set; }
        

        

        public SystemInfoViewModel()
        {
            
            CalculateDiskSpace();

            
        }

        private string GetWindowsVersion()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                ManagementObject os = searcher.Get().OfType<ManagementObject>().FirstOrDefault();

                if (os != null)
                {
                    string caption = os["Caption"] as string;
                    if (!string.IsNullOrEmpty(caption))
                    {
                        if (caption.Contains("Windows 10"))
                        {
                            return "Windows 10";
                        }
                        else if (caption.Contains("Windows 11"))
                        {
                            return "Windows 11";
                        }
                    }
                }
            }
            catch (Exception)
            {
               
            }

            return "Unknown";
        }

        private void CalculateDiskSpace()
        {
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory));
            double availableSpaceGB = drive.AvailableFreeSpace / (1024 * 1024 * 1024.0);
            double totalSpaceGB = drive.TotalSize / (1024 * 1024 * 1024.0);

            AvailableSpaceFormatted = $"{availableSpaceGB:F2} GB";
            TotalSpaceFormatted = $"{totalSpaceGB:F2} GB";
        }

        
    }
}
