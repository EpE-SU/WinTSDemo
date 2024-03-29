﻿using System;
using System.Threading.Tasks;

using Windows.UI.Popups;

using WinTSDemo.Core.Helpers;

namespace WinTSDemo.Helpers
{
    internal static class AuthenticationHelper
    {
        internal static async Task ShowLoginErrorAsync(LoginResultType loginResult)
        {
            switch (loginResult)
            {
                case LoginResultType.NoNetworkAvailable:
                    await new MessageDialog(
                        "DialogNoNetworkAvailableContent".GetLocalized(),
                        "DialogAuthenticationTitle".GetLocalized()).ShowAsync();
                    break;
                case LoginResultType.UnknownError:
                    await new MessageDialog(
                        "DialogStatusUnknownErrorContent".GetLocalized(),
                        "DialogAuthenticationTitle".GetLocalized()).ShowAsync();
                    break;
            }
        }
    }
}
