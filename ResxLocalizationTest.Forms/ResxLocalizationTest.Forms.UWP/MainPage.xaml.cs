using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using ResxLocalizationTest.Forms.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ResxLocalizationTest.Forms.UWP
{
    public sealed partial class MainPage : MvxFormsWindowsPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }

    public abstract class ProxyMvxApplication
        : MvxWindowsApplication<MvxFormsWindowsSetup<ResxLocalizationTest.App, FormsApp>, ResxLocalizationTest.App, FormsApp, MainPage>
    {
    }
}
