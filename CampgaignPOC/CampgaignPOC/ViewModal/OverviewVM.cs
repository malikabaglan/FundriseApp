using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CampgaignPOC.Modal;
using Prism.Navigation;
using Xamarin.Forms;

namespace CampgaignPOC.ViewModal
{
    public class OverviewVM :ViewModelBase

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

        public OverviewVM(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Overview";
        }
    }
}





















//        public OverviewVM()
//        {
//            Items = new ObservableCollection<Title>
//            {


//                 new Title
//                 {
//                     Header = "Title",
//                    Goal="This is Goal",
//                    TitleName="Social Noga"
//                 }



//            };

//}

//public event PropertyChangedEventHandler PropertyChanged;
//ObservableCollection<Title> items { get;  set; }
//public ObservableCollection<Title> Items
//{
//    get
//    {
//        return items;
//    }
//    set
//    {
//        items = value;
//        OnPropertyChanged(nameof(Items));
//    }
//}

//private void  OnPropertyChanged(string propertyName)
//{
//    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs( propertyName));
//}
// }
//}

