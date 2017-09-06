using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCrossTimeHash.Services;
using MvvmCrossTimeHash.ViewModels;

namespace MvvmCrossTimeHash
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ITimeHashGenerator, TimeHashGenerator>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TimeHashViewModel>());
        }
    }
}
