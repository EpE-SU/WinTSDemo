using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    public sealed partial class ContentGridPage : Page
    {
        private ContentGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ContentGridViewModel; }
        }

        public ContentGridPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
