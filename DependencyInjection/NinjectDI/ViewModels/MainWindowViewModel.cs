using Ninject;
using NinjectDI.Interfaces;
using NinjectDI.Services;
using ReactiveUI;

namespace NinjectDI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel([Named("Random")]INumberService randomService, [Named("Addition")]INumberService additionService)
        {
            _randomNumberService = new RandomNumberService();
            _additionNumberService = new AdditionNumberService();
            
            GetRandomNumberCommand = ReactiveCommand.Create(() =>
            {
                Number = _randomNumberService.GetNumber();
            });
            GetAdditionNumberCommand = ReactiveCommand.Create(() =>
            {
                Number = _additionNumberService.GetNumber();
            });
        }
        private INumberService _randomNumberService;
        private INumberService _additionNumberService;

        public ReactiveCommand GetRandomNumberCommand { get; set; }
        public ReactiveCommand GetAdditionNumberCommand { get; set; }



        private string _number;

        public string Number
        {
            get { return _number; }
            set { this.RaiseAndSetIfChanged(ref _number, value); }
        }

    }
}
