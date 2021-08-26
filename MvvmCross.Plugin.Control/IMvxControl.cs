using MvvmCross.ViewModels;
using MvvmCross.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCross.Plugin.Control
{
    public interface IMvxControl : IMvxView
    {
        bool InitializeOnLoad { get; set; }
    }
}
