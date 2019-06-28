using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class VerificationVM:ViewModelBase
    {
        private INavigationService _navigationService;
       public DelegateCommand SentTheCode { get; private set; }
        public VerificationVM(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            SentTheCode = new DelegateCommand(SentTheCodeClicked);
        }
          private async void SentTheCodeClicked()
        {
       await _navigationService.NavigateAsync("CheckYourPhonePage");
        }
    }
}
