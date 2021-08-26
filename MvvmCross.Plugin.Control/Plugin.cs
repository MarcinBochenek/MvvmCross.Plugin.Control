using System;

namespace MvvmCross.Plugin.Control
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public virtual void Load()
        {
            var finder = new ViewModelFinder();
            Mvx.IoCProvider.RegisterSingleton<IViewModelFinder>(finder);

            var registerer = new ViewModelRegisterer();
            registerer.RegisterAllViewModels();
        }
    }
}
