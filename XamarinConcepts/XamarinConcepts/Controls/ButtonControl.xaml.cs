using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamarinConcepts.Controls
{
    public partial class ButtonControl : ContentView
    {
        public ButtonControl()
        {
            InitializeComponent();
            labelTitle.Text = Text;
            frameBtn.BackgroundColor = ButtonColor;
            buttonImage.ImageSource = ImagePath;
        }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                                                                                typeof(string),
                                                                                typeof(ButtonControl),
                                                                                default(string),
                                                                                BindingMode.OneWay);
        public static readonly BindableProperty ColorProperty = BindableProperty.Create(nameof(ButtonColor),
                                                                               typeof(Color),
                                                                               typeof(ButtonControl),
                                                                               default(Color),
                                                                               BindingMode.OneWay);
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(ImagePath),
                                                                               typeof(string),
                                                                               typeof(ButtonControl),
                                                                               default(string),
                                                                               BindingMode.OneWay);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty,value); }
        }
        public Color ButtonColor
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public string ImagePath
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName== TextProperty.PropertyName)
            {
                labelTitle.Text = Text;
            }
            if (propertyName == ImageProperty.PropertyName)
            {
                buttonImage.ImageSource = ImagePath;
            }
            if (propertyName == ColorProperty.PropertyName)
            {
                frameBtn.BackgroundColor = ButtonColor;
            }
        }
    }
}

