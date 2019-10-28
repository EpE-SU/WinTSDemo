using System;

using Windows.UI.Xaml.Controls;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
