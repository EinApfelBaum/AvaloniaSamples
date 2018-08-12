using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Microsoft.Extensions.DependencyInjection;

namespace MicrosoftExtensions
{
    class Program
    {
        private ServiceProvider _container { get; set; }
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            App app = new App(serviceCollection);
            BuildAvaloniaApp(app);
            app.Start();

        }

        public static AppBuilder BuildAvaloniaApp(App app)
            => AppBuilder.Configure(app)
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug().SetupWithoutStarting();    
    }
}
