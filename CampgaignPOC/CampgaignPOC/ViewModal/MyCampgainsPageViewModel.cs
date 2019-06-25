using System;
using Prism.Navigation;

namespace CampgaignPOC.ViewModal
{
    public class MyCampgainsPageViewModel:ViewModelBase
    {

        private INavigationService _navigationService;



        #region propertied
        private string _Title = string.Empty;
        public new string Title // or public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }
        #endregion



        public MyCampgainsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Overview";
        }
    }
}
