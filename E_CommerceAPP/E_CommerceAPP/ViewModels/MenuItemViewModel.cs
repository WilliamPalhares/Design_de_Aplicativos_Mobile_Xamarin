using E_CommerceAPP.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace E_CommerceAPP.ViewModels
{
    public class MenuItemViewModel
    {
        #region Properties

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        private NavigationService navigationService;

        #endregion

        #region Constructor

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        #endregion

        #region Commands

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);
        } 

        #endregion
    }
}