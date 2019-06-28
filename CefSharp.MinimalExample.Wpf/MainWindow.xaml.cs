using System.Windows;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms.Integration;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
		WindowsFormsHost host = null;

        public MainWindow()
        {
            InitializeComponent();

			ChromiumWebBrowser chromeBr = new ChromiumWebBrowser();


			host = new WindowsFormsHost();
			host.Child = chromeBr;

			chromeBr.Load("https://www.google.com");

			BrowserContainer.Content = host;
		}
    }
}
