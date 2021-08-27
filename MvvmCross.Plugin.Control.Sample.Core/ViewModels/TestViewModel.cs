using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvmCross.Plugin.Control.Sample.Core.ViewModels
{
	public class TestViewModel : MvxViewModel
	{
		private readonly IService service;

		public TestViewModel(IService service)
        {
            this.service = service;
        }

        private string _hello = "Not initialized";
        public string Hello
		{
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public override Task Initialize()
        {
            Hello = this.service.GetValue();
            base.Initialize();

            return Task.CompletedTask;
        }
    }
}
