using FreeSpaceUnowhy___WPF.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Timers;
using System.Linq;

namespace FreeSpaceUnowhy___WPF.MVVM.ViewModel
{
    class SystemInfoViewModel : ObservableObject
    {
        private string _cpuInfo;
        public string WindowsVersion => GetWindowsVersion();
        public string AvailableSpaceFormatted { get; private set; }
        public string TotalSpaceFormatted { get; private set; }
        
        private string _ramInfo;







        public SystemInfoViewModel()
        {
            
            CalculateDiskSpace();
            
            GetCPUInfo();
            
            GetRAMInfo();

            GetGraphicsCardInfo();

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

            AvailableSpaceFormatted = $"{availableSpaceGB:F2} GB : Libre";
            TotalSpaceFormatted = $"{totalSpaceGB:F2} GB : Total";
        }

        public string CPUInfo
        {
            get { return _cpuInfo; }
            set
            {
                if (_cpuInfo != value)
                {
                    _cpuInfo = value;
                    OnPropertyChanged(nameof(CPUInfo));
                }
            }
        }
        private void GetCPUInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    string cpuName = obj["Name"].ToString();
                    _cpuInfo = cpuName;
                    OnPropertyChanged(nameof(CPUInfo));
                }
            }
            catch (Exception)
            {
                _cpuInfo = "Erreur"; 
                OnPropertyChanged(nameof(CPUInfo));
            }
        }

        public string RAMInfo
        {
            get { return _ramInfo; }
            set
            {
                if (_ramInfo != value)
                {
                    _ramInfo = value;
                    OnPropertyChanged(nameof(RAMInfo));
                }
            }
        }

        private void GetRAMInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj.Properties["TotalPhysicalMemory"] != null)
                    {
                        ulong ramSize = (ulong)obj.Properties["TotalPhysicalMemory"].Value;
                        double ramSizeGB = ramSize / (1024 * 1024 * 1024.0);
                        RAMInfo = $"RAM : {ramSizeGB:F2} GB";
                    }
                    else
                    {
                        RAMInfo = "RAM : Non disponible";
                    }
                    break;
                }
            }
            catch (Exception)
            {
                RAMInfo = "RAM : Non disponible";
            }
        }

        private string _graphicsCardInfo;

        public string GraphicsCardInfo
        {
            get { return _graphicsCardInfo; }
            set
            {
                if (_graphicsCardInfo != value)
                {
                    _graphicsCardInfo = value;
                    OnPropertyChanged(nameof(GraphicsCardInfo));
                }
            }
        }

        private void GetGraphicsCardInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
                foreach (ManagementObject obj in searcher.Get())
                {
                    string graphicsCardName = obj["Caption"].ToString();
                    GraphicsCardInfo = graphicsCardName;
                    
                }
            }
            catch (Exception)
            {
                GraphicsCardInfo = "Erreur";
            }
        }


    }
}
