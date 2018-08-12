using Avalonia;
using Avalonia.Markup.Xaml;
using MicrosoftExtensions.ViewModels;
using MicrosoftExtensions.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MicrosoftExtensions
{
    public class App : Application
    {
        private ServiceProvider _container { get; set; }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            
        }

        public App(IServiceCollection serviceCollection)
        {
            ConfigureServices(serviceCollection);
            _container = serviceCollection.BuildServiceProvider();
            
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<Interfaces.INumberService, Services.RandomNumberService>();

            serviceCollection.AddTransient<MainWindowViewModel>();
            serviceCollection.AddTransient<MainWindow>();
        }

        internal void Start()
        {
            var mainview = _container.GetService<MainWindow>();
            mainview.Show();
            Run(mainview);
        }
    }
}
