﻿using System;

using GalaSoft.MvvmLight;

using Windows.UI.Xaml.Media.Imaging;

using WinTSDemo.Helpers;

namespace WinTSDemo.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private string _name;
        private string _userPrincipalName;
        private BitmapImage _photo;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string UserPrincipalName
        {
            get => _userPrincipalName;
            set => Set(ref _userPrincipalName, value);
        }

        public BitmapImage Photo
        {
            get => _photo;
            set => Set(ref _photo, value);
        }

        public UserViewModel()
        {
        }
    }
}
