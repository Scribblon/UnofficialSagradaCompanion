using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnofficialSagradaCompanion.CustomElements;
using UnofficialSagradaCompanion.Resources;
using UnofficialSagradaCompanion.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerNameView : ContentPage
    {

        public PlayerNameView(PlayerBoard[] boards)
        {
            // Init
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            // Set Binding
            BindingContext = new PlayerNameViewModel(boards);

            // Set first Rowdefenition as *
            PlayerGrid.RowDefinitions.Add(new RowDefinition()
            {
                Height = GridLength.Star,
            });

            // Generate and place elements to enter player names
            for (int i = 0; i < boards.Length; i++)
            {
                // Add row for each player
                PlayerGrid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = GridLength.Auto,
                });

                // Create Box For CoinIcon and add to grid
                BoxView icon = new BoxView()
                {
                    HeightRequest = 10,
                    WidthRequest = 10,
                };
                PlayerGrid.Children.Add(icon, 0, i + 1);

                // Create Entry for player name and add to grid
                Entry entry = new PlayerEntry(boards[i])
                {
                    IsTextPredictionEnabled = false,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Placeholder = $"Player {boards[i].ToString()}",
                };
                // Add listeners for unfocus and enter-press
                entry.Unfocused += (sender, args) => Entry_UnFocussed(sender, args);
                entry.Completed += (sender, args) => Entry_Compleded(sender, args);
                // Add to the grid
                PlayerGrid.Children.Add(entry, 1, i + 1);
            }

            // Add closing row
            PlayerGrid.RowDefinitions.Add(new RowDefinition()
            {
                Height = GridLength.Star,
            });
        }

        protected void Entry_UnFocussed(object sender, EventArgs e)
        {
            // Cast
            PlayerEntry entry = (PlayerEntry) sender;
            PlayerNameViewModel model = (PlayerNameViewModel) BindingContext;
            // Set in model
            model.SetPlayerName(entry.BoardType, entry.Text);
        }

        protected void Entry_Compleded(object sender, EventArgs args)
        {
            //Send to Unfocused as it is doing the same thing
            Entry_UnFocussed(sender, args);
            SetNextFocus((Entry)sender);

        }

        private void SetNextFocus(Entry sender)
        {
            // Set focus on next entry element. This assumes that elements are in same column in grid.
            int index = PlayerGrid.Children.IndexOf(sender);
            if(index + PlayerGrid.ColumnDefinitions.Count < PlayerGrid.Children.Count)
                PlayerGrid.Children.ElementAt(index + PlayerGrid.ColumnDefinitions.Count).Focus();
        }

        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScoringView((BindingContext as PlayerNameViewModel).PlayerNames));
        }
    }
}