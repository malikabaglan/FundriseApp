using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Util;
using CampgaignPOC;

using CampgaignPOC.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace CampgaignPOC.Droid
{
    public class CustomPickerRenderer : PickerRenderer


    {
        CustomPicker element;
        public CustomPickerRenderer(Context context) : base(context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                if (e.NewElement != null)
                {
                    element = (CustomPicker)Element;

                    if (!string.IsNullOrEmpty(element.Image))
                    {
                        switch (element.ImageAlignment)
                        {
                            case ImageAlignmentEnum.Left:
                                Control.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable(element.Image), null, null, null);
                                break;
                            case ImageAlignmentEnum.Right:
                                Control.SetCompoundDrawablesWithIntrinsicBounds(null, null, GetDrawable(element.Image), null);
                                break;
                        }
                    }

                    //Control.CompoundDrawablePadding = 25;
                    //Control.Background.SetColorFilter(element.LineColor.ToAndroid(), PorterDuff.Mode.SrcAtop);

                    if (element.IsCurvedCornersEnabled)
                    {
                        // creating gradient drawable for the curved background  
                        var _gradientBackground = new GradientDrawable();
                        _gradientBackground.SetShape(ShapeType.Rectangle);
                        _gradientBackground.SetColor(element.BackgroundColor.ToAndroid());

                        // Thickness of the stroke line  
                        _gradientBackground.SetStroke(element.BorderWidth, element.BorderColor.ToAndroid());

                        // Radius for the curves  
                        _gradientBackground.SetCornerRadius(
                            DpToPixels(this.Context, Convert.ToSingle(element.CornerRadius)));

                        // set the background of the   
                        Control.SetBackground(_gradientBackground);
                    }
                    // Set padding for the internal text from border  
                    Control.SetPadding(
                        (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingTop,
                        (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingBottom);
                }
            }
        }

        private BitmapDrawable GetDrawable(string imageEntryImage)
        {
            int resID = Resources.GetIdentifier(imageEntryImage, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}