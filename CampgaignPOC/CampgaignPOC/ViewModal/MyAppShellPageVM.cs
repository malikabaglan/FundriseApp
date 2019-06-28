using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class MyAppShellPageVM:ViewModelBase
    {

        private INavigationService _navigationService;

        public DelegateCommand NewCampgainCommand { get; private set; }
        public DelegateCommand AccountSettingsCommand { get; private set; }
        public DelegateCommand WithdrawsCommand{ get; private set; }

        public DelegateCommand MyCampgainsCommand { get; private set; }
        public DelegateCommand MyDonationsCommand { get; private set; }
        

        public MyAppShellPageVM(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NewCampgainCommand = new DelegateCommand(NewCampgainCommandBtnClicked);
            AccountSettingsCommand = new DelegateCommand(NAccountSettingsCommandBtnClicked);
            WithdrawsCommand = new DelegateCommand(WithdrawsCommandBtnClicked);
            MyCampgainsCommand = new DelegateCommand(MyCampgainsCommandtnClicked);
            MyDonationsCommand = new DelegateCommand(MyDonationsCommandBtnClicked);
        }
        private async void NewCampgainCommandBtnClicked()
        {
          
            await _navigationService.NavigateAsync("CollectionView");
}
        private async void NAccountSettingsCommandBtnClicked()
        {

            await _navigationService.NavigateAsync("MyUserHomePage");
        }
        private async void WithdrawsCommandBtnClicked()
        {

            await _navigationService.NavigateAsync("TotalRaised");
        }
        private async void MyCampgainsCommandtnClicked()
        {

            await _navigationService.NavigateAsync("MyCampgainsPage");
        }
        private async void MyDonationsCommandBtnClicked()
        {

            await _navigationService.NavigateAsync("Donate");
        }
    }
}







