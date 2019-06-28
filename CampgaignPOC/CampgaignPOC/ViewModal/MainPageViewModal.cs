using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class MainPageViewModal : ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand SigninCommand { get; private set; }
        public DelegateCommand RegisterCommand { get; private set; }
        public MainPageViewModal(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            SigninCommand = new DelegateCommand(signinButtonClicked);
            RegisterCommand = new DelegateCommand(RegisterCommandButtonClicked);
        }

        private async void signinButtonClicked()
        {
           // await _navigationService.NavigateAsync("CollectionView");
            await _navigationService.NavigateAsync("MyAppShellPage");
        }
        private async void RegisterCommandButtonClicked()
        {
           await _navigationService.NavigateAsync("MyUserHomePage");
            
        }
    }

};