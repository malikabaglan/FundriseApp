using System;
using CampgaignPOC.ViewModal;
using CampgaignPOC.View;
using Prism;
using Prism.Autofac;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampgaignPOC
{
    public partial class App : PrismApplication
    {


        public App(IPlatformInitializer initializer = null) : base(initializer) { }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModal>();
       
            containerRegistry.RegisterForNavigation<CollectionView,CVIewModel>();
            containerRegistry.RegisterForNavigation<NewCampaign, NewCampaignViewModel>();
            containerRegistry.RegisterForNavigation<CampgainGoal, CampgainGoalViewModel>();
           
            containerRegistry.RegisterForNavigation<Donate, DonateNowViewModel>();
            containerRegistry.RegisterForNavigation<ReviewCampgaign, ReviewCampVM>();
   
          
            containerRegistry.RegisterForNavigation<OverviewPage, OverviewVM>();
            containerRegistry.RegisterForNavigation<Withdrawals, WithdrawalsVM>();
            containerRegistry.RegisterForNavigation<VerificationPage, VerificationVM>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageVM>();
            containerRegistry.RegisterForNavigation<CheckYourPhonePage, CheckYourPhoneVM>();
            containerRegistry.RegisterForNavigation<TotalRaised, TotalRaisedVM>();
            containerRegistry.RegisterForNavigation<MyUserHomePage, MyUserHomePageVM>();
        }





        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new NavigationPage(new MainPage());
        //   //MainPage = new NavigationPage(new CollectionView());
        //}

        //protected override void OnStart()
        //{
        //    // Handle when your app starts
        //}

        //protected override void OnSleep()
        //{
        //    // Handle when your app sleeps
        //}

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}
    }
}
