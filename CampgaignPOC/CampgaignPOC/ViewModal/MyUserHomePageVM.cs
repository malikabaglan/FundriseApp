using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class MyUserHomePageVM:ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand SaveCommand { get; private set; }
        public DelegateCommand SaveChangesCommand { get; private set; }
        public MyUserHomePageVM(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            SaveCommand = new DelegateCommand(saveChangesBtnClicked);
            SaveChangesCommand = new DelegateCommand(SaveChangesButtonCommand);
        }


        private async void SaveChangesButtonCommand()
        {
            // await _navigationService.NavigateAsync("OverviewPage");
         //   await _navigationService.NavigateAsync("Withdrawals");
            await _navigationService.NavigateAsync("CollectionView");



        }



        private async void saveChangesBtnClicked()
        {
          //  await display Alert
          
        }
    }
}
