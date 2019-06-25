
using System.Threading.Tasks;
using Plugin.Media;

using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace CampgaignPOC
{
    public partial class NewCampaign : ContentPage
    {

        public NewCampaign()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }







     private   async void TakePhoto_Clicked(object sender, System.EventArgs e)
        {
            await DisplayActionSheet("Add Campgain Photo",
                 "Cancel",
                "Choose from Phone", 
                "Take Photo", 
                "Add YouTube/Vimeo Video"
               
               );


        }
        
    }
}






//public static void Init() { }
//public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(NewCampaign), defaultBindingMode: BindingMode.TwoWay);
//public static BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(NewCampaign), defaultBindingMode: BindingMode.TwoWay, propertyChanged: (bindable, oldVal, newval) =>
//{
//    var matEntry = (NewCampaign)bindable;
//    matEntry.EntryField.Placeholder = (string)newval;
//    matEntry.HiddenLabel.Text = (string)newval;
//});

//public static BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(NewCampaign), defaultValue: false, propertyChanged: (bindable, oldVal, newVal) =>
//{
//    var matEntry = (NewCampaign)bindable;
//    matEntry.EntryField.IsPassword = (bool)newVal;
//});
//public static BindableProperty KeyboardProperty = BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(NewCampaign), defaultValue: Keyboard.Default, propertyChanged: (bindable, oldVal, newVal) =>
//{
//    var matEntry = (NewCampaign)bindable;
//    matEntry.EntryField.Keyboard = (Keyboard)newVal;
//});
//public static BindableProperty AccentColorProperty = BindableProperty.Create(nameof(AccentColor), typeof(Color), typeof(NewCampaign), defaultValue: Color.Accent);
//public Color AccentColor
//{
//    get
//    {
//        return (Color)GetValue(AccentColorProperty);
//    }
//    set
//    {
//        SetValue(AccentColorProperty, value);
//    }
//}
//public Keyboard Keyboard
//{
//    get
//    {
//        return (Keyboard)GetValue(KeyboardProperty);
//    }
//    set
//    {
//        SetValue(KeyboardProperty, value);
//    }
//}

//public bool IsPassword
//{
//    get
//    {
//        return (bool)GetValue(IsPasswordProperty);
//    }
//    set
//    {
//        SetValue(IsPasswordProperty, value);
//    }
//}

//public string Text
//{
//    get
//    {
//        return (string)GetValue(TextProperty);
//    }
//    set
//    {
//        SetValue(TextProperty, value);
//    }
//}
//public string Placeholder
//{
//    get
//    {
//        return (string)GetValue(PlaceholderProperty);
//    }
//    set
//    {
//        SetValue(PlaceholderProperty, value);
//    }
//}



//public NewCampaign()
//{
//    InitializeComponent();
//    EntryField.BindingContext = this;
//    EntryField.Focused += async (s, a) =>
//    {
//        HiddenBottomBorder.BackgroundColor = AccentColor;
//        HiddenLabel.TextColor = AccentColor;
//        HiddenLabel.IsVisible = true;
//        if (string.IsNullOrEmpty(EntryField.Text))
//        {
//            // animate both at the same time
//            await Task.WhenAll(
//                HiddenBottomBorder.LayoutTo(new Rectangle(BottomBorder.X, BottomBorder.Y, BottomBorder.Width, BottomBorder.Height), 200),
//                HiddenLabel.FadeTo(1, 60),
//                HiddenLabel.TranslateTo(HiddenLabel.TranslationX, EntryField.Y - EntryField.Height + 4, 200, Easing.BounceIn)
//             );
//            EntryField.Placeholder = null;
//        }
//        else
//        {
//            await HiddenBottomBorder.LayoutTo(new Rectangle(BottomBorder.X, BottomBorder.Y, BottomBorder.Width, BottomBorder.Height), 200);
//        }
//    };
//    EntryField.Unfocused += async (s, a) =>
//    {
//        HiddenLabel.TextColor = Color.Gray;
//        if (string.IsNullOrEmpty(EntryField.Text))
//        {
//            // animate both at the same time
//            await Task.WhenAll(
//                HiddenBottomBorder.LayoutTo(new Rectangle(BottomBorder.X, BottomBorder.Y, 0, BottomBorder.Height), 200),
//                HiddenLabel.FadeTo(0, 180),
//                HiddenLabel.TranslateTo(HiddenLabel.TranslationX, EntryField.Y, 200, Easing.BounceIn)
//             );
//            EntryField.Placeholder = Placeholder;
//        }
//        else
//        {
//            await HiddenBottomBorder.LayoutTo(new Rectangle(BottomBorder.X, BottomBorder.Y, 0, BottomBorder.Height), 200);
//        }
//    };
//}
//}

//}