using System;
using Prism.Commands;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class NewCampaignViewModel:ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand NextCommand { get; private set; }
        public NewCampaignViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NextCommand = new DelegateCommand(NextBtnClicked);
        }
            private async void NextBtnClicked()
            {
                await _navigationService.NavigateAsync("CampgainGoal");
            }
        }
    }

