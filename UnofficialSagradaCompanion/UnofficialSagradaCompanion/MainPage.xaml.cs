using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnofficialSagradaCompanion.Views;
using Xamarin.Forms;

namespace UnofficialSagradaCompanion
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Quick_Scoring_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoardSelect());
        }
    }
}
