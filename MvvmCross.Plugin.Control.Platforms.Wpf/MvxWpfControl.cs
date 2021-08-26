using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace MvvmCross.Plugin.Control.Platforms.Wpf
{
    public class MvxWpfControl : MvxWpfView, IMvxControl
    {
        public MvxWpfControl()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                return;
            }

            if (!Mvx.IoCProvider.CanResolve<IViewModelFinder>())
            {
                new Plugin().Load();
            }

            var finder = Mvx.IoCProvider.Resolve<IViewModelFinder>();
            var viewModel = finder.FindView(this);

            ViewModel = viewModel;
        }

        private bool _initializeOnLoad;
        public bool InitializeOnLoad
        {
            get => _initializeOnLoad;
            set
            {
                _initializeOnLoad = value;
                if (_initializeOnLoad)
                {
                    ViewModel.Initialize();
                }
            }
        }

    }
}
