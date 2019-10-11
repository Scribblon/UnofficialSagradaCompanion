using System;
using System.Collections.Generic;
using System.Text;
using UnofficialSagradaCompanion.Resources;

namespace UnofficialSagradaCompanion.ViewModels
{
    class PlayerNameViewModel : ViewModelBase
    {
        public String PlayerCount
        {
            private set { }
            get
            {
                return PlayerNames.Count.ToString();
            }
        }
        public Dictionary<PlayerBoard, string> PlayerNames { get; private set; }

        public PlayerNameViewModel(PlayerBoard[] boards)
        {
            // Create and set Dictionary for names
            PlayerNames = new Dictionary<PlayerBoard, string>();
            foreach (PlayerBoard board in boards)
                PlayerNames.Add(board, "");
        }

        public void SetPlayerName(PlayerBoard board, String name)
        {
            PlayerNames[board] = name;
        }

    }
}
