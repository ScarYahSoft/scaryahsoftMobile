using ScaryahSoft.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScaryahSoft.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public NavigationPage NP;
        public LoginPage()
        {
            InitializeComponent();
            //LoginViewModel nr = new LoginViewModel();
            //nr.navigation = Navigation;
            //this.BindingContext = nr;

            NP = new NavigationPage(new LoginPage());



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             NP = new NavigationPage(new RegisterPage());
           
            NP.Title = "Registro de usuarios";
          
           
            this.Navigation.PushModalAsync(NP);
        }
    }
}