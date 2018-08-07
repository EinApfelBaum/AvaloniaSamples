using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TreeView.ViewModels;

namespace TreeView
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
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
