
using MvvmCross;
using MvvmCross.Localization;
using MvvmCross.Plugin.ResxLocalization;
using MvvmCross.ViewModels;
using ResxLocalizationTest.Localization;

namespace ResxLocalizationTest
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            Mvx.IoCProvider.RegisterSingleton<IMvxTextProvider>(new MvxResxTextProvider(AppResources.ResourceManager));

            RegisterAppStart<MainViewModel>();
        }
    }
}
