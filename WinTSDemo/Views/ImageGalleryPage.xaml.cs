﻿using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using WinTSDemo.ViewModels;

namespace WinTSDemo.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ImageGalleryViewModel; }
        }

        public ImageGalleryPage()
        {
            InitializeComponent();
            Loaded += ImageGalleryPage_Loaded;
        }

        private async void ImageGalleryPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();
        }
    }
}
