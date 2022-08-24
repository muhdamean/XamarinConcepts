using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinConcepts.Views
{
    public partial class ControlTemplatePage : ContentPage
    {
        public ControlTemplatePage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ControlTemplateDetailsPage());
        }
    }
}

