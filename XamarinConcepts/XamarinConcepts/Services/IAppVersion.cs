using System;
namespace XamarinConcepts.Services
{
    public interface IAppVersion
    {
        string GetVersionNumber();
        string GetBuildNumber();
    }
}

