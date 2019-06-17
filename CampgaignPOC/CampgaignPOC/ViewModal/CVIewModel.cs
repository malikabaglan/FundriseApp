using System;
using Prism.Commands;
using Prism.Navigation;
using CampgaignPOC.Modal;

namespace CampgaignPOC.ViewModal
{
    public class CVIewModel:ViewModelBase
    {

        private INavigationService _navigationService;
        public DelegateCommand StartFundCommand { get; private set; }

               public CVIewModel(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            StartFundCommand = new DelegateCommand(StartFundBtnClicked);
        }

     private   async void StartFundBtnClicked ()
        {
            await _navigationService.NavigateAsync("NewCampaign");
        }
    }
}





