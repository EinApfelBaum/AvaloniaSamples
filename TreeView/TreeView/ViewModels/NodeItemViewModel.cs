using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace TreeView.ViewModels
{
    public class NodeItemViewModel : BaseViewModel
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref _name, value); }
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set { this.RaiseAndSetIfChanged(ref _id, value); }
        }

        public ReactiveList<FunctionItemViewModel> Functions { get; }

        public NodeItemViewModel()
        {
            Functions = new ReactiveList<FunctionItemViewModel>();
        }

    }
}
