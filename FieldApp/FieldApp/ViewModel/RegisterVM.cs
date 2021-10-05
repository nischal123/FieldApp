using FieldApp.Model;
using FieldApp.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FieldApp.ViewModel
{
    public class RegisterVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterUserCommand RegisterUserCommand {  get; set; }

        private User user;

        public User User
        {
            get { return user; }
            set { 
                user = value;
                onPropertyChanged("User");
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;

                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password,
                    ConfPassword = this.ConfPassword
                };
                onPropertyChanged("Email");
            }
        }
               

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;

                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password,
                    ConfPassword = this.ConfPassword
                };
                onPropertyChanged("Password");


            }
        }
        private string confPassword;

        public string ConfPassword
        {
            get { return confPassword; }
            set
            {
                confPassword = value;

                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password,
                    ConfPassword = this.ConfPassword
                };
                onPropertyChanged("ConfPassword");


            }
        }

        public RegisterVM()
        {
            RegisterUserCommand = new RegisterUserCommand(this);
        }

        public void RegisterUser(User user)
        {

            if (User.CreateUser(user)) 
            {
                App.Current.MainPage.DisplayAlert("Success", "Added", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Not Added", "OK");
            }
        }


        private void onPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
