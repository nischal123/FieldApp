using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FieldApp.ViewModel.Commands
{
    public class RegisterNavigationCommand : ICommand
    {



        public event EventHandler CanExecuteChanged;

        public LoginVM viewModel;

        public RegisterNavigationCommand(LoginVM viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.viewModel.Navigate();
        }
    }
}
