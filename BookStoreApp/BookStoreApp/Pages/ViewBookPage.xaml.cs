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
    public partial class ViewBookPage : ContentPage
    {
        public ViewBookPage()
        {
            InitializeComponent();
        }
    }
}