using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace CampgaignPOC
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        protected INavigationService NavigationService { get; private set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}
