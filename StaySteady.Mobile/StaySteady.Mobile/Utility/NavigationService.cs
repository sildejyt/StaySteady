﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace StaySteady.Mobile.Utility
{
    public class NavigationService : INavigationService
    {
        private INavigation _navigation;

        public NavigationService()
        {
            _navigation = App.Navigation;
        }

        public void GoBack()
        {
            _navigation.PopAsync(true);
        }

        public void NavigateTo(string pageKey)
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            throw new NotImplementedException();
        }

        public string CurrentPageKey { get; }
    }
}
