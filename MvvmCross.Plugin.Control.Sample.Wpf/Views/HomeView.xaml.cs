using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Plugin.Control.Sample.Core.ViewModels;
using MvvmCross.ViewModels;
using System.Windows.Controls;

namespace MvvmCross.Plugin.Control.Sample.Wpf.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(HomeViewlModel))]
    public partial class HomeView : MvxWpfView
    {
        public HomeView() => InitializeComponent();
    }
}
