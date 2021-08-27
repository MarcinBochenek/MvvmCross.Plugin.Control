using MvvmCross.ViewModels;
using System;
using System.Linq;

namespace MvvmCross.Plugin.Control
{
    class ViewModelFinder : IViewModelFinder
    {
        private const string ControlSuffix = "Control";
        private const string ViewModelSuffix = "ViewModel";

        public IMvxViewModel FindView(IMvxControl control)
        {
            var controlName = control.GetType().Name;
            if (controlName.EndsWith("Control"))
            {
                controlName = controlName.Substring(0, controlName.Length - ControlSuffix.Length);
            }

            var viewModelName = string.Concat(controlName, ViewModelSuffix);

            var viewModelType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(p => p.IsClass)
                .First(x => x.Name == viewModelName);

            var viewModel = Mvx.IoCProvider.Resolve(viewModelType) as IMvxViewModel;

            return viewModel;
        }
    }
}
