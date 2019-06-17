using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Views;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Support.V4.Content;

[assembly: ResolutionGroupName("Effects")]
[assembly: ExportEffect(typeof(ClearEntryEffect.Droid.Effects.ClearEntryEffect), "ClearEntryEffect")]
namespace ClearEntryEffect.Droid.Effects
{
    public class ClearEntryEffect //: PlatformEffect
    {
    //    protected override void OnAttached()
    //    {
    //        ConfigureControl();
    //    }

    //    protected override void OnDetached()
    //    {
    //    }

    //    private void ConfigureControl()
    //    {

          
    //        EditText editText = ((EditText)Control);
    // editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0,Resource, 0);
    //        editText.SetOnTouchListener(new OnDrawableTouchListener());
    //        editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, Resource.Drawable);
    //    }
    //}

    // private BitmapDrawable GetDrawable(string imageEntryImage)     //    {     //        int resID = Resources.GetIdentifier(imageEntryImage, "drawable", this.Context.PackageName);     //        var drawable = ContextCompat.GetDrawable(this.Context, resID);     //        var bitmap = ((BitmapDrawable)drawable).Bitmap;      //        //return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));     //        return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 24, 24, true));     //    }





    //public class OnDrawableTouchListener : Java.Lang.Object, Android.Views.View.IOnTouchListener
    //{
        //public bool OnTouch(Android.Views.View v, MotionEvent e)
        //{
        //    if (v is EditText && e.Action == MotionEventActions.Up)
        //    {
        //        EditText editText = (EditText)v;
        //        if (e.RawX >= (editText.Right - editText.GetCompoundDrawables()[2].Bounds.Width()))
        //        {
        //            editText.Text = string.Empty;
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}