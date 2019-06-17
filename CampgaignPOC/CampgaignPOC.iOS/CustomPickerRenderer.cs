using System;
using System.Drawing;
using CampgaignPOC;

using CampgaignPOC.iOS;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace CampgaignPOC.iOS
{
    public class CustomPickerRenderer: PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var element = (CustomPicker)Element;
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;

                Control.KeyboardAppearance = UIKeyboardAppearance.Dark;
                Control.ReturnKeyType = UIReturnKeyType.Done;
                // Radius for the curves  
                Control.Layer.CornerRadius = Convert.ToSingle(element.CornerRadius);
                // Thickness of the Border Color  
                Control.Layer.BorderColor = element.BorderColor.ToCGColor();
                Control.Layer.BorderWidth = element.BorderWidth;
                Control.ClipsToBounds = true;
                Control.LeftView = new UIView(new CGRect(0, 0, 15, 0));
                Control.LeftViewMode = UITextFieldViewMode.Always;

                if (!string.IsNullOrEmpty(element.Image))
                {
                    switch (element.ImageAlignment)
                    {

                        case ImageAlignmentEnum.Left:

                            //   Control.LeftViewMode = UITextFieldViewMode.Always;
                            Control.LeftView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                            break;
                        case ImageAlignmentEnum.Right:
                            Control.RightViewMode = UITextFieldViewMode.Always;
                            Control.RightView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                            break;
                    }
                }

                /*Control.BorderStyle = UITextBorderStyle.None;
                CALayer bottomBorder = new CALayer
                {
                    Frame = new CGRect(0.0f, element.HeightRequest - 1, this.Frame.Width, 1.0f),
                    BorderWidth = 2.0f,
                    BorderColor = element.LineColor.ToCGColor()
                };

                Control.Layer.AddSublayer(bottomBorder);
                Control.Layer.MasksToBounds = true;*/
            }
        }

        private UIView GetImageView(string imagePath, int height, int width)
        {
            var uiImageView = new UIImageView(UIImage.FromBundle(imagePath))
            {
                Frame = new RectangleF(0, 0, width, height)
            };
            UIView objLeftView = new UIView(new System.Drawing.Rectangle(0, 0, width + 10, height));
            objLeftView.AddSubview(uiImageView);

            return objLeftView;
        }
    }
}