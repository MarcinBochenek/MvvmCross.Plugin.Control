using MvvmCross.ViewModels;

namespace MvvmCross.Plugin.Control
{
    public interface IViewModelFinder
    {
        IMvxViewModel FindView(IMvxControl control);
    }
}