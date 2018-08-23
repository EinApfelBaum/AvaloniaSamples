using Avalonia;
using Avalonia.Markup.Xaml;
using Ninject;
using NinjectDI.ViewModels;
using NinjectDI.Views;

namespace NinjectDI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        internal void Start(IKernel kernel)
        {

            MainWindowViewModel viewmodel = kernel.Get<MainWindowViewModel>();
            MainWindow view = kernel.Get<MainWindow>();

            
            view.DataContext = viewmodel;
            view.Show();
            Run(view);
        }
    }
}
