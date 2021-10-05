using FieldApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace FieldApp.ViewModel.Commands
{
    public class RegisterUserCommand : ICommand
    {
        private RegisterVM viewModel {  get; set; }

        public RegisterUserCommand(RegisterVM registerVM)
        {
            this.viewModel = registerVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {

            User user = (User)parameter;

            if (user != null)
            {
                if (user.Password == user.ConfPassword)
                {
                    if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                    {
                        return false;
                    }
                    else
                    {
                        var emailRegex = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

                        if (!Regex.IsMatch(user.Email, emailRegex)){
                            return false;
                        }
                        return true;
                    }

                    
                }

                return false;
            }

            return false;
        }

        public void Execute(object parameter)
        {
            User user = (User)parameter;
            this.viewModel.RegisterUser(user);
        }
    }
}
