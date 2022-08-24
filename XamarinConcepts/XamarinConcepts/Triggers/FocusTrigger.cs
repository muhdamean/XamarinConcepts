using System;
using Xamarin.Forms;

namespace XamarinConcepts.Triggers
{
    public class FocusTrigger : TriggerAction<Entry>
    {
        public FocusTrigger()
        {
        }
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = Color.LightGray;
        }
    }
}

