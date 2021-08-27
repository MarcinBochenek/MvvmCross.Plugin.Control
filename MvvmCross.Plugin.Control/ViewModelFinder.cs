using MvvmCross.ViewModels;
using System;
using System.Linq;

namespace MvvmCross.Plugin.Control
{
    class ViewModelFinder : IViewModelFinder
    {
        public IMvxViewModel FindView(IMvxControl control)
        {
            var controlName = control.GetType().Name;
            var viewModelName = controlName.Replace("Control", "ViewModel");

            var viewModelType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(p => p.IsClass)
                .First(x => x.Name == viewModelName);

            var viewModel = Mvx.IoCProvider.Resolve(viewModelType) as IMvxViewModel;

            return viewModel;
        }
    }
}
