using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CampgaignPOC
{
    public partial class MyAppShellPage : MasterDetailPage
    {
        public MyAppShellPage()
        {
          
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = true;
        }
    }
}
