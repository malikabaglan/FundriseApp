﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampgaignPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyUserHomePage : TabbedPage
    {
        public MyUserHomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
