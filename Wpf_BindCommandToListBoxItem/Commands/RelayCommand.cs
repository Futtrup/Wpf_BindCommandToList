using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_BindCommandToListBoxItem.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _handler;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> handler, Predicate<object> canExecute)
        {
            _handler = handler;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) => _canExecute(parameter); // Invoke???
        public void Execute(object parameter) => _handler(parameter);
    }
}
