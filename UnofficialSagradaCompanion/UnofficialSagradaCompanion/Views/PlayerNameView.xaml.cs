using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnofficialSagradaCompanion.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnofficialSagradaCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerNameView : ContentPage
    {
        public Dictionary<PlayerBoard, string> PlayerNames { get; private set; }

        public PlayerNameView(PlayerBoard[] boards)
        {
            InitializeComponent();

            // Create and set Dictionary for names
            PlayerNames = new Dictionary<PlayerBoard, string>();
            foreach(PlayerBoard board in boards)
                PlayerNames.Add(board, "");
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