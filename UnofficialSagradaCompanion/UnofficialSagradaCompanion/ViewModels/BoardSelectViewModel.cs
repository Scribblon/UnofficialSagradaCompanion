using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UnofficialSagradaCompanion.Models;
using UnofficialSagradaCompanion.Resources;
using Xamarin.Forms;

namespace UnofficialSagradaCompanion.ViewModels
{
    public class BoardSelectViewModel : ViewModelBase
    {
        private int playerCount = 0;

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

        protected Dictionary<PlayerBoard, bool> PlayerSelect;

        public BoardSelectViewModel()
        {
            PlayerSelect = DefaultSettings.DefaultActiveBoards;
        }

    }
}
