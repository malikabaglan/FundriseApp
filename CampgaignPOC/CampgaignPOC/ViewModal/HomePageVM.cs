using System;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class HomePageVM:ViewModelBase
    {
        private INavigationService _navigationService;
        public HomePageVM(INavigationService navigationService):base(navigationService)
        {
        }
    }
}
