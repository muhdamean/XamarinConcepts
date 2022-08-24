using System;
using Foundation;
using Xamarin.Forms;
using XamarinConcepts.iOS;
using XamarinConcepts.Services;

[assembly: Dependency(typeof(VersionAndBuild))]
namespace XamarinConcepts.iOS
{
    public class VersionAndBuild : IAppVersion
    {
        public VersionAndBuild()
        {
        }
        public string GetBuildNumber()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
        }

        public string GetVersionNumber()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }
    }
}

