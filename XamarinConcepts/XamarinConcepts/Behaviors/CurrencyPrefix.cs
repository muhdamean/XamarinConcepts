using System;
using Xamarin.Forms;
using XamarinConcepts.Controls;

namespace XamarinConcepts.Behaviors
{
    public class CurrencyPrefix : Behavior<Entry>
    {
        public CurrencyPrefix()
        {
        }
        public static readonly BindableProperty CurrencyProperty = BindableProperty.Create(nameof(Currency),
                                                                               typeof(string),
                                                                               typeof(CurrencyPrefix),
                                                                               "$"
                                                                               );


        public string Currency
        {
            get { return (string)GetValue(CurrencyProperty); }
            set { SetValue(CurrencyProperty, value); }
        }
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnTextChanged;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(e.NewTextValue) && !e.NewTextValue.StartsWith(Currency))
                ((Entry)sender).Text = Currency + e.NewTextValue;
        }
    }
}

