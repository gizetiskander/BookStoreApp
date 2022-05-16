using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookStoreApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBookPage : ContentPage
    {
        public MainBookPage()
        {
            InitializeComponent();
        }

        private async void AuthorizationPageBTN_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthPage());
        }
    }
}