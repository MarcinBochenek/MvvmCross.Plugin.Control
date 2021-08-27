using MvvmCross.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmCross.Plugin.Control
{
    class ViewModelRegisterer : IViewModelRegisterer
    {
        public void RegisterAllViewModels()
        {
            var viewModels = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => x.Name.EndsWith("ViewModel"));
            
            viewModels.ToList().ForEach(p => MvxIoCContainerExtensions.RegisterType(Mvx.IoCProvider, p));
        }
    }
}
