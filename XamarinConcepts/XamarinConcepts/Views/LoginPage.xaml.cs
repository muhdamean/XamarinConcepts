using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinConcepts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinConcepts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //userTitle = "User Address";
            //PasswordTitle = "Your Password here";
            this.BindingContext = new LoginViewModel();

        }
        private string userTitle;
        private string pwTitle;

        public string UserTitle
        {
            get { return userTitle; }
            set { userTitle = value; }
        }
        public string PasswordTitle
        {
            get { return pwTitle; }
            set { pwTitle = value; }
        }
    }
}
