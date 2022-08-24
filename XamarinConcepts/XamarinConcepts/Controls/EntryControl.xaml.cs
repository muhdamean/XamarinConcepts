using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamarinConcepts.Controls
{
    public partial class EntryControl : ContentView
    {
        public EntryControl()
        {
            InitializeComponent();
            titleTxt.Text = Title;
            entryBx.Text = Text;
            entryBx.IsPassword = IsPassword;
            imagePath.Source = ImagePath;

            entryBx.TextChanged += OnTextChanged;
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
                                                                        typeof(string),
                                                                        typeof(EntryControl),
                                                                        default(string),
                                                                        BindingMode.OneWay);
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                                                                        typeof(string),
                                                                        typeof(EntryControl),
                                                                        default(string),
                                                                        BindingMode.OneWay);
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword),
                                                                        typeof(bool),
                                                                        typeof(EntryControl),
                                                                        default(bool),
                                                                        BindingMode.OneWay);
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(ImagePath),
                                                                               typeof(string),
                                                                               typeof(EntryControl),
                                                                               default(string),
                                                                               BindingMode.OneWay);


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set { SetValue(IsPasswordProperty, value); }
        }
        public string ImagePath
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName== TitleProperty.PropertyName)
            {
                titleTxt.Text = Title;
            }
            if (propertyName == TextProperty.PropertyName)
            {
                entryBx.Text = Text;
            }
            if (propertyName == IsPasswordProperty.PropertyName)
            {
                entryBx.IsPassword = IsPassword;
            }
            if (propertyName == ImageProperty.PropertyName)
            {
                imagePath.Source = ImagePath;
            }
        }
    }
    
}

