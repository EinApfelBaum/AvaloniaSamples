using Avalonia;
using Avalonia.Logging.Serilog;
using NinjectDI.ViewModels;
using NinjectDI.Views;
using Ninject;

namespace NinjectDI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = BuildKernel();
            
            var appbuilder = BuildAvaloniaApp();
            appbuilder.SetupWithoutStarting();

            var app = appbuilder.Instance as App;
            
            app.Start(kernel);
        }

        private static StandardKernel BuildKernel()
        {
            return new StandardKernel(new AppModule());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
