using System;

using Windows.UI.Xaml.Controls;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel
        {
            get { return ViewModelLocator.Current.TabbedViewModel; }
        }

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
