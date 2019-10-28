using System;

using Windows.UI.Xaml.Controls;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    public sealed partial class WebViewPage : Page
    {
        private WebViewViewModel ViewModel
        {
            get { return ViewModelLocator.Current.WebViewViewModel; }
        }

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
