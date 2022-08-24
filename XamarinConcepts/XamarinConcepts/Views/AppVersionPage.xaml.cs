using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinConcepts.Services;

namespace XamarinConcepts.Views
{
    public partial class AppVersionPage : ContentPage
    {
        public AppVersionPage()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            VersionTxt.Text = DependencyService.Get<IAppVersion>().GetVersionNumber();
            BuildTxt.Text = DependencyService.Get<IAppVersion>().GetBuildNumber();
        }
    }
}

