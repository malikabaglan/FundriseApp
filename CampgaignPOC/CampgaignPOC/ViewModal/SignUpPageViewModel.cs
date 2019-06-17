using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class SignUpPageViewModel : ViewModelBase
    {
        private INavigationService _navagationService;
        public DelegateCommand SaveCommand { get; private set; }
        public SignUpPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navagationService = navigationService;
            SaveCommand = new DelegateCommand(saveChangesBtnClicked);
        }

        private async void saveChangesBtnClicked()
        {
            await _navagationService.NavigateAsync("CollectionView");
        }
    }
}
