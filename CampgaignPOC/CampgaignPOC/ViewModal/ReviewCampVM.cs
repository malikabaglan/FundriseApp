using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class ReviewCampVM:ViewModelBase
    {
        private INavigationService _navigationService;
       
           
        public DelegateCommand ReviewCamCommand { get; private set; }

        public ReviewCampVM(INavigationService navigationService) : base(navigationService)
        {

            _navigationService = navigationService;
            ReviewCamCommand = new DelegateCommand(ClickNotification);
        }
        private async void ClickNotification()
        {
           // await _navigationService.NavigateAsync("Withdrawals");
        }
    }
}






