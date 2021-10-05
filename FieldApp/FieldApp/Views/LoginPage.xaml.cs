using FieldApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        LoginVM viewModel;
        public LoginPage()
        {
            InitializeComponent();

            // bind view model
            viewModel = new LoginVM();
            BindingContext = viewModel;

            //set image path 
            var assembly = typeof(LoginPage);
            iconImage.Source = ImageSource.FromResource("FieldApp.Assets.Images.logo.png", assembly);
        }
    }
}