using Ninject.Modules;
using NinjectDI.Services;
using NinjectDI.Interfaces;
using NinjectDI.Views;
using NinjectDI.ViewModels;

namespace NinjectDI
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INumberService>().To<RandomNumberService>().Named("Random");
            Bind<INumberService>().To<AdditionNumberService>().Named("Addition");

            Bind<MainWindow>().To<MainWindow>();
            Bind<MainWindowViewModel>().To<MainWindowViewModel>();
        }
    }
}
