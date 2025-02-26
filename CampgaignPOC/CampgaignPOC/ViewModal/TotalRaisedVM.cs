﻿using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class TotalRaisedVM:ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand SetUpCommand { get; private set; }
        public TotalRaisedVM(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            SetUpCommand = new DelegateCommand(SetUpCommandClicked);
        }

        private async void SetUpCommandClicked()
        {

            // await _navigationService.NavigateAsync("MyCampgainsPage");
            //  await _navigationService.NavigateAsync("OverviewPage");
            await _navigationService.NavigateAsync("Withdrawals");
            
        }
    }
}

