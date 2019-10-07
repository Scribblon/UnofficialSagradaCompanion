using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UnofficialSagradaCompanion.Models;
using UnofficialSagradaCompanion.Models.Resources;
using Xamarin.Forms;

namespace UnofficialSagradaCompanion.ViewModels
{
    public class BoardSelectViewModel : ViewModelBase
    {
        public ICommand PressBoardButton { get; private set; }

        private Dictionary<PlayerBoard, bool> PlayerSelect;

        public BoardSelectViewModel()
        {
            PlayerSelect = DefaultSettingsModel.DefaultActiveBoards;

            PressBoardButton = new Command((PlayerBoard) =>
            {
                //It works. Figure out how to interpret the input and change the stuff.
                Console.WriteLine("Button Pressed! ");
            }
            );
            
        }
    }
}
