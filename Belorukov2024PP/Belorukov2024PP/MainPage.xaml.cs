using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Belorukov2024PP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private async void Avtor_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                await DisplayAlert("Ошибка", "Логин не может быть пустым", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                await DisplayAlert("Ошибка", "Пароль не может быть пустым", "OK");
                return;
            }
            await Navigation.PushAsync(new PolzovatelFarma());
        }
         private async void Reg_Clicked(object sender, EventArgs e)
         {
            await Navigation.PushAsync(new Registracia());
         }
    }
}
