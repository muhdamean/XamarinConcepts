using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinConcepts.Views
{
    public partial class ControlTemplateDetailsPage : ContentPage
    {
        public ControlTemplateDetailsPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}

