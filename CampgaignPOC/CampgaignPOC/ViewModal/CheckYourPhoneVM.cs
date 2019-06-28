using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace CampgaignPOC.ViewModal
{
    public class CheckYourPhoneVM : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand VerifyCommand { get; private set; }
        public CheckYourPhoneVM(INavigationService navigationService) : base(navigationService)
        {

            _navigationService = navigationService;
            VerifyCommand = new DelegateCommand(VerifyCommandClicked);


        }
        private async void VerifyCommandClicked()
        {
            await _navigationService.NavigateAsync("TotalRaised");
        }
    }

}


