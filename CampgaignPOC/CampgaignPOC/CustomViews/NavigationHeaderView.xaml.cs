using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CampgaignPOC
{
    public partial class NavigationHeaderView : ContentView
    {
        public NavigationHeaderView()
        {
            InitializeComponent();
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == BackButtonImageProperty.PropertyName)
            {
                Image.Source = BackButtonImage;
            }
            if (propertyName == NavigationTitleProperty.PropertyName)
            {
                Title.Text = NavigationTitle;
            }
        }

        //public event EventHandler<EventArgs> Tapped;
        protected void ClickedEvent(object sender, EventArgs e)
        {
            //Tapped?.Invoke(this, e);
            Command?.Execute(CommandProperty);
        }

        #region properties
        public static readonly BindableProperty BackButtonImageProperty = BindableProperty.Create(
            nameof(BackButtonImage), typeof(string), typeof(NavigationHeaderView), default(string));

        public static readonly BindableProperty NavigationTitleProperty = BindableProperty.Create(
            nameof(NavigationTitle), typeof(string), typeof(NavigationHeaderView), default(string));

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command), typeof(ICommand), typeof(NavigationHeaderView), null);

        #endregion


        public string BackButtonImage
        {
            get { return (string)GetValue(BackButtonImageProperty); }
            set { SetValue(BackButtonImageProperty, value); }
        }

        public string NavigationTitle
        {
            get { return (string)GetValue(NavigationTitleProperty); }
            set { SetValue(NavigationTitleProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
    }
}