using System;
using Xamarin.Forms;

namespace CampgaignPOC
{
    public class CustomSearchBar:SearchBar 
    {
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor),
            typeof(Color), 
            typeof(CustomSearchBar), 
            Color.Default);



        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth),
            typeof(int),
             typeof(CustomSearchBar), 
             default(int));


        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
            typeof(double),
            typeof(CustomSearchBar),
            default(double));




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
    }
}
