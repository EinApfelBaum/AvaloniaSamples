using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace StringFormat.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _myText;
        public string MyText
        {
            get { return _myText; }
            set
            {
                this.RaiseAndSetIfChanged(ref _myText, value);
            }
        }

        public MainWindowViewModel()
        {
            MyText = "world";
        }
    }
}
