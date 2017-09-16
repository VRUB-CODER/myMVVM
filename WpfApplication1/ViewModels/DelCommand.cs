using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.ViewModels
{
    class DelCommand : ICommand
    {

        private readonly Action _action;
        private Func<bool> WhentoExecute;

        public DelCommand(Action action, Func<bool> When)
        {
            _action = action;
            WhentoExecute = When;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return WhentoExecute();
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
