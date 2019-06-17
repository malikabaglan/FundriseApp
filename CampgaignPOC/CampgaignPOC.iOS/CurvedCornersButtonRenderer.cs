using System;
using System.ComponentModel;
using CampgaignPOC;

using CampgaignPOC.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButtons), typeof(CurvedCornersButtonRenderer))]
namespace CampgaignPOC.iOS
{
    public class CurvedCornersButtonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            var view = (CustomButtons)Element;
            if (view == null) return;
            Paint(view);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CustomButtons.CustomBorderRadiusProperty.PropertyName ||
               e.PropertyName == CustomButtons.CustomBorderColorProperty.PropertyName ||
               e.PropertyName == CustomButtons.CustomBorderWidthProperty.PropertyName)
            {
                if (Element != null)
                {
                    Paint((CustomButtons)Element);
                }
            }
        }
        private void Paint(CustomButtons view)
        {
            this.Layer.CornerRadius = (float)view.CustomBorderRadius;
            this.Layer.BorderColor = view.CustomBorderColor.ToCGColor();
            this.Layer.BackgroundColor = view.CustomBackgroundColor.ToCGColor();
            this.Layer.BorderWidth = (int)view.CustomBorderWidth;
        }
    }
}