using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerNameSelect : ContentPage
    {
        public PlayerNameSelect()
        {
            InitializeComponent();
        }

        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scoring());
        }
    }
}