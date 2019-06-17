using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class DonateNowViewModel:ViewModelBase
    {
        private INavigationService _navagationService;
        public  DelegateCommand DonateBtnCommand { get; private set; }

        public DonateNowViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navagationService = navigationService;
            DonateBtnCommand = new DelegateCommand(DonateBtnCommandClicked);
        }
            private async void DonateBtnCommandClicked()
            {
                await _navagationService.NavigateAsync("ReviewCampgaign");
            }
        }
    }

