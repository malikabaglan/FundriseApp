
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace CampgaignPOC.ViewModal
{
    public class NotificationsVM: ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand SaveChangesCommand { get; private set; }

        public NotificationsVM(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            SaveChangesCommand = new DelegateCommand(SaveChangesButtonCommand);
        }
        private async void SaveChangesButtonCommand()
        {
           // await _navigationService.NavigateAsync("OverviewPage");
            await _navigationService.NavigateAsync("Withdrawals");
        }
    }
}

