using System;
using Xamarin.Forms;

namespace XamarinConcepts.Behaviors
{
    public class EntryBehavior : Behavior<Entry>
    {
        public EntryBehavior()
        {
        }
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TectChanged;
        }

        private void Bindable_TectChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length == 0)
                ((Entry)sender).BackgroundColor = Color.Red;
            else
                ((Entry)sender).BackgroundColor = Color.White;
        }
    }
}

