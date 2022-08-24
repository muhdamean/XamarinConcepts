using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinConcepts.Controls;
using XamarinConcepts.Droid;

[assembly: ExportRenderer(typeof(MyEntry),typeof(CustomEntryRenderer))]
namespace XamarinConcepts.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.Background = null;
            }
        }
    }
}

