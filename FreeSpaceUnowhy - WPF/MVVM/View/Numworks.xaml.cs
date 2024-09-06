using System;
using System.IO;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace FreeSpaceUnowhy___WPF.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour Numworks.xaml
    /// </summary>
    public partial class Numworks : Window
    {
        public Numworks()
        {
            InitializeComponent();
            InitializeWebView2();
        }

        private async void InitializeWebView2()
        {
            
            await webView.EnsureCoreWebView2Async(null);

            
            string htmlFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Numworks", "Numworks.html");

            
            webView.CoreWebView2.Navigate(new Uri(htmlFilePath, UriKind.Absolute).ToString());
        }
    }
}
