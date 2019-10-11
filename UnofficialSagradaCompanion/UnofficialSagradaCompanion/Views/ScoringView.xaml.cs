using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnofficialSagradaCompanion.Resources;
using UnofficialSagradaCompanion.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoringView : ContentPage
    {
        public ScoringView(Dictionary<PlayerBoard, string> players)
        {
            // Init
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            // Set Binding
            BindingContext = new ScoringViewModel(players);

            // Bind Table?
        }

        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync();
        }
    }
}