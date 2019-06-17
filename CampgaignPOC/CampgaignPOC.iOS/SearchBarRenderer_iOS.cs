using System;
using CampgaignPOC;
using CampgaignPOC.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(CustomSearchBar),typeof(SearchBarRenderer_iOS))]
namespace CampgaignPOC.iOS
{
    public class SearchBarRenderer_iOS:SearchBarRenderer 
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement !=null)
            {
                var element = (CustomSearchBar)Element;
                Control.Layer.BorderWidth = 0;


                Control.KeyboardAppearance = UIKit.UIKeyboardAppearance.Dark;
                Control.ReturnKeyType = UIKit.UIReturnKeyType.Done;
                //radius for the curves

                Control.Layer.CornerRadius = Convert.ToSingle(element.CornerRadius);
                //thicknes of the border color 
                Control.Layer.BorderColor = element.BorderColor.ToCGColor();
                Control.Layer.BorderWidth = element.BorderWidth;
                Control.ClipsToBounds = true;


            }
        }
    }
}
