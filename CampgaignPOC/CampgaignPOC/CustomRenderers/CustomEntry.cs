using System;
using Xamarin.Forms;

namespace CampgaignPOC
{     public class CustomEntry : Entry     {         public CustomEntry()         {             this.HeightRequest = 50;         }          #region properties
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image),
                                                                                        typeof(string),
                                                                                        typeof(CustomEntry),
                                                                                        string.Empty);

        public static readonly BindableProperty LineColorProperty = BindableProperty.Create(nameof(LineColor),
                                                                                              typeof(Color),
                                                                                              typeof(CustomEntry),
                                                                                              Color.Transparent);

        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(nameof(ImageHeight),
                                                                                              typeof(int),
                                                                                              typeof(CustomEntry),
                                                                                              null);

        public static readonly BindableProperty ImageWidthProperty = BindableProperty.Create(nameof(ImageWidth),
                                                                                             typeof(int),
                                                                                             typeof(CustomEntry),
                                                                                             null);

        public static readonly BindableProperty ImageAlignmentProperty = BindableProperty.Create(nameof(ImageAlignment),
                                                                                             typeof(ImageAlignmentEnum),
                                                                                             typeof(CustomEntry),
                                                                                             null);

        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor),
                                                                                              typeof(Color),
                                                                                              typeof(CustomEntry),
                                                                                              Color.Transparent);

        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth),
                                                                                              typeof(int),
                                                                                              typeof(CustomEntry),
                                                                                              null);

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
                                                                                              typeof(double),
                                                                                              typeof(CustomEntry),
                                                                                              null);

        public static readonly BindableProperty IsCurvedCornersEnabledProperty = BindableProperty.Create(nameof(IsCurvedCornersEnabled),
                                                                                              typeof(bool),
                                                                                              typeof(CustomEntry),
                                                                                              false);

        public static readonly BindableProperty EntryIdProperty = BindableProperty.Create(nameof(EntryID),
                                                                                              typeof(int),
                                                                                              typeof(CustomEntry),
                                                                                              0);


        #endregion

        public string Image
        {
            get => (string)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        public Color LineColor
        {
            get => (Color)GetValue(LineColorProperty);
            set => SetValue(LineColorProperty, value);
        }

        public int ImageHeight
        {
            get => (int)GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }

        public int ImageWidth
        {
            get => (int)GetValue(ImageWidthProperty);
            set => SetValue(ImageWidthProperty, value);
        }

        public ImageAlignmentEnum ImageAlignment
        {
            get => (ImageAlignmentEnum)GetValue(ImageAlignmentProperty);
            set => SetValue(ImageAlignmentProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }

        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public bool IsCurvedCornersEnabled
        {
            get => (bool)GetValue(IsCurvedCornersEnabledProperty);
            set => SetValue(IsCurvedCornersEnabledProperty, value);
        }
        public int EntryID
        {
            get => (int)GetValue(EntryIdProperty);
            set => SetValue(EntryIdProperty, value);
        }
    }

    public enum ImageAlignmentEnum
    {
        Left,
        Right
    }
}