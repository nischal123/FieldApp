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
    public partial class RegisterPage : ContentPage
    {

        RegisterVM viewModel;
        public RegisterPage()
        {
            InitializeComponent();

            // init view model
            viewModel = new RegisterVM();
            BindingContext = viewModel;
        }
    }
}