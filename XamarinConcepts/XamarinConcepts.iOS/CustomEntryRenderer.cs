using System;
using System.Runtime.Remoting.Contexts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamarinConcepts.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
        
    }
}

