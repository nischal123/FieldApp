using FieldApp.Model;
using FieldApp.ViewModel.Commands;
using FieldApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FieldApp.ViewModel
{
    public class LoginVM : INotifyPropertyChanged
    {

        // should be properties not attributes
        public LoginCommand LoginCommand { get; set; }
        public RegisterNavigationCommand RegisterNavigationCommand {  get; set; }


        private User user;
        public User User
        {
            get { return user; }
            set
            {
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
                    Password = this.Password
                };

                onPropertyChanged("Email");
            }
        }

        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;

                User = new User()
                {
                    Email = this.Email,
                    Password = this.Password
                };

                onPropertyChanged("Password");
            }
        }

        public async void Login()
        {
            bool isLogged = await User.Authenticate(this.User);

            if (isLogged)
            {

                // since we are not in a page we use app.current.mainpage
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("error", "Try Again", "ok");
            }

        }


            public LoginVM()
        {
            User = new User();

            LoginCommand = new LoginCommand(this);

            RegisterNavigationCommand = new RegisterNavigationCommand(this);
        }

        public async void Navigate()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
