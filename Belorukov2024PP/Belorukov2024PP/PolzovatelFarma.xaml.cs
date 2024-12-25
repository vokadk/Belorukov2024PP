using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Belorukov2024PP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolzovatelFarma : ContentPage
    {
        public PolzovatelFarma()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Read_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReadBook());
        }
    }
}