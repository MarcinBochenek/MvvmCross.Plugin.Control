using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Plugin.Control.Sample.Core;
using Serilog;
using Serilog.Extensions.Logging;

namespace MvvmCross.Plugin.Control.Sample.Wpf
{
    public class Setup : MvxWpfSetup<Core.App>
    {
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Trace()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override void RegisterBindingBuilderCallbacks(IMvxIoCProvider iocProvider)
        {
            // register services
            iocProvider.RegisterType<IService, Service>();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);

            pluginManager.EnsurePluginLoaded<MvvmCross.Plugin.Control.Plugin>(true);
        }
    }
}
