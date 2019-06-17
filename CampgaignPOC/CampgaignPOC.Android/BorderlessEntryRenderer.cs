
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


using CampgaignPOC;
using CampgaignPOC.Droid;

[assembly: ExportRenderer(typeof(BorderlessEntryRenderer), typeof(LineEntry))]
namespace CampgaignPOC.Droid
{
    public class BorderlessEntryRenderer:EntryRenderer


    {
        public BorderlessEntryRenderer(Context context) : base(context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
        }
    }
}



