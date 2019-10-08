using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using UnofficialSagradaCompanion.ViewModels;
using UnofficialSagradaCompanion.CustomElements;
using UnofficialSagradaCompanion.Models;
using System.Collections.Generic;
using UnofficialSagradaCompanion.Resources;

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
            foreach(KeyValuePair<PlayerBoard,bool> kvp in DefaultSettings.DefaultActiveBoards)
            {
                // Create and format button
                BoardSelectToggleButton button = new BoardSelectToggleButton(kvp.Key)
                {
                    Text = kvp.Key.ToString(),
                    IsToggled = kvp.Value,
                    Style = Application.Current.Resources["BoardToggleButton"] as Style,                    
                };
                // Bind command to button
                button.Clicked += (sender, args) => Board_Clicked(sender, args);

                // Set button to the right state
                VisualStateManager.GoToState(button, kvp.Value ? "ToggledOn" : "ToggledOff");

                // Set in Grid
                int x = (int)kvp.Key % PlayerSelectGrid.ColumnDefinitions.Count;
                int y = (int)kvp.Key / PlayerSelectGrid.ColumnDefinitions.Count;
                PlayerSelectGrid.Children.Add(button, x, y);
            }

        }
        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerNameSelect(((BoardSelectViewModel) BindingContext).GetSelectedBoards()));
        }
        //When a board is clicked it passes the change along to the ViewModel
        protected void Board_Clicked(object sender, EventArgs e)
        {
            BoardSelectToggleButton button = (BoardSelectToggleButton)sender;
            ((BoardSelectViewModel)BindingContext).SetBoardStatus(button.ButtonOfBoard, button.IsToggled);
        }
    }
}