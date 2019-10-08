using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using UnofficialSagradaCompanion.ViewModels;
using UnofficialSagradaCompanion.CustomElements;
using UnofficialSagradaCompanion.Models;
using System.Collections.Generic;
using UnofficialSagradaCompanion.Models.Resources;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoardSelect : ContentPage
    {
        // This is the screen to select the boards that are in play
        // Generates the buttons from an enum
        public BoardSelect()
        {
            // Init
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            // Setting the viewmodel for the view
            BindingContext = new BoardSelectViewModel();

            // Generate and place buttons in the grid
            foreach(KeyValuePair<PlayerBoard,bool> kvp in DefaultSettingsModel.DefaultActiveBoards)
            {
                // Create and format button
                BoardSelectToggleButton button = new BoardSelectToggleButton(kvp.Key)
                {
                    Text = kvp.Key.ToString(),
                    IsToggled = kvp.Value,
                    Style = Application.Current.Resources["BoardToggleButton"] as Style,
                };
                VisualStateManager.GoToState(button, kvp.Value ? "ToggledOn" : "ToggledOff");

                // Set in Grid
                int x = (int)kvp.Key % PlayerSelectGrid.ColumnDefinitions.Count;
                int y = (int)kvp.Key / 2;
                PlayerSelectGrid.Children.Add(button, x, y);
            }

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