
using MicrosoftExtensions.Interfaces;
using ReactiveUI;

namespace MicrosoftExtensions.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private INumberService _numberService;

        public ReactiveCommand GetNumberCommand { get; set; }

        public MainWindowViewModel(INumberService numberService)
        {
            _numberService = numberService;
            GetNumberCommand = ReactiveCommand.Create(() =>
            {
                Number = _numberService.GetNumber();
            });
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { this.RaiseAndSetIfChanged(ref _number, value); }
        }
    }
}
