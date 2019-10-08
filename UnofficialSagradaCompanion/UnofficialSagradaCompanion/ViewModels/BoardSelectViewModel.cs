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
        private int boardCount = 0;
        private bool canNext = true;

        public String BoardCount
        {
            set
            {
                if (int.TryParse(value, out int result))
                    boardCount = result;
                else
                    boardCount = 0;
                OnPropertyChanged(nameof(BoardCount));
            }
            get
            {
                return boardCount.ToString();
            }
        }

        public String CanNext
        {
            set
            {
                if (bool.TryParse(value, out bool result))
                    canNext = result;
                else
                    canNext = false;
                OnPropertyChanged(nameof(CanNext));
            }
            get
            {
                return canNext.ToString();
            }
        }

        protected Dictionary<PlayerBoard, bool> BoardSelect;

        public BoardSelectViewModel()
        {
            BoardSelect = new Dictionary<PlayerBoard, bool>(DefaultSettings.DefaultActiveBoards);
            boardCount = CountActiveBoards();
            OnPropertyChanged(nameof(BoardCount));
        }

        public void SetBoardStatus(PlayerBoard board, bool isSelected)
        {
            if (BoardSelect[board] != isSelected)
            {
                // Set new value for board and report change to View
                BoardSelect[board] = isSelected;
                boardCount = CountActiveBoards();
                OnPropertyChanged(nameof(BoardCount));

                // Check if user can continue and report change to View
                bool nowNext = boardCount > 0;
                if (canNext != nowNext)
                {
                    canNext = nowNext;
                    OnPropertyChanged(nameof(CanNext));
                }


                    
            }
            
        }

        public PlayerBoard[] GetSelectedBoards()
        {
            PlayerBoard[] selectedBoards = new PlayerBoard[boardCount];
            int i = 0;
            foreach (KeyValuePair<PlayerBoard, bool> kvp in BoardSelect)
            {
                if(kvp.Value)
                    selectedBoards[i] = kvp.Key;
                i++;
            }

            return selectedBoards;
        }

        private int CountActiveBoards()
        {
            int count = 0;

            foreach(KeyValuePair<PlayerBoard, bool> kvp in BoardSelect)
                if (kvp.Value)
                    count++;

            return count;
        }
    }
}
