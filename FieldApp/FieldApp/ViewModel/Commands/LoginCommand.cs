using FieldApp.Model;
using FieldApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FieldApp.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public LoginVM ViewModel { get; set; }

        public LoginCommand(LoginVM vModel)
        {
            ViewModel = vModel;
        }
        public bool CanExecute(object parameter)
        {
            var user = (User)parameter;

            if (user == null) return false;
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                return false;

            else return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.Login();
        }
    }
}
