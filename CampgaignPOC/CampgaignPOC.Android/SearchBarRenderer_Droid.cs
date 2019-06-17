
//using System;
//using Android.Content;
//using Android.Graphics.Drawables;
//using Android.Util;
//using Android.Widget;
//using CampgaignPOC;

//using CampgaignPOC.Droid;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;
//using static Java.Util.ResourceBundle;

//[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(SearchBarRenderer_Droid))]
//namespace CampgaignPOC.Droid
//{
//    public class SearchBarRenderer_Droid:SearchBar
//    {
//        CustomSearchBar element;
//        public SearchBarRenderer_Droid(Context context) : base(context) { }

//        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
//        {
//            base.OnElementChanged(e);
//            if (e.OldElement==null)
//            {
//                element = (CustomSearchBar)Element;
//                var _gradientBackground = new GradientDrawable();
//                _gradientBackground.SetShape(ShapeType.Rectangle);


//                LinearLayout linearLayout = this.Control.GetChildAt(0) as LinearLayout;
//                linearLayout = linearLayout.GetChildAt(2) as LinearLayout;
//                linearLayout = linearLayout.GetChildAt(1) as LinearLayout;
//                linearLayout.Background = null;






//                _gradientBackground.SetStroke(element.BorderWidth, element.BorderColor.ToAndroid();
//                _gradientBackground.SetCornerRadius(DpToPixels(this.Context, Convert.ToSingle(element.CornerRadius)));

//                Control.SetBackground(_gradientBackground);
//                Control.SetPadding(
//                    (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingTop,
//                    (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingBottom;


//            }

                        
//            }
//        public static float DpToPixels(Context context,float valueInDp)
//        {
//            DisplayMetrics metrics = context.Resources.DisplayMetrics;
//            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp,metrics)

//        }
//        }

        
//}