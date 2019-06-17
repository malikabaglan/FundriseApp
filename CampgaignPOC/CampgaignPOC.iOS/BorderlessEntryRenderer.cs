
using CampgaignPOC;
using CampgaignPOC.iOS;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(BorderlessEntryRenderer), typeof(LineEntry))]
namespace CampgaignPOC.iOS
{
    public class BorderlessEntryRenderer:EntryRenderer
    {
        private CALayer _line;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            _line = null;

            if (Control == null || e.NewElement == null)
                return;

            Control.BorderStyle = UITextBorderStyle.None;

            _line = new CALayer
            {
                BorderColor = UIColor.FromRGB(146, 66, 244).CGColor,
                BackgroundColor = UIColor.FromRGB(146, 66, 244).CGColor,
                Frame = new CGRect(0, Frame.Height / 2, Frame.Width * 1, 3f)
            };

            Control.Layer.AddSublayer(_line);
        }
    }
}