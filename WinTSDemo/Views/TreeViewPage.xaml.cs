﻿using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    // For more info about the TreeView Control see
    // https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/tree-view
    // For other samples, get the XAML Controls Gallery app http://aka.ms/XamlControlsGallery
    public sealed partial class TreeViewPage : Page
    {
        private TreeViewViewModel ViewModel
        {
            get { return ViewModelLocator.Current.TreeViewViewModel; }
        }

        public TreeViewPage()
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
