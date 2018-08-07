using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace TreeView.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ReactiveList<MachineItemViewModel> Machines { get; }

        public MainWindowViewModel()
        {
            Random random = new Random();

            Machines = new ReactiveList<MachineItemViewModel>();

            for (int indexM = 0; indexM < 10; indexM++)
            {
                MachineItemViewModel machine = new MachineItemViewModel
                {
                    Name = $"machine{indexM}",
                    Id = $"{random.NextDouble()}"
                };

                for (int indexN = 0; indexN < 10; indexN++)
                {
                    NodeItemViewModel node = new NodeItemViewModel()
                    {
                        Name = $"node{indexN}",
                        Id = $"{random.NextDouble()}"
                    };

                    for (int indexF = 0; indexF < 10; indexF++)
                    {
                        node.Functions.Add(new FunctionItemViewModel()
                        {
                            Name = $"func{indexF}",
                            Id = $"{random.NextDouble() }"
                        });
                    }
                    machine.Nodes.Add(node);
                }
                Machines.Add(machine);
            }    
        }
    }
}
