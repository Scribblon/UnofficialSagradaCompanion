using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.ViewModels
{
    class PlayerNameViewModel : ViewModelBase
    {
        private int playerCount;

        public String PlayerCount
        {
            set
            {
                if (int.TryParse(value, out int result))
                    playerCount = result;
                else
                    playerCount = 0;
                OnPropertyChanged(nameof(PlayerCount));
            }
            get
            {
                return playerCount.ToString();
            }
        }
        public Dictionary<PlayerBoard, string> PlayerNames { get; private set; }

        public PlayerNameViewModel(PlayerBoard[] boards)
        {
            // Create and set Dictionary for names
            PlayerNames = new Dictionary<PlayerBoard, string>();
            foreach (PlayerBoard board in boards)
                PlayerNames.Add(board, "");
            playerCount = boards.Length;
        }

    }
}
