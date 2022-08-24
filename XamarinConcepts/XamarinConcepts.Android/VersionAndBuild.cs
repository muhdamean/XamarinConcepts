using System;
using Android.Content.PM;
using Xamarin.Forms;
using XamarinConcepts.Droid;
using XamarinConcepts.Services;

[assembly: Dependency(typeof(VersionAndBuild))]
namespace XamarinConcepts.Droid
{
    public class VersionAndBuild : IAppVersion
    {
        PackageInfo appInfo;
        public VersionAndBuild()
        {
            var context = Android.App.Application.Context;
            appInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);
        }
        public string GetBuildNumber()
        {
            return appInfo.VersionCode.ToString();
        }
        public string GetVersionNumber()
        {
            return appInfo.VersionName;
        }
    }
}

