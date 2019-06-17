using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class CampgainGoalViewModel:ViewModelBase
    {
        private INavigationService _navagationService;
        public DelegateCommand ContinueCommand { get; private set; }
        public CampgainGoalViewModel(INavigationService navigationService):base (navigationService)
        {
            _navagationService = navigationService;
            ContinueCommand = new DelegateCommand(ContinueCommandBtnClicked);
        }
        private async void ContinueCommandBtnClicked()
        {
            await _navagationService.NavigateAsync("Donate");
        }
    }
}
