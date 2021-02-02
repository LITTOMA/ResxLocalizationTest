using MvvmCross.Localization;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ResxLocalizationTest
{
    public class MainViewModel : MvxViewModel
    {
        public IMvxLanguageBinder TextSource => new MvxLanguageBinder();

        public MainViewModel()
        {

        }

        public string GetText([CallerMemberName] string name = "")
        {
            return TextSource.GetText(name);
        }

        public string StrHello => GetText();
    }
}
