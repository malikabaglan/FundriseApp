using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using CampgaignPOC;

using CampgaignPOC.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomButtons), typeof(CurvedCornersButtonRenderer))]
namespace CampgaignPOC.Droid
{
    [Obsolete]
    public class CurvedCornersButtonRenderer: ButtonRenderer
    {
        private GradientDrawable _gradientBackground;
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
            if (e.PropertyName == CustomButtons.CustomBorderColorProperty.PropertyName ||
                 e.PropertyName == CustomButtons.CustomBorderRadiusProperty.PropertyName ||
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
            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.CustomBackgroundColor.ToAndroid());
            // Thickness of the stroke line  
            _gradientBackground.SetStroke((int)view.CustomBorderWidth, view.CustomBorderColor.ToAndroid());
            // Radius for the curves  
            _gradientBackground.SetCornerRadius(
                DpToPixels(this.Context, Convert.ToSingle(view.CustomBorderRadius)));
            // set the background of the label  
            Control.SetBackground(_gradientBackground);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}