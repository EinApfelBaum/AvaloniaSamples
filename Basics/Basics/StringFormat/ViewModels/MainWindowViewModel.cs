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

        private float _value;
        public float Value
        {
            get { return _value; }
            set
            {
                this.RaiseAndSetIfChanged(ref _value, value);
            }
        }

        public MainWindowViewModel()
        {
            MyText = "world";
            Value = 0.132f;
        }
    }
}
