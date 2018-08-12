using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MicrosoftExtensions.ViewModels;

namespace MicrosoftExtensions.Views
{
    public class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel viewmodel)
        {
            DataContext = viewmodel;
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
