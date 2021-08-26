using MvvmCross.Plugin.Control.Sample.Core.ViewModels;
using MvvmCross.ViewModels;
using System;

namespace MvvmCross.Plugin.Control.Sample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewlModel>();
        }
    }
}
