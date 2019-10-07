using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using UnofficialSagradaCompanion.ViewModels;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoardSelect : ContentPage
    {
        public BoardSelect()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new BoardSelectViewModel();

        }
        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerNameSelect());
        }
    }
}