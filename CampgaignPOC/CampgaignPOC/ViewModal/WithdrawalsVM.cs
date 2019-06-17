using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class WithdrawalsVM:ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand SaveCommand { get; private  set; }

        public WithdrawalsVM(INavigationService navigationSevice):base(navigationSevice)
        {

            _navigationService = navigationSevice;
            SaveCommand = new DelegateCommand(SaveButtonCommand);
        }

        private async void SaveButtonCommand()
        {
            await _navigationService.NavigateAsync("VerificationPage");
        }
    }
}
