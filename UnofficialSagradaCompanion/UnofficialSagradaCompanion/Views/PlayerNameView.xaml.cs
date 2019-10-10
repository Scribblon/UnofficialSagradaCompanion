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
    public partial class PlayerNameView : ContentPage
    {

        public PlayerNameView(PlayerBoard[] boards)
        {
            // Init
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            // Set Binding
            BindingContext = new PlayerNameViewModel(boards);

            // Generate and place elements to enter player names
            foreach (PlayerBoard board in boards)
            {
                // Create new horizontal StackLayout
                StackLayout stack = new StackLayout();

                // Create Box for icon and Entry for text
                BoxView icon = new BoxView()
                {
                    HeightRequest = 10,
                    WidthRequest = 10,
                };
                Entry entry = new Entry()
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };

                // Insert the elements into horizontal stack
                stack.Children.Add(icon);
                stack.Children.Add(entry);

                // Insert into PlayerStack
                PlayerStack.Children.Add(stack);
            }

        }

        protected void Entry_Focussed(object sender, EventArgs e)
        {

        }

        protected void Entry_UnFocussed(object sender, EventArgs e)
        {

        }

        protected async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScoringView());
        }
    }
}