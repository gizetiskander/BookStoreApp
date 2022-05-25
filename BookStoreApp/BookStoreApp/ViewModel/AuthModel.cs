using BookStoreApp.Models;
using BookStoreApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookStoreApp.ViewModel
{
    public class AuthModel : INotifyPropertyChanged
    {
        public AuthModel()
        {
            LoginCommand = new Command(LoginBtn);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand LoginCommand { protected set; get; }
        public ICommand RegistrationCommand { protected set; get; }

        public INavigation Navigation { get; set; }
        public Users Users { get; private set; } = new Users();


        public string Login
        {
            get { return Users.Login; }
            set
            {
                Users.Login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return Users.Password; }
            set
            {
                Users.Password = value;
                OnPropertyChanged("Password");
            }
        }



        private async void LoginBtn()
        {
            var lst = App.Db.GetUsers();
            bool state = false;

            foreach (var item in lst)
            {
                if (item.Login == Users.Login)
                {
                    if (item.Password == Users.Password && state == false)
                    {
                        state = true;
                        await Navigation.PushModalAsync(new NavigationPage(new ViewBookPage()));
                    }
                }
            }

            if (!state)
                await App.Current.MainPage.DisplayAlert("Уведомление", "Не правилный логин или пароль", "Ok");
        }
    }
}
